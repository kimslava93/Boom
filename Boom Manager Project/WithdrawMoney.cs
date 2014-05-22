using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;

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
            tbTime.Text = DateTime.Now.ToString("dd-MMM-yyyy HH:mm");
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
            }
            Close();
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
