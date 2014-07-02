using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class Expences : Form
    {
        public Expences()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Expences_Load(object sender, EventArgs e)
        {
            tbTime.Text = DateTime.Now.ToString("dd-MMM-yy HH:mm");
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (CheckStringOnNull(tbTime.Text) && CheckStringOnNull(rtbComments.Text) &&
                CheckNumberOnNull(numUpdCash.Value) && numUpdCash.Value > 0)
            {
                ExpensesController.ExpensesInstance()
                    .InsertNewRecordExpensesMoney((double) numUpdCash.Value, rtbComments.Text,
                        DateTime.Parse(tbTime.Text));
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
