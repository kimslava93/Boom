using System;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class AddNewStaffUser : Form
    {
        private Point? _old;
        public AddNewStaffUser()
        {
            InitializeComponent();
            _addNewUserController = new AddNewUserController();
        }
        private void AddNewStaffUser_Load(object sender, EventArgs e)
        {
            mtbRegistrationDate.Text = DateTime.Now.ToShortDateString();
        }
        private void bSubmit_Click(object sender, EventArgs e)
        {
            if (AllFieldsAreFullFilled())
            {
                var newUser = new personal_info_t
                {
                    person_id = tbPersonId.Text,
                    name = tbName.Text,
                    staff_login = tbLogin.Text,
                    staff_password = tbPassword.Text,
                    position = cbPosition.Text,
                    phone = tbPhone.Text,
                    additional_phone = tbAdditionalPhone.Text,
                    birthday = DateTime.Parse(mtbBirthday.Text),
                    home_address = tbHomeAddress.Text,
                    salary_per_day = (int) numUpDSalary.Value,
                    registration_date = DateTime.Parse(mtbRegistrationDate.Text)
                };
                try
                {
                    _addNewUserController.AddNewUser(newUser);
                }
                catch (Exception)
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(8));//Wrong data
                }
                Close();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(9));
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool AllFieldsAreFullFilled()
        {
            if (tbPersonId.Text != null && tbName.Text != null && tbLogin.Text != null && tbPassword.Text != null &&
                cbPosition.SelectedText != null && tbPhone.Text != null &&
                tbHomeAddress.Text != null && numUpDSalary.Value > 0)
            {
                return true;
            }
            return false;

        }

        private void AddNewStaffUser_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void AddNewStaffUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void AddNewStaffUser_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }


    }
}
