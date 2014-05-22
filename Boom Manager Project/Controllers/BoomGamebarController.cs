using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.Models;
using Boom_Manager_Project.MyClasses;
using LINQ_test.Driver;

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
                    MessageBox.Show("Please, select row that you would like to close, before it will be closed by timer");
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
                os.MoneyLeft = Math.Round(GetAlreadyPlayedMoneySum(os.PlaystationId, os.StartGame, os.PayedSum), 2);
                os.TimeLeft = GetTimeLeft(os.EndGame);
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
            double t = paidSum - AddNewSessionModel.InstanceAddNewSessionModel().GetSumToPay(plstId, paidTime, startDate);
//            MessageBox.Show(paidTime + "\n" + paidSum);
//            MessageBox.Show("paid time = " + paidTime + "\n" + t.ToString(CultureInfo.InvariantCulture));
            return t;
        }
        public List<DaySessionClass> CheckSoonToCloseClients(List<DaySessionClass> dSessions)
        {
//            List<DaySessionClass> dSessions = GetAllOpenedDaySessions();
            foreach (DaySessionClass os in dSessions)
            {
//                if (os.TimeLeft > TimeSpan.FromMinutes(5))
//                {
//                    //continue;
//                }
                if (os.TimeLeft > TimeSpan.FromMinutes(3) && os.TimeLeft < TimeSpan.FromMinutes(6))
                {
//                    HighLight(os.SessionId, 0);
                    //warning highlight
                }
                else if (os.TimeLeft > TimeSpan.FromMinutes(0) && os.TimeLeft <= TimeSpan.FromMinutes(3))
                {
//                    HighLight(os.SessionId, 1);
                }
                else if (os.TimeLeft <= TimeSpan.FromMinutes(0))
                {
                    if (os.ClientId.Equals("0"))
                    {
                        DataBaseClass.Instancedb().CloseSessionWithUsualClient(os, "", DateTime.Now);
                    }
                    else if(os.ClientId.Length > 1 && !string.IsNullOrWhiteSpace(os.ClientId))
                    {
                        DataBaseClass.Instancedb().CloseSessionWithCard(os, "", DateTime.Now);
                    }
//                    GetExactGlobalSession();
                    dSessions = GetAllOpenedDaySessions();
//                    SyncDbContextAndDaySessionList();
                }
//                dataGridViewDaysSession.Invalidate();
            }
            return dSessions;
        }

        public DaySessionClass GetSelectedSessionData(List<DaySessionClass> currentDaySessionClasses, int sessionId)
        {
            int tries = 5;
            var sessionToClose = (from sc in currentDaySessionClasses
                                  where sc.SessionId == sessionId
                                  select sc).SingleOrDefault();
            while (sessionToClose == null && tries >= 0)
            {
                tries--;
                sessionToClose = (from sc in currentDaySessionClasses
                    where sc.SessionId == sessionId
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
//            var selectedSession = DataBaseClass.Instancedb().GetDaySessionBySessionId(sessionToClose.SessionId, dailyId);
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
    }
}
