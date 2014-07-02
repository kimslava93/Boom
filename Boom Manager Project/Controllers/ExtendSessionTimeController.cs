using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.Models;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    internal class ExtendSessionTimeController
    {
        public Point VisibleLocation = new Point(24, 61);
        public Point HiddenLocation = new Point(513, 61);

        private static ExtendSessionTimeController _extendSessionTimeController;

        public static ExtendSessionTimeController ExtendSessionTimeControllerInstance()
        {
            return _extendSessionTimeController ?? (_extendSessionTimeController = new ExtendSessionTimeController());
        }

        public void ExtendTimeForSession(DaySessionClass sessionToExtend, int hoursToExtend, int minutesToExtend,
            double moneyToExtend)
        {
            TimeSpan t = TimeSpan.FromHours(hoursToExtend).Add(TimeSpan.FromMinutes(minutesToExtend));
            DataBaseClass.Instancedb().ExtendGameTimeWithUsualClient(sessionToExtend, t, moneyToExtend);
        }

        public List<MyString> GetClientsTable(int sessionId)
        {
            var result = new List<MyString>();
            var clientsPerSession = DataBaseClass.Instancedb().GetListOfClientsPerExactSession(sessionId);

            if (clientsPerSession != null)
            {
                result.AddRange(clientsPerSession.Select(t1 => new MyString(t1.client_id)));
            }
            return result;
        }

        public void AddMoney(string clientId)
        {
            var amodc = new AddMoneyOnDiscountCard(clientId);
            amodc.ShowDialog();
        }

        private List<clients_per_session_t> GetClientsPesSession(int sessionId)
        {
            return DataBaseClass.Instancedb().GetListOfClientsPerExactSession(sessionId);
        }

        public double GetClientsDiscountInfoBySessionId(int sessioId)
        {
            string clientId = @"Usual Client";
            var clientsPerSession = GetClientsPesSession(sessioId);
            if (clientsPerSession.Count == 1)
            {
                clientId = clientsPerSession[0].client_id;
            }
            else
            {
                ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(38);
            }
            var persDiscount = DataBaseClass.Instancedb().GetClientInfoById(clientId).pers_discount;
            if (persDiscount != null)
                return (double) persDiscount;
            return 0;
        }
        
        public void UpdatePrices(DaySessionClass sessionToUpdate) //, List<clients_per_session_t> clientsPerSession)
        {
//            TimeSpan timeToPlay = new TimeSpan();
            List<clients_per_session_t> clientsPerSession =
                DataBaseClass.Instancedb().GetListOfClientsPerExactSession(sessionToUpdate.Сессия);
            double sumToPlay =
                clientsPerSession.Select(t1 => DataBaseClass.Instancedb().GetClientSavingsById(t1.client_id))
                    .Select(moneyOnCard => moneyOnCard.savings)
                    .Sum();
            TimeSpan t = AddNewSessionModel.InstanceAddNewSessionModel()
                .GetTimeToPlay(sumToPlay, sessionToUpdate.Приставка, sessionToUpdate.Начало);
//            MessageBox.Show("new sum to play = " + sumToPlay + "\nnew time to play = " + t);
            DataBaseClass.Instancedb().ExtendGameTimeWithClientWithDiscountCard(sessionToUpdate, t, sumToPlay);
        }
    }
}
