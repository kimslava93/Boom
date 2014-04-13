using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    class ModelGlobalSession
    {
        public global_session_t GetOpenedSession()
        {
            var db = new DataBaseClass();
            global_session_t openedSession = db.GetOpenedSession();
            if (openedSession != null)
            {
                return openedSession;
            }
            return null;
        }

        public void AddNewGlobalSession(string adminID, string operatorID, DateTime date)
        {
            var db = new DataBaseClass();
            db.AddNewGlobalSession(adminID, operatorID, date);
        }
    }
}
