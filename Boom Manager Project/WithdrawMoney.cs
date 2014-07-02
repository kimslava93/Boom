using System;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class WithdrawMoney : Form
    {
        public WithdrawMoney()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WithdrawMoney_Load(object sender, EventArgs e)
        {
            LoadManagersList();
            tbTime.Text = DateTime.Now.ToString("dd-MMM-yy HH:mm");
        }

        private void LoadManagersList()
        {
            cbManager.DataSource = WithdrawMoneyController.WithdrawMoneyControllerInstance().GetAllManagersList();
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (CheckStringOnNull(tbTime.Text) && CheckStringOnNull(cbManager.Text) &&
                CheckNumberOnNull(numUpDCashAmount.Value))
            {
                WithdrawMoneyController.WithdrawMoneyControllerInstance()
                    .InsertNewRecordWithdrawMoney((double)numUpDCashAmount.Value, cbManager.Text, DateTime.Parse(tbTime.Text));
                Close();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(9));

            }
            
        }

        private bool CheckStringOnNull(string wordToTest)
        {
            if (!string.IsNullOrWhiteSpace(wordToTest))
            {
                return true;
            }
            return false;
        }
        private bool CheckNumberOnNull(decimal numToTest)
        {
            if (numToTest > 0)
            {
                return true;
            }
            return false;
        }
    }
}
