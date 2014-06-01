using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.Models;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.DataBaseClasses
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

                    if (clientOnSession.Count == 1 && clientOnSession[0].client_id.Equals("0"))
                    {
                        CloseUsualClient(sessionToClose, comments, closeTime);
                    }
                    else if (clientOnSession.Count >= 1 && !clientOnSession[0].client_id.Equals("0"))
                        //with discount card
                    {
                        CloseClientWithDiscount(sessionToClose, comments, closeTime);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error! Session cannot be closed because of client absence in the session#" +
                                sessionToClose.Сессия);
            }
        }

        private void CloseUsualClient(DaySessionClass sessionToClose, string comments, DateTime endTime)
        {
            double moneyLeftWithoutHourMoney = GetMoneyLeftSum(sessionToClose);
            if (moneyLeftWithoutHourMoney > 1)
            {
                DialogResult dresult =
                    MessageBox.Show(" " + moneyLeftWithoutHourMoney + " soms left.\nWere money returned to client?",
                        "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dresult)
                {
                    case DialogResult.Yes:
                        comments += ". " + moneyLeftWithoutHourMoney + " soms were returned";
                        sessionToClose.Оплаченная_сумма = sessionToClose.Оплаченная_сумма - moneyLeftWithoutHourMoney;
                        sessionToClose.Остаток_денег -= moneyLeftWithoutHourMoney;
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
            DataBaseClass.Instancedb().CloseSessionWithCard(sessionToClose, comments, endTime);
        }

        private double GetMoneyLeftSum(DaySessionClass sessionToCalculate)
            //substract one hour from game if client was playing lower than one hour 
        {
            double moneyPlayed = sessionToCalculate.Оплаченная_сумма - sessionToCalculate.Остаток_денег;
            double oneHourpPrice = AddNewSessionModel.InstanceAddNewSessionModel()
                .GetSumToPay(sessionToCalculate.Приставка, TimeSpan.FromHours(1), sessionToCalculate.Начало);
            if (sessionToCalculate.Оплаченная_сумма < oneHourpPrice && (int)moneyPlayed == (int)sessionToCalculate.Оплаченная_сумма)//never should happen
            {
                return (double) 0;
            }
            if (moneyPlayed < oneHourpPrice)
            {
                return sessionToCalculate.Оплаченная_сумма - oneHourpPrice;
            }
            return sessionToCalculate.Остаток_денег;
        }

        public int ExpandForProblemReportOrMinimize(int height)
        {
            height = height <= 250 ? 450 : 250;
            return height;
        }
    }
}
