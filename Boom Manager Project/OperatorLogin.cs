using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class OperatorLogin : Form
    {
        public OperatorLogin()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAcceptShift_Click(object sender, EventArgs e)
        {
            if (FieldsAreFulFilled())
            {
                if (OperatorLoginController.OperatorLoginControllerInstance()
                    .CheckPassword(tbInOperatorLogin.Text, tbInOperatorPassword.Text))
                {
                    OperatorLoginController.OperatorLoginControllerInstance().LoginOperator(tbInOperatorLogin.Text);
                    Close();
                }
                else
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(10));
                }
            }
        }
        private bool FieldsAreFulFilled()
        {
            bool result = !(String.IsNullOrEmpty(tbInOperatorLogin.Text) && String.IsNullOrEmpty(tbInOperatorPassword.Text));
            return result;
        }
       
    }
}
