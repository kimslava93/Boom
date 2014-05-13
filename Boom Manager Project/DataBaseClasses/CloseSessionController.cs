using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
                if (clientOnSession.Count == 1 && clientOnSession[0].client_id.Equals("0"))
                {
                    CloseUsualClient(sessionToClose, comments, closeTime);
                }
                else//with discount card
                {
                    CloseClientWithDiscount(sessionToClose, comments, closeTime);
                }
            }
            else
            {
                MessageBox.Show("Error! Session cannot be closed because of client absence in the session#" +
                                sessionToClose.SessionId);
            }
        }

        private void CloseUsualClient(DaySessionClass sessionToClose, string comments, DateTime endTime)
        {
            DataBaseClass.Instancedb().CloseSessionWithUsualClient(sessionToClose, comments, endTime);
        }
        private void CloseClientWithDiscount(DaySessionClass sessionToClose, string comments, DateTime endTime)
        {
            DataBaseClass.Instancedb().CloseSessionWithCard(sessionToClose, comments, endTime);
        }

        public int ExpandForProblemReportOrMinimize(int height)
        {
            height = height <= 250 ? 450 : 250;
            return height;
        }
    }
}
