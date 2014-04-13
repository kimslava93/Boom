using System;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    public partial class ChangeShift : Form
    {
        private readonly ChangeShiftController _changeShiftController;

        public ChangeShift()
        {
            InitializeComponent();
            _changeShiftController = new ChangeShiftController();
        }

        private void ChangeShift_Load(object sender, EventArgs e)
        {
            lWarning.Text = _changeShiftController.WarningMessage("WarningLabel");
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (_changeShiftController.ToCloseForm())
            {
                Close();
            }
            else
            {
                MessageBox.Show(_changeShiftController.WarningMessage("FirstShift"));
            }
        }


        private void bAcceptShift_Click(object sender, EventArgs e)
        {
            if (FieldsAreFulFilled())
            {
                _changeShiftController.ShouldNewShiftBeCreated(tbInAdminLogin.Text, tbInAdminPassword.Text);
            }
        }
        private void bAddNewUser_Click(object sender, EventArgs e)
        {
            var ep = new EnterPassword("MANAGER");
            ep.ShowDialog();
            if (ep.Passed)
            {
                var ansu = new AddNewStaffUser();
                ansu.ShowDialog();
            }
        }
//        private void CreateNewShift()
//        {
//            var db = DataBaseClass.Instancedb();
//
//            var adminInfo = _addNewUserController.GetPersonInfoByLogin(tbInAdminLogin.Text);
//
//            var lastOpenedSession = db.GetOpenedSession();
//            if (lastOpenedSession != null)
//            {
//                MessageBox.Show(_addNewUserController.SessionIsOpened(lastOpenedSession.daily_id),
//                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            else
//            {
//                if (adminInfo != null)
//                {
//                    _addNewUserController.AddNewGlobalSession(adminInfo.person_id, "no operator", DateTime.Now);
//                }
//            }
//        }


        private bool FieldsAreFulFilled()
        {
            bool result = true;
            if (String.IsNullOrEmpty(tbOutAdminName.Text))
            {
                tbOutAdminName.Text = "Empty";
            }
            if (String.IsNullOrEmpty(tbOutOperatorName.Text))
            {
                tbOutOperatorName.Text = "Empty";
            }
            if (String.IsNullOrEmpty(tbInAdminLogin.Text))
            {
                HighLightTb(tbInAdminLogin);
                result = false;
            }
            if (String.IsNullOrEmpty(tbInAdminPassword.Text))
            {
                HighLightTb(tbInAdminPassword);
                result = false;
            }
            return result;
        }

//        private void CheckPasswords(string login)
//        {
//            personal_info_t adminLogin = (from al in _db.GetTable<personal_info_t>()
//                where al.staff_login == login
//                select al).SingleOrDefault();
//            if (adminLogin != null)
//            {
//                if (adminLogin.staff_password == tbInAdminPassword.Text)
//                {
//                    _shiftAccepted = true;
//                }
//                else
//                {
//                    HighLightTb(tbInAdminLogin);
//                    HighLightTb(tbInAdminPassword);
//                    _shiftAccepted = false;
//                }
//            }
//        }

        private void HighLightTb(TextBox tb)
        {
            tb.BackColor = Color.Red;
            tb.ForeColor = Color.White;
        }

        private void ChangeShift_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_changeShiftController.ToCloseForm())
            {
                Close();
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show(_changeShiftController.WarningMessage("FirstShift"));
            }
        }

        private void tbInAdminLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbInAdminLogin.Text == "Login")
            {
                tbInAdminLogin.Text = "";
            }
        }

        private void tbInAdminPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbInAdminPassword.Text == "Password")
            {
                tbInAdminPassword.Text = "";
            }
        }
    }
}