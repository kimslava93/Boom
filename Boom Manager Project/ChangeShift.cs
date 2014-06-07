using System;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class ChangeShift : Form
    {
        private readonly bool _launchOnStart;
        private bool _formCanBeClosed;
        private Point? _old;
        public ChangeShift(bool onStart)
        {
            InitializeComponent();
            _launchOnStart = onStart;
        }

        private void ChangeShift_Load(object sender, EventArgs e)
        {
            if (_launchOnStart)
            {
                CheckLastOpenedShift();
            }
            lWarning.Text = ChangeShiftController.ChangeShiftControllerInstance().WarningMessage("WarningLabel");
            FullFillData();
        }

        private void CheckLastOpenedShift()
        {
            bool r = ChangeShiftController.ChangeShiftControllerInstance().DoesTheLastGlobalSesionIsOpened();
            if(r)
            {
                _formCanBeClosed = true;
                Close();
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (ChangeShiftController.ChangeShiftControllerInstance().ToCloseForm())
            {
                _formCanBeClosed = true;
                Close();
            }
            else
            {
                MessageBox.Show(ChangeShiftController.ChangeShiftControllerInstance().WarningMessage("FirstShift"));
            }
        }


        private void bAcceptShift_Click(object sender, EventArgs e)
        {
            if (FieldsAreFulFilled())
            {
                ChangeShiftController.ChangeShiftControllerInstance().PasswordChecking(tbInAdminLogin.Text, tbInAdminPassword.Text);
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetMessage(0));
                _formCanBeClosed = true;
                Close();
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

        private void FullFillData()
        {
            global_session_t session =
                ChangeShiftController.ChangeShiftControllerInstance().GetLastOpenedGlobalSession();
            if (session == null)
            {
                tbOutAdminName.Text = @"no person";
                tbOutOperatorName.Text = @"no person";
            }
            else
            {
                tbOutAdminName.Text = DataBaseClass.Instancedb().GetUserInfoByPersonID(session.administrator_id).name;
                tbOutOperatorName.Text = session.operator_id == null ? @"no operator" : DataBaseClass.Instancedb().GetUserInfoByPersonID(session.operator_id).name;
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
                tbOutAdminName.Text = @"Empty";
            }
            if (String.IsNullOrEmpty(tbOutOperatorName.Text))
            {
                tbOutOperatorName.Text = @"Empty";
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
            if (_formCanBeClosed)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show(ChangeShiftController.ChangeShiftControllerInstance().WarningMessage("FirstShift"));
            }
        }

        private void tbInAdminLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbInAdminLogin.Text == @"Login")
            {
                tbInAdminLogin.Text = "";
            }
        }

        private void tbInAdminPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbInAdminPassword.Text == @"Password")
            {
                tbInAdminPassword.Text = "";
            }
        }

        private void ChangeShift_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void ChangeShift_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void ChangeShift_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }
    }
}