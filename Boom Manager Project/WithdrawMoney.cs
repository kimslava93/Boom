using System;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class WithdrawMoney : Form
    {
        private string _logginedManager;
        public WithdrawMoney(string logginedManager)
        {
            InitializeComponent();
            _logginedManager = logginedManager;
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
            //cbManager.DataSource = WithdrawMoneyController.WithdrawMoneyControllerInstance().GetAllManagersList();
            tbManager.Text = DataBaseClass.Instancedb().GetUserInfoByPersonId(_logginedManager).name;
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (CheckStringOnNull(tbTime.Text) && CheckStringOnNull(tbManager.Text) &&
                CheckNumberOnNull(numUpDCashAmount.Value))
            {
                WithdrawMoneyController.WithdrawMoneyControllerInstance()
                    .InsertNewRecordWithdrawMoney((double)numUpDCashAmount.Value, tbManager.Text, DateTime.Parse(tbTime.Text));
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

        private void gbWithdrawMoney_Enter(object sender, EventArgs e)
        {

        }
    }
}
