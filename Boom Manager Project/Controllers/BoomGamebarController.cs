using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
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
        private static BoomGamebarController _mfController;

        public static BoomGamebarController InstanceBgController()
        {
            return _mfController ?? (_mfController = new BoomGamebarController());
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
        public void OpeneGlobalSession()
        {
            _currentGlobalSession = GetOpenedSession();
            if (_currentGlobalSession == null)
            {
                var cs = new ChangeShift();
                cs.ShowDialog();
            }
            else
            {
                _clentsList = DataBaseClass.Instancedb().GetListOfClientsPerSessionT();
                _currentDaySessionList = GetExactDailySession(_currentGlobalSession.daily_id, _clentsList);
            }
        }
        public List<DaySessionClass> GetAllOpenedDaySessions()
        {
            int dailyId = DataBaseClass.Instancedb().GetLastOpenedGlobalSession();
            List<clients_per_session_t> clientsPerSessionList = DataBaseClass.Instancedb().GetListOfClientsPerSessionT();
            return DataBaseClass.Instancedb().GetOpenedDaySessions(dailyId, clientsPerSessionList);
        }
        public List<DaySessionClass> GetExactDailySession(int dailyId, List<clients_per_session_t> clientsPerSessionList)
        {
            var db = DataBaseClass.Instancedb();
            return db.GetOpenedDaySessions(dailyId, clientsPerSessionList);
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
                    DataBaseClass.Instancedb().TimeOutClosePlaystation(os);
//                    GetExactDailySession();
                    dSessions = GetAllOpenedDaySessions();
//                    SyncDbContextAndDaySessionList();
                }
//                dataGridViewDaysSession.Invalidate();
            }
            return dSessions;
        }
    }
}
