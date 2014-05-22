﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    public partial class CloseSessionForm : Form
    {
        private Point? _old;
        private readonly DaySessionClass _sessionToClose;
        private int _dailyId;
        private List<clients_per_session_t> _clientsPerSession; 
        public CloseSessionForm(DaySessionClass sessionToClose)
        {
            _sessionToClose = sessionToClose;
            InitializeComponent();
        }

        private void CloseSessionForm_Load(object sender, EventArgs e)
        {
            lQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lQuestion.Text = "Why do you want to close session\nbefore time expires?";
            _dailyId = DataBaseClass.Instancedb().GetLastOpenedGlobalSessionDailyId();
            _clientsPerSession = DataBaseClass.Instancedb().GetListOfClientsPerExactSession(_sessionToClose.SessionId);
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bClientHasGone_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            CloseSessionController.InstanceCloseSessionController()
                .CloseClientBeforeTimeOut(_sessionToClose, _clientsPerSession, currentTime, "Сlient gone, before time up");
            Close();
//            BoomGamebarController.InstanceBgController().CloseSessionBeforeTimer(sessionToClose, DateTime.Now);
        }

        private void bProblems_Click(object sender, EventArgs e)
        {
            Height = CloseSessionController.InstanceCloseSessionController().ExpandForProblemReportOrMinimize(Height);
            bClientHasGone.Enabled = Height <= 250;

        }

        private void bSubmitAndClose_Click(object sender, EventArgs e)
        {
            if (rtbComments.Text.Length > 5)
            {
                DateTime currentTime = DateTime.Now;
                CloseSessionController.InstanceCloseSessionController()
                    .CloseClientBeforeTimeOut(_sessionToClose, _clientsPerSession, currentTime, rtbComments.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Input full and understandable reason,\nwhy you want to switch off console before time expires! ", "Warning!");
            }
        }

        private void CloseSessionForm_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void CloseSessionForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void CloseSessionForm_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }
    }
}