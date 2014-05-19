using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.Models;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    class ChangeShiftController
    {
        
        private static ChangeShiftController _changeShiftController;
        public static ChangeShiftController ChangeShiftControllerInstance()
        {
            return _changeShiftController ?? (_changeShiftController = new ChangeShiftController());
        }

        public bool DoesTheLastGlobalSesionIsOpened()
        {
            if (GetLastOpenedGlobalSession() != null)
            {
                return true;
            }
            return false;
        }

        public string WarningMessage(string type)
        {
            if (type == "WarningLabel")
            {
                return "Please input login and password to accept shift.\n" +
                       "By loging in you accept shift as it is, \nand take all responsibility for equipment itself";
            }
            if (type == "FirstShift")
            {
                return "Your shift is the first and there is no opened one.\nYou should login to continue!";
            }
            if (type == "CloseOldSession")
            {
                return "You should close all old sessions!";
            }
            return "";
        }

        public void PasswordChecking(string login, string password)
        {
            if (CheckPassword(login, password))
            {
                CreateNewShift(login);
            }
            else
            {
                MessageBox.Show("Login or Password is wrong!");
            }
        }

        private bool CheckPassword(string login, string password)
        {
            personal_info_t adminLogin = DataBaseClass.Instancedb().GetUserInfoByLogin(login);
            if (adminLogin != null)
            {
                if (adminLogin.staff_password == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void CreateNewShift(string login)
        {

            var adminInfo = DataBaseClass.Instancedb().GetUserInfoByLogin(login);

            var lastOpenedSession = DataBaseClass.Instancedb().GetOpenedGlobalSession();
            var operatorInfo = new personal_info_t();
            List<DaySessionClass> openedSessions = new List<DaySessionClass>();
            if (lastOpenedSession != null)
            {
                operatorInfo = DataBaseClass.Instancedb().GetUserInfoByPersonID(lastOpenedSession.operator_id);
                openedSessions = DataBaseClass.Instancedb().GetOpenedDaySessions(lastOpenedSession.daily_id,
                    DataBaseClass.Instancedb().GetListOfAllClientsPerSessionT());
            }
           
            DataBaseClass.Instancedb().CloseLastOpenedGlobalSession();
            if (adminInfo != null && operatorInfo != null)
            {
                DataBaseClass.Instancedb()
                    .AddNewGlobalSession(adminInfo.person_id, operatorInfo.person_id, DateTime.Now);
            }
            else if (adminInfo != null)
            {
                DataBaseClass.Instancedb().AddNewGlobalSession(adminInfo.person_id, "no operator", DateTime.Now);
            }
            if (openedSessions != null && openedSessions.Count > 0)
            {
                foreach (DaySessionClass t in openedSessions)
                {
                    DataBaseClass.Instancedb().TransferOpenedSessionToNextGlobalSession(t.SessionId);
                }
            }

//                MessageBox.Show(WarningMessage("CloseOldSession"),
//                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public bool ToCloseForm()
        {
           return ChangeShiftModel.ChangeShiftModelInstance().ToCloseForm();
        }

        public global_session_t GetLastOpenedGlobalSession()
        {
            return DataBaseClass.Instancedb().GetOpenedGlobalSession();
        }
    }
}
