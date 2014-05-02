using System;
using System.Threading;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    public partial class BoomMainForm : Form
    {
        private DateTime _curDateTime;
        private readonly BoomGamebarController _boomGamebarController;

        public BoomMainForm()
        {
            InitializeComponent();
            
            _curDateTime = DateTime.Now;
            _boomGamebarController = BoomGamebarController.MfController();
            dgvOpenedSessions.DataSource = _boomGamebarController.GetAllOpenedDaySessions();
        }
        private void BoomMainForm_Load(object sender, EventArgs e)
        {
            lCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lCurrentDate.Text = DateTime.Now.ToLongDateString();
            _boomGamebarController.OpeneGlobalSession();
            dgvOpenedSessions.DataSource = _boomGamebarController.DvgAllSessions;
        }

        private void BoomMainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void BoomMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }

        private void BoomMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _curDateTime = DateTime.Now;
            lCurrentTime.Text = _curDateTime.ToString("HH:mm:ss");

            if (_curDateTime.Minute % 60 == 0)
            {
                lCurrentDate.Text = _curDateTime.ToLongDateString();
            }
            
//            CheckSoonToCloseClients();
            var check = new Thread(TimeOutChecking) {IsBackground = true, Priority = ThreadPriority.Normal};
            check.Start();
        }
     
        private void TimeOutChecking()
        {
            BoomGamebarController.MfController().TimeOutChecking();
            dgvOpenedSessions.Invalidate();
        }
        private void bSlideMenu_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2Collapsed = !splitContainer.Panel2Collapsed;
        }

        private void bAddNewClient_Click(object sender, EventArgs e)
        {
            var newSessionForm = new FAddNewSession();
            newSessionForm.ShowDialog();
            dgvOpenedSessions.DataSource = _boomGamebarController.GetAllOpenedDaySessions();
        }
    }
}