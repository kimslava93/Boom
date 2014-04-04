using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Boom_Manager_Project
{
    public partial class EnterPassword : Form
    {
        private const string MANAGER = "MANAGER";
//        private const string ADMIN = "admin";
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
                    if (matchedStaff.position == MANAGER)
                    {
                        if (_accessPosition == MANAGER && matchedStaff.staff_password == tbPassword.Text)
                        {
                            Passed = true;
                            Close();
                        }
                        else
                        {
                            MessageWrongInput();
                        }
                    }
                    else if (matchedStaff.position == "administrator")
                    {
                        if (_accessPosition == MANAGER)
                        {
                            MessageBox.Show("Only manager have an access to this field!");
                        }
                        else if (_accessPosition != MANAGER && matchedStaff.staff_password == tbPassword.Text)
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
            MessageBox.Show(" Invalid Login or password!", "Error!", MessageBoxButtons.OK,
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
            if (tbLogin.Text == "Login")
            {
                tbLogin.Text = "";
            }
        }

        private void tbPassword_MouseClick(object sender, MouseEventArgs e)
        {
            tbPassword.BackColor = Color.White;
            tbPassword.ForeColor = Color.Black;
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}