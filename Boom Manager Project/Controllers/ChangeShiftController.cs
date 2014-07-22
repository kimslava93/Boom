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
                return "Введите логин и пароль для принятия смены\n" +
                       //"Please input login and password to accept shift.\n" +
                       "Сразу после того как вы введете логин и пароль, \nвы примите всю ответственность состояния\n оборудованния и кассы на себя!";
                    //"By loging in you accept shift as it is, \nand take all responsibility for equipment itself";
            }
            if (type == "FirstShift")
            {
                return "До вас не было открыто ни одной сессии! Вы должны ввести логин и пароль чтобы продолжить!"; //"Your shift is the first and there is no opened one.\nYou should login to continue!";
            }
            if (type == "CloseOldSession")
            {
                return "Вы должны закрыть все предыдущие сессии!";//"You should close all old sessions!";
            }
            return "Неизвестное предупреждение! Обратитесь к разработчику!";
        }

        public bool PasswordChecking(string login, string password,string prevAdminLogin)
        {
            if (CheckPassword(login, password))
            {
                CreateNewShift(login, prevAdminLogin);
                return true;
            }
            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(10));
            return false;
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

        private void CreateNewShift(string login,string prevAdminName)
        {
            BarRevisionController.BarRevisionControllerInstance().InsertOrUpdateAllItemsInBar();
            var adminInfo = DataBaseClass.Instancedb().GetUserInfoByLogin(login);

            var lastOpenedSession = DataBaseClass.Instancedb().GetOpenedGlobalSession();
            var operatorInfo = new personal_info_t();
            var openedSessions = new List<DaySessionClass>();
            if (lastOpenedSession != null)
            {
                operatorInfo = DataBaseClass.Instancedb().GetUserInfoByPersonId(lastOpenedSession.operator_id);
                openedSessions = DataBaseClass.Instancedb().GetOpenedDaySessions(lastOpenedSession.daily_id,
                    DataBaseClass.Instancedb().GetListOfAllClientsPerSessionT());
            }
           
            DataBaseClass.Instancedb().CloseLastOpenedGlobalSession();
            if (adminInfo != null && operatorInfo != null)
            {
                DataBaseClass.Instancedb()
                    .AddNewGlobalSession(adminInfo.person_id, operatorInfo.person_id, DateTime.Now);
                TextFileWriter.TextFileWriterInstance().RecordLoginTime(adminInfo.name, prevAdminName,Options.StaffTypeAdmnistrator);
            }
            else if (adminInfo != null)
            {
                DataBaseClass.Instancedb().AddNewGlobalSession(adminInfo.person_id, "no operator", DateTime.Now);
            }
            if (openedSessions != null && openedSessions.Count > 0)
            {
                foreach (DaySessionClass t in openedSessions)
                {
                    DataBaseClass.Instancedb().TransferOpenedSessionToNextGlobalSession(t.Сессия);
                }
            }
//            lastOpenedSession = DataBaseClass.Instancedb().GetOpenedGlobalSession();
            if (lastOpenedSession != null)
            {
                var cashFromLastDailyId = DataBaseClass.Instancedb().GetCashFromDailyId(lastOpenedSession.daily_id);
                int dailyId = DataBaseClass.Instancedb().GetOpenedGlobalSession().daily_id;
                if (cashFromLastDailyId != null)
                    DataBaseClass.Instancedb().AddMoneyToCash((double) cashFromLastDailyId, dailyId);

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
