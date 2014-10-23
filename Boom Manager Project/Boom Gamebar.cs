using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.HardwareConnectionDriver;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    public partial class BoomMainForm : Form
    {
        private bool _exit;
        private DateTime _curDateTime;
        private List<DaySessionClass> _currentOpenedSessionsList;//for controlling update dgv
        private CheckConnectionWithDevices _checkConnectionWithDevices;
        public BoomMainForm()
        {
            InitializeComponent();
//            CenterTime();
            UDPDriver.Instance.Init();
        }

        private void BoomMainForm_Load(object sender, EventArgs e)
        {
            _checkConnectionWithDevices = new CheckConnectionWithDevices();
            _curDateTime = DateTime.Now;
            lCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lCurrentDate.Text = DateTime.Now.ToLongDateString();
            _currentOpenedSessionsList = BoomGamebarController.InstanceBgController().GetAllOpenedDaySessions();
            BoomGamebarController.InstanceBgController().OpenGlobalSession();
            TimeOutChecking();
            UpdateWorkingStaff();
        }
//        private void CenterTime()
//        {
////            lCurrentTime.Location.X = 500;
//            dgvOpenedSessions.Height = Height - 100;
//            dgvOpenedSessions.Invalidate();
//        }
        private void BoomMainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void BoomMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_exit)
            {
                Application.Restart();
            }
        }

        private void BoomMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !_exit;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _checkConnectionWithDevices.Check();
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
            CheckWhichSessionToPaint();
        }

        private void TimeOutChecking()
        {
            _currentOpenedSessionsList = BoomGamebarController.InstanceBgController().TimeAndMoneySubstracting(_currentOpenedSessionsList);
        }
        private void bSlideMenu_Click(object sender, EventArgs e)
        {
            TextFileWriter.TextFileWriterInstance()
                .AddSomeDataToLogReport("кнопка \"Скрытая кнопка\" была нажата.", Options.FileTypeActionsLogs);
            if (splitContainer.Panel2Collapsed)
            {
                if (BoomGamebarController.InstanceBgController().AskManagerPassword())
                {
                    splitContainer.Panel2Collapsed = !splitContainer.Panel2Collapsed;
                }
                else
                {
                    TextFileWriter.TextFileWriterInstance()
                        .AddSomeDataToLogReport("сообщение \"Доступ запрещен\" было показано.", Options.FileTypeActionsLogs);
                    MessageBox.Show(@"Доступ запрещен!");
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
            TextFileWriter.TextFileWriterInstance()
                .AddSomeDataToLogReport("кнопка \"Добавить сессию\" была нажата.", Options.FileTypeActionsLogs);
            newSessionForm.ShowDialog();
            _currentOpenedSessionsList = BoomGamebarController.InstanceBgController().GetAllOpenedDaySessions();
            dgvOpenedSessions.DataSource = _currentOpenedSessionsList;
            dgvOpenedSessions.Invalidate();
        }
        private void dgvOpenedSessions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridViewColumn = dgvOpenedSessions.Columns["Начало"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.DefaultCellStyle.Format = "t";
            var gridViewColumn = dgvOpenedSessions.Columns["Конец"];
            if (gridViewColumn != null)
                gridViewColumn.DefaultCellStyle.Format = "t";
        }

        private void bCloseSession_Click(object sender, EventArgs e)
        {
            if (dgvOpenedSessions.CurrentRow != null)
            {
                TextFileWriter.TextFileWriterInstance()
                    .AddSomeDataToLogReport("кнопка \"Закрыть сессию\" была нажата.", Options.FileTypeActionsLogs);
                var sessionToClose = BoomGamebarController.InstanceBgController()
                    .GetSelectedSessionData(_currentOpenedSessionsList,
                        (int) dgvOpenedSessions.CurrentRow.Cells[0].Value);
                if (sessionToClose != null)
                {
                    Options.OptionsInstance().TakeScreenShot();
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
                TextFileWriter.TextFileWriterInstance()
                    .AddSomeDataToLogReport("Кнопка \"Продлить сессию\" была нажата.", Options.FileTypeActionsLogs);
                Options.OptionsInstance().TakeScreenShot();
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
            TextFileWriter.TextFileWriterInstance()
                .AddSomeDataToLogReport("кнопка \"Смена\" была нажата.", Options.FileTypeActionsLogs);
            Options.OptionsInstance().TakeScreenShot();
            cs.ShowDialog();
            UpdateWorkingStaff();
        }

        private void UpdateWorkingStaff()
        {
            lAdmin.Text = @"Администратор: " +  BoomGamebarController.InstanceBgController().GetCurrentAdminName();
            lOperator.Text = @"Оператор: " + BoomGamebarController.InstanceBgController().GetCurrentOperatorName();
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
                _exit = true;
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

        private void bDiscountSteps_Click(object sender, EventArgs e)
        {
            var ds = new DiscountStepsManager();
            ds.ShowDialog();
        }

        private void bExpenses_Click(object sender, EventArgs e)
        {
            var ex = new Expences();
            TextFileWriter.TextFileWriterInstance()
                .AddSomeDataToLogReport("кнопка \"Затраты\" была нажата.", Options.FileTypeActionsLogs);
            Options.OptionsInstance().TakeScreenShot();
            ex.ShowDialog();
        }

        private void lOperator_Click(object sender, EventArgs e)
        {
            var ol = new OperatorLogin();
            TextFileWriter.TextFileWriterInstance().AddSomeDataToLogReport("Кнопка \"Логин оператора\" нажато\n",Options.FileTypeActionsLogs);
            Options.OptionsInstance().TakeScreenShot();
            ol.ShowDialog();
            UpdateWorkingStaff();
        }

        private void bReplace_Click(object sender, EventArgs e)
        {
            if (dgvOpenedSessions.CurrentRow != null)
            {
                TextFileWriter.TextFileWriterInstance()
                    .AddSomeDataToLogReport("кнопка \"Смена приставки\" была нажата.", Options.FileTypeActionsLogs);
                Options.OptionsInstance().TakeScreenShot();
                DaySessionClass sessionToReplace = _currentOpenedSessionsList.FirstOrDefault(ds => ds.Сессия == (int) dgvOpenedSessions.CurrentRow.Cells[0].Value);
                if (sessionToReplace != null)
                {

                    var cp = new ChangePlaystation(sessionToReplace);
                    cp.ShowDialog();
                    _currentOpenedSessionsList = BoomGamebarController.InstanceBgController().GetAllOpenedDaySessions();
                    dgvOpenedSessions.Invalidate();
                }
            }
        }

        private void bItems_Click(object sender, EventArgs e)
        {
            var ai = new AllBarItems();
            ai.ShowDialog();
        }

        private void bLightCutOff_Click(object sender, EventArgs e)
        {
            TextFileWriter.TextFileWriterInstance()
                .AddSomeDataToLogReport("кнопка \"Выключить свет\" была нажата.", Options.FileTypeActionsLogs);
            Options.OptionsInstance().TakeScreenShot();
            var ep = new EnterPassword("ADMINISTRATOR");
            ep.ShowDialog();
            if (ep.Passed)
            {
                timer.Stop();
                var lco = new LightCutOff(_currentOpenedSessionsList);
                lco.ShowDialog();
                _currentOpenedSessionsList = BoomGamebarController.InstanceBgController().GetAllOpenedDaySessions();
                dgvOpenedSessions.Invalidate();
                timer.Start();
                if (lco.AllSessionAreClosedAndApplicationCanBeClosed)
                {
                    _exit = true;
                    Close();
                }
            }
        }

        private void bSellBarItem_Click(object sender, EventArgs e)
        {
            var si = new SellBarItem();
            TextFileWriter.TextFileWriterInstance()
                .AddSomeDataToLogReport("кнопка \"Продать товар\" была нажата.", Options.FileTypeActionsLogs);
            Options.OptionsInstance().TakeScreenShot();
            si.ShowDialog();
        }

        private void bBarRevision_Click(object sender, EventArgs e)
        {
            var r = new BarRevision();
            TextFileWriter.TextFileWriterInstance()
                .AddSomeDataToLogReport("кнопка \"Ревизия\" была нажата.", Options.FileTypeActionsLogs);
            Options.OptionsInstance().TakeScreenShot();
            r.ShowDialog();
        }

        private void bSolItemsList_Click(object sender, EventArgs e)
        {
            var si = new SoldItems();
            TextFileWriter.TextFileWriterInstance()
                .AddSomeDataToLogReport("кнопка \"Бар\" была нажата.", Options.FileTypeActionsLogs);
            Options.OptionsInstance().TakeScreenShot();
            si.ShowDialog();
        }

        private void bCEditlients_Click(object sender, EventArgs e)
        {
            var ac = new AllClients();
            ac.ShowDialog();
        }

        private void bScreenshot_MouseHover(object sender, EventArgs e)
        {
            bScreenshot.Visible = true;
        }

        private void lCurrentTime_MouseHover(object sender, EventArgs e)
        {
            bScreenshot.Visible = true;
        }

        private void lCurrentTime_MouseLeave(object sender, EventArgs e)
        {
//            bScreenshot.Visible = false;
        }

        private void bScreenshot_Click(object sender, EventArgs e)
        {
            TextFileWriter.TextFileWriterInstance()
                .AddSomeDataToLogReport("кнопка \"Скриншот\" была нажата.", Options.FileTypeActionsLogs);
            Options.OptionsInstance().TakeScreenShot();
        }

        private void bScreenshot_MouseLeave(object sender, EventArgs e)
        {
            bScreenshot.Visible = false;
        }

        private void bStaff_Click(object sender, EventArgs e)
        {
            var ansu = new AddNewStaffUser();
            ansu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ls = new LastSessions();
            TextFileWriter.TextFileWriterInstance()
                .AddSomeDataToLogReport("Кнопка последние 10 сессий была нажата!", Options.FileTypeActionsLogs);
            Options.OptionsInstance().TakeScreenShot();
            ls.ShowDialog();
        }

        private void CheckWhichSessionToPaint()
        {
            foreach (DataGridViewRow r in dgvOpenedSessions.Rows)
            {
                if(TimeSpan.Parse(r.Cells[4].Value.ToString()) < TimeSpan.FromMinutes(10))
                {
                    PaintSoonToCloseSession(r.Index);
                }
            }
        }

        private void PaintSoonToCloseSession(int row)
        {
            if (dgvOpenedSessions.Rows[row].DefaultCellStyle.BackColor != Color.Red)
            {
                dgvOpenedSessions.Rows[row].DefaultCellStyle.BackColor = Color.Red;
                dgvOpenedSessions.Rows[row].DefaultCellStyle.ForeColor = Color.Black;
                dgvOpenedSessions.Rows[row].DefaultCellStyle.SelectionBackColor = Color.Tomato;
                dgvOpenedSessions.Rows[row].DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }
        private void PaintSessionToDefaultColor(int row)
        {
            if (dgvOpenedSessions.Rows[row].DefaultCellStyle.BackColor != Color.FromArgb(40, 40, 40))
            {
                dgvOpenedSessions.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
                dgvOpenedSessions.Rows[row].DefaultCellStyle.ForeColor = Color.White;
                dgvOpenedSessions.Rows[row].DefaultCellStyle.SelectionBackColor = Color.White;
                dgvOpenedSessions.Rows[row].DefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 40);
            }
        }

        private void bTimeTester_Click(object sender, EventArgs e)
        {
            var t = new TimeTester();
            t.ShowDialog();
        }

        private void bAllExpenses_Click(object sender, EventArgs e)
        {
            var ae = new AllExpences();
            ae.ShowDialog();
        }

        private void bPromoRedactor_Click(object sender, EventArgs e)
        {
            var promo = new DiscountsRedactor();
            promo.ShowDialog();
        }
    }
}