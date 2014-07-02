using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class EnterPassword : Form
    {
        private Point? _old;
        private const string Manager = "MANAGER";
        private const string Admin = "ADMINISTRATOR";
//        private const string  = "shift";

        private readonly string _accessPosition;
        private readonly dbDataContext _db;

        public EnterPassword(string accessPosition)
        {
            InitializeComponent();
            _db = new dbDataContext();
            _accessPosition = accessPosition;
        }

        public bool Passed { get; set; }

        private void EnterPassword_Load(object sender, EventArgs e)
        {
            lWarning.Text = ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(5);
        }

        private void CheckValidityOfPassword()
        {
            if (!String.IsNullOrEmpty(tbLogin.Text))
            {
                personal_info_t matchedStaff = (from l in _db.GetTable<personal_info_t>()
                    where l.staff_login == tbLogin.Text
                    select l).SingleOrDefault();

                if (matchedStaff != null)
                {
                    if (matchedStaff.position == Manager)
                    {
                        if (_accessPosition == Manager && matchedStaff.staff_password == tbPassword.Text)
                        {
                            Passed = true;
                            Close();
                        }
                        else
                        {
                            MessageWrongInput();
                        }
                    }
                    else if (matchedStaff.position == Admin)
                    {
                        if (_accessPosition == Manager)
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(12));
                        }
                        else if (_accessPosition != Manager && matchedStaff.staff_password == tbPassword.Text)
                        {
                            Passed = true;
                            Close();
                        }
                        else
                        {
                            MessageWrongInput();
                        }
                    }
                }
                else
                {
                    MessageWrongInput();
                }
            }
            else
            {
                MessageWrongInput();
            }
        }

        private void MessageWrongInput()
        {
            Passed = false;
            tbPassword.BackColor = Color.Red;
            tbPassword.ForeColor = Color.White;
            tbLogin.BackColor = Color.Red;
            tbLogin.ForeColor = Color.White;
            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(10),
                ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(6), MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

//        private void checkPassword()
//        {
//             if (MANAGER)
//                {
//                    if (tbPassword.Text == "123")
//                    {
//                        Passed = true;
//                        Close();
//                    }
//                    else
//                    {
//                        Passed = false;
//                        tbPassword.BackColor = Color.Red;
//                        MessageBox.Show("Wrong password!");
//                    }
//                }
//                else if (!_manager)
//                {
//                    if (tbPassword.Text == "000")
//                    {
//                        Passed = true;
//                        Close();
//                    }
//                    else
//                    {
//                        Passed = false;
//                        tbPassword.BackColor = Color.Red;
//                    }
//                }
//        }


        private void bAccept_Click(object sender, EventArgs e)
        {
            CheckValidityOfPassword();
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
//            if (String.IsNullOrEmpty(tbLogin.Text))
//            {
//                tbLogin.Text = "Login";
//            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
//            if (String.IsNullOrWhiteSpace(tbPassword.Text))
//            {
//                tbPassword.Text = "Password";
//            }
        }

        private void tbLogin_MouseClick(object sender, MouseEventArgs e)
        {
            tbLogin.BackColor = Color.White;
            tbLogin.ForeColor = Color.Black;
            if (tbLogin.Text == @"Login")
            {
                tbLogin.Text = "";
            }
        }

        private void tbPassword_MouseClick(object sender, MouseEventArgs e)
        {
            tbPassword.BackColor = Color.White;
            tbPassword.ForeColor = Color.Black;
            if (tbPassword.Text == @"Password")
            {
                tbPassword.Text = "";
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnterPassword_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void EnterPassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void EnterPassword_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mcr = new ManagerCardReader();
            mcr.ShowDialog();
            Passed = mcr.Passed;
            if (Passed)
            {
                Close();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(10));
            }
        }
    }
}