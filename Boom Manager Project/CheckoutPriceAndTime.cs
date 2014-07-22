using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    public partial class CheckoutPriceAndTime : Form
    {
        private days_sessions_t _sessionData;
        private readonly DaySessionClass _daySessionMyClass;
        private readonly int _sessionId;
        public CheckoutPriceAndTime(int sessionId)
        {
            InitializeComponent();
            _sessionId = sessionId;
            _daySessionMyClass = DataBaseClass.Instancedb()
                .GetDaySessionMyClassBySessionId(sessionId, DataBaseClass.Instancedb().GetListOfAllClientsPerSessionT());
        }

        private string GetClientsFromSession()
        {
            var clients = DataBaseClass.Instancedb().GetListOfClientsPerExactSession(_sessionData.session_id);
            string result = "";
            if (clients.Count > 0)
            {
                if (clients.Count == 1)
                {
                    result = DataBaseClass.Instancedb().GetClientInfoById(clients[0].client_id).name;
                }
                else
                {
                    result = clients.Aggregate(result, (current, c) => current + (DataBaseClass.Instancedb().GetClientInfoById(c.client_id).name + "; "));
                }
            }
            return result;
        }

        private void LoadData()
        {
            _sessionData = DataBaseClass.Instancedb().GetDaySessionBySessionId(_sessionId);
            tbSessionId.Text = _sessionData.session_id.ToString(CultureInfo.InvariantCulture);
            tbConsole.Text = _sessionData.playstation_id;
            tbStartTime.Text = _sessionData.start_game.ToString();
            tbEndTime.Text = _sessionData.end_game.ToString();
            tbClient.Text = GetClientsFromSession();
            tbDiscountAmount.Text = _sessionData.session_discount.ToString();
            tbPaidSum.Text = _sessionData.payed_sum.ToString(CultureInfo.InvariantCulture);
            tbPlayed.Text = _daySessionMyClass.Счетчик.ToString(CultureInfo.InvariantCulture);
        }

        private void CheckoutPriceAndTime_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

//        private double GetPriceForInsertedTime(TimeSpan paidTime, DateTime fromTime)
//        {
////            TimeSpan diferenceUntilNextTimeZone = 
//        }
    }
}
