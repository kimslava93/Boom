using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.Models;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    class CloseSessionController
    {
        private static CloseSessionController _closeSessionController;
        public static CloseSessionController InstanceCloseSessionController()
        {
            return _closeSessionController ?? (_closeSessionController = new CloseSessionController());
        }

        public void CloseClientBeforeTimeOut(DaySessionClass sessionToClose, List<clients_per_session_t> clientOnSession, DateTime closeTime, string comments)
        {
            if (clientOnSession.Count > 0)
            {
                if (EndPointsControl.EndPointsControlInstance().SwitchOff(sessionToClose.Приставка))
                {

                    if (clientOnSession.Count == 1 && clientOnSession[0].client_id.Equals(Options.OptionsInstance().UsualClient))
                    {
                        CloseUsualClient(sessionToClose, comments, closeTime);
                    }
                    else if (clientOnSession.Count >= 1 && !clientOnSession[0].client_id.Equals(Options.OptionsInstance().UsualClient))
                        //with discount card
                    {
                        CloseClientWithDiscount(sessionToClose, comments, closeTime);
                    }
                }
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(14) +
                                sessionToClose.Сессия);
            }
        }

        private void CloseUsualClient(DaySessionClass sessionToClose, string comments, DateTime endTime)
        {
            double changeMoney =  Math.Round(GetOddMoney(sessionToClose));
            if (changeMoney > 1)
            {
                DialogResult dresult =
                    MessageBox.Show(
                        @" " + changeMoney +
                        ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(7),
                        ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetCaption(2), MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                switch (dresult)
                {
                    case DialogResult.Yes:
                        comments += ". " + changeMoney +
                                    ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(8);
                        sessionToClose.Оплачено = sessionToClose.Оплачено - changeMoney;
//                        sessionToClose.Счетчик -= changeMoney;
                        DataBaseClass.Instancedb().AddMoneyToCash(changeMoney*(-1));
                        DataBaseClass.Instancedb().CloseSessionWithUsualClient(sessionToClose, comments, endTime);
                        break;
                    case DialogResult.No:
                        DataBaseClass.Instancedb().CloseSessionWithUsualClient(sessionToClose, comments, endTime);
                        break;
                }
            }
            else DataBaseClass.Instancedb().CloseSessionWithUsualClient(sessionToClose, comments, endTime);
        }

        private void CloseClientWithDiscount(DaySessionClass sessionToClose, string comments, DateTime endTime)
        {
            sessionToClose = DataBaseClass.Instancedb().AccountDiscountMoney(sessionToClose);
            double changeMoney = Math.Round(GetOddMoney(sessionToClose),0);
            if (changeMoney > 1)
            {
                DialogResult dresult =
                    MessageBox.Show(
                        @" " + changeMoney +
                        ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(7),
                        ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetCaption(2), MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                switch (dresult)
                {
                    case DialogResult.Yes:
                        comments += ". " + changeMoney +
                                    ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(8);
                        sessionToClose.Оплачено = sessionToClose.Оплачено - changeMoney;
                        sessionToClose.Счетчик -= changeMoney;
                        DataBaseClass.Instancedb().AddMoneyToCash(changeMoney * (-1));
                        DataBaseClass.Instancedb().CloseSessionWithCard(sessionToClose, comments, endTime);
                        break;
                    case DialogResult.No:
                        DataBaseClass.Instancedb().CloseSessionWithCard(sessionToClose, comments, endTime);
                        break;
                }
            }
            else DataBaseClass.Instancedb().CloseSessionWithCard(sessionToClose, comments, endTime);
//---------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------
//--------------------------------------When client will be able to store money on card--------------------------------------
//---------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------
            //DataBaseClass.Instancedb().CloseSessionWithCard(sessionToClose, comments, endTime);
//---------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------
        }

        private double GetOddMoney(DaySessionClass sessionToCalculate)
            //substract one hour from game if client was playing lower than one hour 
        {
            double moneyPlayed = sessionToCalculate.Счетчик;
            double oneHourPrice = AddNewSessionModel.InstanceAddNewSessionModel()
                .GetSumToPay(sessionToCalculate.Приставка, TimeSpan.FromHours(1), sessionToCalculate.Начало);
            if (moneyPlayed <= oneHourPrice && (sessionToCalculate.Оплачено - oneHourPrice) <= 0)
            {
                return 0;
            }
            if (moneyPlayed <= oneHourPrice && (sessionToCalculate.Оплачено - oneHourPrice) > 1)
            {
                return sessionToCalculate.Оплачено - oneHourPrice;
            }
            if (moneyPlayed > oneHourPrice)
            {
                return sessionToCalculate.Счетчик;
                    //sessionToCalculate.Оплачено - sessionToCalculate.Счетчик;
            }
            return 0;
        }

        public int ExpandForProblemReportOrMinimize(int height)
        {
            height = height <= 250 ? 450 : 250;
            return height;
        }
    }
}
