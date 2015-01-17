using System;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    public partial class ChangePlaystation : Form
    {
        private DaySessionClass _ds;
        public ChangePlaystation(DaySessionClass sessionToReplace, double playedMoney)
        {
            InitializeComponent();
            _ds = sessionToReplace;
            _ds.Счетчик = playedMoney;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            TextFileWriter.TextFileWriterInstance()
               .AddSomeDataToLogReport("В форме смена приставки, была нажата кнопка отмена " + cbPlaystationId.Text,
                   Options.FileTypeActionsLogs);
            Close();
        }

        private void ChangePlaystation_Load(object sender, EventArgs e)
        {
            tbOldPLaystationId.Text = _ds.Приставка;
            UpdatePlaystationList();
            Options.OptionsInstance().TakeScreenShot();
        }
        private void UpdatePlaystationList()
        {
            cbPlaystationId.ValueMember = "playstation_id";
            cbPlaystationId.DataSource = AddNewSessionController.AddNewSessionControllerInstance().GetAllFreeTablesId();

            if (cbPlaystationId.Items.Count > 0)
            {
                cbPlaystationId.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(AddNewSessionController.AddNewSessionControllerInstance().WarningMessages("NoFreePlaces"));
                Close();
            }
        }

        private bool TableNameIsOk()
        {
            if (string.IsNullOrEmpty(cbPlaystationId.Text) || !TableIsAvailable())
            {
                UpdatePlaystationList();
                return false;
            }
            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(25));
            return true;
        }

        private bool TableIsAvailable()
        {
            return AddNewSessionController.AddNewSessionControllerInstance().CheckDoesConsoleExist(cbPlaystationId.Text);
        }
        private void bAddSession_Click(object sender, EventArgs e)
        {
            TextFileWriter.TextFileWriterInstance()
               .AddSomeDataToLogReport("В форме смена приставки, была нажата кнопка добавить " + cbPlaystationId.Text,
                   Options.FileTypeActionsLogs);
            Options.OptionsInstance().TakeScreenShot();
            
            if ((rtbComments.Text.Length > 5 && TableIsAvailable() && rbCustom.Checked) || (TableIsAvailable() && (rbClientWish.Checked || rbChecking.Checked)))
            {
                if(rbClientWish.Checked)
                    ChangePlaystationController.ChangePlaystationControllerInstance().ReplaceClient(_ds, cbPlaystationId.Text, "Желание клиента");
                else if(rbChecking.Checked)
                    ChangePlaystationController.ChangePlaystationControllerInstance().ReplaceClient(_ds, cbPlaystationId.Text, "Проверка");
                else
                    ChangePlaystationController.ChangePlaystationControllerInstance().ReplaceClient(_ds, cbPlaystationId.Text, rtbComments.Text);
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(40),
                    ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(1));
            }
            Close();
        }

        private void cbPlaystationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextFileWriter.TextFileWriterInstance()
                .AddSomeDataToLogReport("В форме смена приставки, была выбрана приставка " + cbPlaystationId.Text,
                    Options.FileTypeActionsLogs);
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustom.Checked)
            {
                rbChecking.Checked = false;
                rbClientWish.Checked = false;
                rtbComments.Enabled = true;
                rtbComments.ReadOnly = false;
            }
        }

        private void rbProblem_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChecking.Checked)
            {
                rbCustom.Checked = false;
                rbClientWish.Checked = false;
                rtbComments.Enabled = false;
                rtbComments.ReadOnly = true;
            }
        }

        private void rbClientWish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClientWish.Checked)
            {
                rbCustom.Checked = false;
                rbChecking.Checked = false;
                rtbComments.Enabled = false;
                rtbComments.ReadOnly = true;
            }
        }

    
    
    
    
    
    }
}
