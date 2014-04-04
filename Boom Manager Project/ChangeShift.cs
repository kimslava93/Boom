using System;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    public partial class ChangeShift : Form
    {
        private readonly dbDataContext _db;
        private readonly Controller _controller;

        public ChangeShift()
        {
            InitializeComponent();
            _db = new dbDataContext();
            _controller = new Controller();
        }

        private bool _shiftAccepted = false;
        
        private void ChangeShift_Load(object sender, EventArgs e)
        {
            lWarning.Text =
                "Please input login and password to accept shift.\n" +
                "By loging in you accept shift as it is, \nand take all responsibility for equipment itself";
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
           ToCloseForm();
        }


        private void bAcceptShift_Click(object sender, EventArgs e)
        {
            if (FieldsAreFulFilled())
            {
                CheckPasswords();
                if (_shiftAccepted)
                {
                    //create new Shift
                    CreateNewShift();
                    _shiftAccepted = true;
                }
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
        private void CreateNewShift()
        {
            var db = DataBaseClass.Instancedb();

            var adminInfo = _controller.GetPersonInfoByLogin(tbInAdminLogin.Text);

            var lastOpenedSession = db.GetOpenedSession();
            if (lastOpenedSession != null)
            {
                MessageBox.Show(_controller.SessionIsOpened(lastOpenedSession.daily_id),
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (adminInfo != null)
                {
                    _controller.AddNewGlobalSession(adminInfo.person_id, "no operator", DateTime.Now);
                }
            }
        }


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
                tbInAdminLogin.BackColor = Color.Red;
                tbInAdminLogin.ForeColor = Color.White;
                result = false;
            }
            if (String.IsNullOrEmpty(tbInAdminPassword.Text))
            {
                tbInAdminPassword.BackColor = Color.Red;
                tbInAdminPassword.ForeColor = Color.White;
                result = false;
            }
            return result;
        }

        private void CheckPasswords()
        {
            personal_info_t adminLogin = (from al in _db.GetTable<personal_info_t>()
                where al.staff_login == tbInAdminLogin.Text
                select al).SingleOrDefault();
            if (adminLogin != null)
            {
                if (adminLogin.staff_password == tbInAdminPassword.Text)
                {
                    _shiftAccepted = true;
                }
                else
                {
                    HighLightTb(tbInAdminLogin);
                    HighLightTb(tbInAdminPassword);
                    _shiftAccepted = false;
                }
            }
        }

        private void HighLightTb(TextBox tb)
        {
            tb.BackColor = Color.Red;
            tb.ForeColor = Color.White;
        }

        private void ChangeShift_FormClosing(object sender, FormClosingEventArgs e)
        {
            var db = DataBaseClass.Instancedb();
            if (db.GetOpenedSession() != null)
            {
                Close();
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Your shift is the first and there is no opened one.\nYou should login to continue!");
            }
        }

        private void ToCloseForm()
        {
            var db = DataBaseClass.Instancedb();
            if (db.GetOpenedSession() != null)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Your shift is the first and there is no opened one.\nYou should login to continue!");
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