using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.Models;
using Boom_Manager_Project.MyClasses;
using LINQ_test;

namespace Boom_Manager_Project
{
    internal class ExtendSessionTimeController
    {
        public Point VisibleLocation = new Point(24, 61);
        public Point HiddenLocation = new Point(405, 61);

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

        public void UpdatePrices(DaySessionClass sessionToUpdate) //, List<clients_per_session_t> clientsPerSession)
        {
//            TimeSpan timeToPlay = new TimeSpan();
            List<clients_per_session_t> clientsPerSession =
                DataBaseClass.Instancedb().GetListOfClientsPerExactSession(sessionToUpdate.SessionId);
            double sumToPlay =
                clientsPerSession.Select(t1 => DataBaseClass.Instancedb().GetClientSavingsById(t1.client_id))
                    .Select(moneyOnCard => moneyOnCard.savings)
                    .Sum();
            TimeSpan t = AddNewSessionModel.InstanceAddNewSessionModel()
                .GetTimeToPlay(sumToPlay, sessionToUpdate.PlaystationId, sessionToUpdate.StartGame);
//            MessageBox.Show("new sum to play = " + sumToPlay + "\nnew time to play = " + t);
            DataBaseClass.Instancedb().ExtendGameTimeWithClientWithDiscountCard(sessionToUpdate, t, sumToPlay);
        }
    }
}
