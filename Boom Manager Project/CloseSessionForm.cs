using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    public partial class CloseSessionForm : Form
    {
        private Point? _old;
        private readonly DaySessionClass _sessionToClose;
        private List<clients_per_session_t> _clientsPerSession; 
        public CloseSessionForm(DaySessionClass sessionToClose)
        {
            _sessionToClose = sessionToClose;
            InitializeComponent();
        }

        public int DailyId { get; set; }

        private void CloseSessionForm_Load(object sender, EventArgs e)
        {
            lQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lQuestion.Text = ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(3);
            DailyId = DataBaseClass.Instancedb().GetLastOpenedGlobalSessionDailyId();
            _clientsPerSession = DataBaseClass.Instancedb().GetListOfClientsPerExactSession(_sessionToClose.Сессия);
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bClientHasGone_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            TextFileWriter.TextFileWriterInstance()
                .AddSomeDataToLogReport("В форме \"Закрыть\" была нажата кнопка \"Клиент ушел раньше времени\" ",
                    Options.FileTypeActionsLogs);
            CloseSessionController.InstanceCloseSessionController()
                .CloseClientBeforeTimeOut(_sessionToClose, _clientsPerSession, currentTime, "Клиент ушел до окончания времени. ");
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
            if (rtbComments.Text.Length > 5 || rbCheckConsole.Checked)
            {
                DateTime currentTime = DateTime.Now;
                if (rbCheckConsole.Checked)
                {
                    CloseSessionController.InstanceCloseSessionController()
                        .CloseClientBeforeTimeOut(_sessionToClose, _clientsPerSession, currentTime, @"Проверка");
                }
                else
                {
                    CloseSessionController.InstanceCloseSessionController()
                        .CloseClientBeforeTimeOut(_sessionToClose, _clientsPerSession, currentTime, rtbComments.Text);
                }

                Close();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(11),
                    ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(1));
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

        private void rbProblemHappened_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProblemHappened.Checked)
            {
                rbCheckConsole.Checked = false;
                rtbComments.Enabled = true;
                rtbComments.ReadOnly = false;
            }
        }

        private void rbCheckConsole_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCheckConsole.Checked)
            {
                rbProblemHappened.Checked = false;

                rtbComments.Enabled = false;
                rtbComments.ReadOnly = true;
            }
        }
    }
}
