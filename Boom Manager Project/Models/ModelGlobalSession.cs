//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System;
using Boom_Manager_Project.DataBaseClasses;

//using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Models
{
    class ModelGlobalSession
    {
        public global_session_t GetOpenedSession()
        {
            global_session_t openedSession = DataBaseClass.Instancedb().GetOpenedGlobalSession();
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
