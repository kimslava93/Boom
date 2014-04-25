﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    public class MainFormController
    {
        private List<DaySessionClass> _currentDaySessionList;
        private List<clients_per_session_t> _clentsList;
        private global_session_t _currentGlobalSession;
        private static MainFormController _mfController;

        public static MainFormController MfController()
        {
            return _mfController ?? (_mfController = new MainFormController());
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
                _currentDaySessionList = GetDailySession(_currentGlobalSession.daily_id, _clentsList);
            }
        }
        public List<DaySessionClass> GetAllOpenedDaySessions()
        {
            int dailyId = DataBaseClass.Instancedb().GetLastOpenedGlobalSession();
            List<clients_per_session_t> clientsPerSessionList = DataBaseClass.Instancedb().GetListOfClientsPerSessionT();
            return DataBaseClass.Instancedb().GetOpenedDaySessions(dailyId, clientsPerSessionList);
        }
        public List<DaySessionClass> GetDailySession(int dailyId, List<clients_per_session_t> clientsPerSessionList)
        {
            var db = DataBaseClass.Instancedb();
            return  db.GetOpenedDaySessions(dailyId, clientsPerSessionList) /*))*/;
        }

        public void AddNewClient()
        {

        }
    }
}
