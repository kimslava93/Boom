using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    public partial class BoomMainForm : Form
    {
        private DateTime _curDateTime;
        private readonly MainFormController _mainFormController;

        public BoomMainForm()
        {
            InitializeComponent();
            
            _curDateTime = DateTime.Now;
            _mainFormController = MainFormController.MfController();
        }

        private void BoomMainForm_Load(object sender, EventArgs e)
        {
            lCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lCurrentDate.Text = DateTime.Now.ToLongDateString();
            _mainFormController.OpeneGlobalSession();
            dgvOpenedSessions.DataSource = _mainFormController.DvgAllSessions;
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
//            Thread check = new Thread(TimeOutChecking);
//            check.IsBackground = true;
//            check.Priority = ThreadPriority.Normal;
//            check.Start();
        }

        private void bSlideMenu_Click(object sender, EventArgs e)
        {
            if(splitContainer.Panel2Collapsed)
                splitContainer.Panel2Collapsed = false;
            else
            {
                splitContainer.Panel2Collapsed = true;
            }
        }

        private void bAddNewClient_Click(object sender, EventArgs e)
        {
            FAddNewSession newSessionForm = new FAddNewSession();
            newSessionForm.ShowDialog();
        }
    }
}