using System;
using System.Data.Linq.Mapping;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.DataBaseClasses
{
    public partial class ChangePlaystation : Form
    {
        private DaySessionClass _ds;
        public ChangePlaystation(DaySessionClass sessionToReplace)
        {
            InitializeComponent();
            _ds = sessionToReplace;
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
            if (rtbComments.Text.Length > 5 && TableIsAvailable())
            {
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

    
    
    
    
    
    }
}
