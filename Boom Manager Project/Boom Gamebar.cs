using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    public partial class BoomMainForm : Form
    {
        private DateTime _curDateTime;
        private List<DaySessionClass> _currentOpenedSessionsList;//for controlling update dgv
        public BoomMainForm()
        {
            InitializeComponent();
            _currentOpenedSessionsList = BoomGamebarController.InstanceBgController().GetAllOpenedDaySessions();
        }

        private void BoomMainForm_Load(object sender, EventArgs e)
        {
            _curDateTime = DateTime.Now;
            lCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lCurrentDate.Text = DateTime.Now.ToLongDateString();
            BoomGamebarController.InstanceBgController().OpeneGlobalSession();
            TimeOutChecking();
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
//            var closeSessionCheck = new Thread(CheckSoonToCloseClients) { IsBackground = true, Priority = ThreadPriority.Normal };
            var timeOutCheck = new Thread(TimeOutChecking) {IsBackground = true, Priority = ThreadPriority.Normal};
//            closeSessionCheck.Start();
            CheckSoonToCloseClients();
            timeOutCheck.Start();
            dgvOpenedSessions.DataSource = _currentOpenedSessionsList;
            dgvOpenedSessions.Invalidate();
        }

        private void CheckSoonToCloseClients()
        {
            _currentOpenedSessionsList = BoomGamebarController.InstanceBgController().CheckSoonToCloseClients(_currentOpenedSessionsList);
        }

        private void TimeOutChecking()
        {
            _currentOpenedSessionsList = BoomGamebarController.InstanceBgController().TimeAndMoneySubstracting(_currentOpenedSessionsList);
        }
        private void bSlideMenu_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2Collapsed = !splitContainer.Panel2Collapsed;
        }

        private void bAddNewSession_Click(object sender, EventArgs e)
        {
            var newSessionForm = new FAddNewSession();
            newSessionForm.ShowDialog();
            _currentOpenedSessionsList = BoomGamebarController.InstanceBgController().GetAllOpenedDaySessions();
            dgvOpenedSessions.DataSource = _currentOpenedSessionsList;
            dgvOpenedSessions.Invalidate();
        }
        private void dgvOpenedSessions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridViewColumn = dgvOpenedSessions.Columns["StartGame"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.DefaultCellStyle.Format = "t";
            var gridViewColumn = dgvOpenedSessions.Columns["EndGame"];
            if (gridViewColumn != null)
                gridViewColumn.DefaultCellStyle.Format = "t";
        }

        private void bCloseSession_Click(object sender, EventArgs e)
        {
            if (dgvOpenedSessions.CurrentRow != null)
            {
                var sessionToClose = BoomGamebarController.InstanceBgController()
                    .GetSelectedSessionData(_currentOpenedSessionsList,
                        (int) dgvOpenedSessions.CurrentRow.Cells[0].Value);
                if (sessionToClose != null)
                {
                    _currentOpenedSessionsList =
                        BoomGamebarController.InstanceBgController().CloseSessionBeforeTimer(sessionToClose);
                    dgvOpenedSessions.Invalidate();
                }
            }
            else
            {
                BoomGamebarController.InstanceBgController().ShowErrorMessage(1);//Selec row to delete message 
//                MessageBox.Show();
            }
//            GetDailySession();
        }

        private void bExtendTime_Click(object sender, EventArgs e)
        {
            if (dgvOpenedSessions.CurrentRow != null)
            {
                BoomGamebarController.InstanceBgController().ExtendTime((int)dgvOpenedSessions.CurrentRow.Cells[0].Value,_currentOpenedSessionsList);
                _currentOpenedSessionsList = BoomGamebarController.InstanceBgController().GetAllOpenedDaySessions();
                dgvOpenedSessions.Invalidate();
            }
            else
            {
                BoomGamebarController.InstanceBgController().ShowErrorMessage(1);//Selec row to stop message 
            }
        }

        private void bTimezoneManager_Click(object sender, EventArgs e)
        {
            BoomGamebarController.InstanceBgController().CallTimeZoneManager();
        }
    }
}