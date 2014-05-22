﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.MyClasses;
using LINQ_test.Driver;

namespace Boom_Manager_Project
{
    public partial class BoomMainForm : Form
    {
        private bool EXIT = false;
        private DateTime _curDateTime;
        private List<DaySessionClass> _currentOpenedSessionsList;//for controlling update dgv

        public BoomMainForm()
        {
            InitializeComponent();
            UDPDriver.Instance.Init();
        }

        private void BoomMainForm_Load(object sender, EventArgs e)
        {
            _curDateTime = DateTime.Now;
            lCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lCurrentDate.Text = DateTime.Now.ToLongDateString();
            _currentOpenedSessionsList = BoomGamebarController.InstanceBgController().GetAllOpenedDaySessions();
            BoomGamebarController.InstanceBgController().OpenGlobalSession();
            TimeOutChecking();
        }

        private void BoomMainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void BoomMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!EXIT)
            {
                Application.Restart();
            }
        }

        private void BoomMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!EXIT)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
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
            if (splitContainer.Panel2Collapsed)
            {
                if (BoomGamebarController.InstanceBgController().AskManagerPassword())
                {
                    splitContainer.Panel2Collapsed = !splitContainer.Panel2Collapsed;
                }
                else
                {
                    MessageBox.Show("Access denied!");
                }
            }
            else
            {
                splitContainer.Panel2Collapsed = true;
            }
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
                BoomGamebarController.InstanceBgController()
                    .ExtendTime((int) dgvOpenedSessions.CurrentRow.Cells[0].Value, _currentOpenedSessionsList);
                _currentOpenedSessionsList = BoomGamebarController.InstanceBgController().GetAllOpenedDaySessions();
                dgvOpenedSessions.Invalidate();
            }
            else
            {
                BoomGamebarController.InstanceBgController().ShowErrorMessage(1); //Selec row to stop message 
            }
        }

        private void bChangeShift_Click(object sender, EventArgs e)
        {
            var cs = new ChangeShift(false);
            cs.ShowDialog();
        }

        private void bTimezoneManager_Click_1(object sender, EventArgs e)
        {
            BoomGamebarController.InstanceBgController().CallTimeZoneManager();
        }

        private void bConsoleManager_Click_1(object sender, EventArgs e)
        {
            BoomGamebarController.InstanceBgController().CallConsoleManager();
        }

        private void bAllGlobalSessions_Click_1(object sender, EventArgs e)
        {
            var sm = new ShiftsManager();
            sm.ShowDialog();
        }

        private void bDevicesManager_Click_1(object sender, EventArgs e)
        {
            var dm = new DeviceManager();
            dm.ShowDialog();
        }



        private void bExtendTime_MouseHover(object sender, EventArgs e)
        {
//            bExtendTime.BackgroundImage = Properties.Resources.buttonPressed1;
//            bExtendTime.FlatAppearance.BorderSize = 1;
            bExtendTime.FlatAppearance.BorderColor = Color.White;
        }

        private void bExtendTime_MouseLeave(object sender, EventArgs e)
        {
//            bExtendTime.BackgroundImage = Properties.Resources.button;
//            bExtendTime.FlatAppearance.BorderSize = 0;
            bExtendTime.FlatAppearance.BorderColor = Color.FromArgb(81, 91, 103);
        }

        private void bAddNewClient_MouseLeave(object sender, EventArgs e)
        {
//            bAddNewClient.BackgroundImage = Properties.Resources.button;
//            bAddNewClient.FlatAppearance.BorderSize = 0;
            bAddNewClient.FlatAppearance.BorderColor = Color.FromArgb(81, 91, 103);
//            bAddNewClient.FlatAppearance.BorderColor = Color.Transparent;
        }
        private void bAddNewClient_MouseHover(object sender, EventArgs e)
        {
            //            bAddNewClient.FlatAppearance.BorderSize = 1;
            bAddNewClient.FlatAppearance.BorderColor = Color.White;

            //            bAddNewClient.BackgroundImage = Properties.Resources.buttonPressed1;
        }
        private void bAddNewClient_MouseDown(object sender, MouseEventArgs e)
        {
//            if()
        }

        private void bChangeShift_MouseHover(object sender, EventArgs e)
        {
//            bChangeShift.FlatAppearance.BorderSize = 1;
            bChangeShift.FlatAppearance.BorderColor = Color.White;
        }

        private void bChangeShift_MouseLeave(object sender, EventArgs e)
        {
//            bChangeShift.FlatAppearance.BorderSize = 0;
            bChangeShift.FlatAppearance.BorderColor = Color.FromArgb(81, 91, 103);
        }

        private void bCloseSession_MouseHover(object sender, EventArgs e)
        {
            bCloseSession.FlatAppearance.BorderColor = Color.White;
        }

        private void bCloseSession_MouseLeave(object sender, EventArgs e)
        {
            bCloseSession.FlatAppearance.BorderColor = Color.FromArgb(81, 91, 103);
        }

        private void bExitProgram_Click(object sender, EventArgs e)
        {
            if(BoomGamebarController.InstanceBgController().AskManagerPassword())
            {
                EXIT = true;
                Close();
            }
        }

        private void bWithdrawMoney_Click(object sender, EventArgs e)
        {
            var wm = new WithdrawMoney();
            wm.ShowDialog();
        }

        private void bClientManager_Click(object sender, EventArgs e)
        {
            var cm = new ClientManager("create");
            cm.ShowDialog();
        }
    }
}