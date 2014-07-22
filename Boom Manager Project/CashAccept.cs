using System;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class CashAccept : Form
    {
        public CashAccept()
        {
            InitializeComponent();
        }

        private void CashAccept_Load(object sender, EventArgs e)
        {
            lWarning.Text = @"Введите кол-во денег в кассе\nна момент принятия смены!";
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (AreYouSure())
            {
                int prevDailyId = DataBaseClass.Instancedb().GetLastOpenedGlobalSessionDailyId() - 1;
                int dailyId = DataBaseClass.Instancedb().GetLastOpenedGlobalSessionDailyId();
                if (numUpDCash.Value >= 0)
                {
                    if (!IsDailyIdValid(prevDailyId))
                    {
                        TextFileWriter.TextFileWriterInstance()
                            .AddSomeDataToLogReport("Не был найден последний открытый " + prevDailyId,
                                Options.FileTypeErrorsLogs);
                    }
                    else
                    {
                        DataBaseClass.Instancedb()
                            .AssignNewValueToCash((double) numUpDCash.Value, prevDailyId);
                        TextFileWriter.TextFileWriterInstance()
                            .AddSomeDataToLogReport("К смене " + (prevDailyId) + " было присвоено " + numUpDCash.Value,
                                Options.FileTypeActionsLogs);
                    }
                    if (!IsDailyIdValid(dailyId))
                    {
                        TextFileWriter.TextFileWriterInstance()
                            .AddSomeDataToLogReport("Не был найден последний открытый " + dailyId,
                                Options.FileTypeErrorsLogs);
                    }
                    else
                    {
                        DataBaseClass.Instancedb()
                            .AssignNewValueToCash((double) numUpDCash.Value, dailyId);
                        TextFileWriter.TextFileWriterInstance()
                            .AddSomeDataToLogReport("К смене " + (dailyId) + " было присвоено " + numUpDCash.Value,
                                Options.FileTypeActionsLogs);
                    }
                }
                Close();
            }
        }

        private bool AreYouSure()
        {
            DialogResult res = MessageBox.Show(@"Вы уверены что в кассе находиться введенная вами сумма?(" + numUpDCash.Value + @"сом)",
                ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetCaption(0), MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk);
            if (res == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private bool IsDailyIdValid(int dailyId)
        {
            if (DataBaseClass.Instancedb().GetGlobalSessionByDailyId(dailyId) != null)
            {
                return true;
            }
            return false;
        }

        private void numUpDCash_ValueChanged(object sender, EventArgs e)
        {
            if (numUpDCash.Value < 0)
            {
                numUpDCash.Value = 0;
            }
        }
    }
}
