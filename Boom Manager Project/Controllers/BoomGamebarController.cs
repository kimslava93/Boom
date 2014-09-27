using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.Models;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    public class BoomGamebarController
    {
        private List<DaySessionClass> _currentDaySessionList;
        private List<clients_per_session_t> _clentsList;
        private global_session_t _currentGlobalSession;
        private static BoomGamebarController _boomGamebarController;

        public void ShowErrorMessage(int id)
        {
            switch (id)
            {
                case 1:
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(41));
                    break;
            }
        }
       
        public static BoomGamebarController InstanceBgController()
        {
            return _boomGamebarController ?? (_boomGamebarController = new BoomGamebarController());
        }
        public List<DaySessionClass> DvgAllSessions
        {
            get
            {
                return _currentDaySessionList;
            }
            set
            {
                _currentDaySessionList = value;
            }
        }
        public global_session_t GetOpenedSession()
        {
            return DataBaseClass.Instancedb().GetOpenedGlobalSession();
        }

        public void OpenGlobalSession()
        {
            var cs = new ChangeShift(true);
            cs.ShowDialog();
            
            _currentGlobalSession = GetOpenedSession();
            _clentsList = DataBaseClass.Instancedb().GetListOfAllClientsPerSessionT();
            _currentDaySessionList = GetExactGlobalSession(_currentGlobalSession.daily_id, _clentsList);
        }

        public List<DaySessionClass> GetAllOpenedDaySessions()
        {
            int dailyId = DataBaseClass.Instancedb().GetLastOpenedGlobalSessionDailyId();
            List<clients_per_session_t> clientsPerSessionList = DataBaseClass.Instancedb().GetListOfAllClientsPerSessionT();
            return DataBaseClass.Instancedb().GetOpenedDaySessions(dailyId, clientsPerSessionList);
        }
        public List<DaySessionClass> GetExactGlobalSession(int dailyId, List<clients_per_session_t> clientsPerSessionList)
        {
            return DataBaseClass.Instancedb().GetOpenedDaySessions(dailyId, clientsPerSessionList);
        }

        public List<DaySessionClass> TimeAndMoneySubstracting(List<DaySessionClass> dSessions)
        {
            if (dSessions.Count <= 0) return dSessions;
            foreach (DaySessionClass os in dSessions)
            {
                os.Счетчик = Math.Ceiling(GetAlreadyPlayedMoneySum(os.Приставка, os.Начало, os.Оплачено));
                os.Оставшееся_время = GetTimeLeft(os.Конец);
            }
            return dSessions;
        }
        private TimeSpan GetTimeLeft(DateTime end)
        {
            TimeSpan result = end.Subtract(DateTime.Now);
            return new TimeSpan(result.Days, result.Hours, result.Minutes, result.Seconds);
        }
        public double GetAlreadyPlayedMoneySum(string plstId, DateTime startDate, double paidSum)
        {
            DateTime curTime = DateTime.Now;
            if (startDate > curTime)
            {
                startDate = startDate.Subtract(TimeSpan.FromDays(1));
            }
            if (startDate >= curTime) return 0.0;
            TimeSpan paidTime = curTime - startDate;
            double t = /*paidSum -*/ AddNewSessionModel.InstanceAddNewSessionModel().GetSumToPay(plstId, paidTime, startDate);
//            MessageBox.Show(paidTime + "\n" + paidSum);
//            MessageBox.Show("paid time = " + paidTime + "\n" + t.ToString(CultureInfo.InvariantCulture));
            return t;
        }

        public List<DaySessionClass> CheckSoonToCloseClients(List<DaySessionClass> dSessions)
        {
            foreach (DaySessionClass os in dSessions)
            {
                if (os.Оставшееся_время <= TimeSpan.FromMinutes(0))
                {
                    List<clients_per_session_t> clientPerSession =
                        DataBaseClass.Instancedb().GetListOfClientsPerExactSession(os.Сессия);
                    CloseSessionController.InstanceCloseSessionController()
                        .CloseClientBeforeTimeOut(os, clientPerSession, DateTime.Now, "");
                    dSessions = GetAllOpenedDaySessions();
                }
            }
            return dSessions;
        }

        public DaySessionClass GetSelectedSessionData(List<DaySessionClass> currentDaySessionClasses, int sessionId)
        {
            int tries = 5;
            var sessionToClose = (from sc in currentDaySessionClasses
                                  where sc.Сессия == sessionId
                                  select sc).SingleOrDefault();
            while (sessionToClose == null && tries >= 0)
            {
                tries--;
                sessionToClose = (from sc in currentDaySessionClasses
                    where sc.Сессия == sessionId
                    select sc).SingleOrDefault();
                if (sessionToClose != null) break;
            }
            return sessionToClose;
            
//            dgvOpenedSessions.Invalidate();
        }

        public List<DaySessionClass> CloseSessionBeforeTimer(DaySessionClass sessionToClose)
        {
            var csf = new CloseSessionForm(sessionToClose);
            csf.ShowDialog();
            return GetAllOpenedDaySessions();
//            int dailyId = DataBaseClass.Instancedb().GetLastOpenedGlobalSessionDailyId();
//            var selectedSession = DataBaseClass.Instancedb().GetDaySessionBySessionId(sessionToClose.Сессия, dailyId);
//            if (selectedSession != null)
//            {

//                selectedSession.money_left = (double)dataGridViewDaysSession.CurrentRow.Cells[6].Value;
//                _db.SubmitChanges();
//            }
//            var withDiscountCard = (from w in _db.clients_per_session_ts
//                                    where w.session_id == selectedSessionId
//                                    select w.client_id).ToList();
        }

        public void ExtendTime(int sessionId, List<DaySessionClass> allSessions)
        {
            var sessionToClose = GetSelectedSessionData(allSessions, sessionId);
            if (sessionToClose != null)
            {
                var et = new ExtendSessionTime(sessionToClose);
                et.ShowDialog();
            }
        }

        public void CallTimeZoneManager()
        {
            var tzm = new TimeZoneManager();
            tzm.ShowDialog();
        }

        public void CallConsoleManager()
        {
            var cm = new ConsoleManager();
            cm.ShowDialog();
        }

        public bool AskManagerPassword()
        {
            var ep = new EnterPassword("MANAGER");
            ep.ShowDialog();
            if (ep.Passed)
            {
                return true;
            }
            return false;
        }

        public string GetCurrentAdminName()
        {
            string opId = DataBaseClass.Instancedb().GetOpenedGlobalSession().administrator_id;
            if (opId == null)
            {
                return "LOG IN THE ADMINISTRATOR";
            }
            var name = DataBaseClass.Instancedb().GetUserInfoByPersonId(opId);
            return name.name;
        }
        public string GetCurrentOperatorName()
        {
            string opId = DataBaseClass.Instancedb().GetOpenedGlobalSession().operator_id;
            if (opId == "no operator" || opId == null)
            {
                return "LOG IN THE OPERATOR";
            }
            var name = DataBaseClass.Instancedb().GetUserInfoByPersonId(opId);
            return name.name;
        }
    }
}
