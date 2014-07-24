using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    public partial class LightCutOff : Form
    {
        private readonly List<DaySessionClass> _allSessions;
        private readonly DateTime _startTime;
        private TimeSpan _maxtimetoworkhere = TimeSpan.FromMinutes(5);
        private DateTime _closeTime;
        public TimeSpan TimeClosingClients;
        public bool AllSessionAreClosedAndApplicationCanBeClosed { get; set; }
        public LightCutOff(List<DaySessionClass> allOpenedSessions)
        {
            InitializeComponent();
            _allSessions = allOpenedSessions;
            _startTime = DateTime.Now;
            _closeTime = DateTime.Now;
            TimeClosingClients = new TimeSpan();
        }

        private void LightCutOff_Load(object sender, EventArgs e)
        {
            LoadDgv();
            dgvSessionsToClose.Columns[0].HeaderText = @"Приставки";
            TextFileWriter.TextFileWriterInstance().AddSomeDataToLogReport("Форма ВЫкл Свет Была открыта", Options.FileTypeActionsLogs);
            Options.OptionsInstance().TakeScreenShot();
        }

        private void LoadDgv()
        {
            dgvSessionsToClose.DataSource =
                LightCutsOffController.LihtLightCutsOffController().GetAllOpenedConsoles();
            dgvSessionsToClose.Invalidate();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvSessionsToClose_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSessionsToClose.CurrentRow != null)
            {
                TextFileWriter.TextFileWriterInstance().AddSomeDataToLogReport("Форма ВЫкл Свет Была открыта", Options.FileTypeActionsLogs);
                Options.OptionsInstance().TakeScreenShot();
                var clickedSession = (from s in _allSessions
                    where s.Приставка == (string) dgvSessionsToClose.CurrentRow.Cells[0].Value
                    select s).SingleOrDefault();
                if (clickedSession != null)
                {
                    List<clients_per_session_t> clientsPerSession =
                        DataBaseClass.Instancedb().GetListOfClientsPerExactSession(clickedSession.Сессия);
                }
                TextFileWriter.TextFileWriterInstance().AddSomeDataToLogReport("Форма ВЫкл Свет Была открыта", Options.FileTypeActionsLogs);
                Options.OptionsInstance().TakeScreenShot();
            }
        }

        private void bCloseSession_Click(object sender, EventArgs e)
        {
            if (dgvSessionsToClose.CurrentRow != null)
            {
                var clickedSession = (from s in _allSessions
                                      where s.Приставка == (string)dgvSessionsToClose.CurrentRow.Cells[0].Value
                                      select s).SingleOrDefault();
                if (clickedSession != null)
                {
                    List<clients_per_session_t> clientsPerSession =
                        DataBaseClass.Instancedb().GetListOfClientsPerExactSession(clickedSession.Сессия);
                    CloseSessionController.InstanceCloseSessionController()
                        .CloseClientBecauseOfLightCutsOff(clickedSession, clientsPerSession, DateTime.Now,
                            "Выключение света");
                }
                TextFileWriter.TextFileWriterInstance().AddSomeDataToLogReport("Форма ВЫкл Свет Была открыта", Options.FileTypeActionsLogs);
                Options.OptionsInstance().TakeScreenShot();
            }
            LoadDgv();
            dgvSessionsToClose.Columns[0].HeaderText = @"Приставки";
            TextFileWriter.TextFileWriterInstance().AddSomeDataToLogReport("Форма ВЫкл Свет Была открыта", Options.FileTypeActionsLogs);
            Options.OptionsInstance().TakeScreenShot();
        }

        private void bSwitchOff_Click(object sender, EventArgs e)
        {
            if (IsPlaystationDgvEmpty())
            {
                AllSessionAreClosedAndApplicationCanBeClosed = true;
                _closeTime = DateTime.Now;
                TimeClosingClients = _closeTime.Subtract(_startTime);
                Close();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(49));
                AllSessionAreClosedAndApplicationCanBeClosed = false;
                _closeTime = DateTime.Now;
                TimeClosingClients = _closeTime.Subtract(_startTime);
            }
        }

        private bool IsPlaystationDgvEmpty()
        {
            if (dgvSessionsToClose.CurrentRow == null || dgvSessionsToClose.RowCount == 0)
            {
                return true;
            }
            return false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _maxtimetoworkhere = _maxtimetoworkhere.Subtract(TimeSpan.FromSeconds(1));
            if (_maxtimetoworkhere <= TimeSpan.FromSeconds(0))
            {
                Close();
            }
        }
    }
}
