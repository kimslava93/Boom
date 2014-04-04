using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    public partial class AddNewStaffUser : Form
    {
        private Controller _controller; 
        public AddNewStaffUser()
        {
            InitializeComponent();
            _controller = new Controller();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            if (AllFieldsAreFullFilled())
            {
                personal_info_t newUser = new personal_info_t();
               
                
                newUser.person_id = tbPersonId.Text;
                newUser.name = tbName.Text;
                newUser.staff_login = tbLogin.Text;
                newUser.staff_password = tbPassword.Text;
                newUser.position = cbPosition.Text;
                newUser.phone = tbPhone.Text;
                newUser.additional_phone = tbAdditionalPhone.Text;
                newUser.birthday = dtpBirthday.Value;
                newUser.home_address = tbHomeAddress.Text;
                newUser.salary_per_day = (int)numUpDSalary.Value;
                newUser.registration_date = dtpRegistrationDate.Value;
                try
                {

                _controller.AddNewUser(newUser);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something wrong! Check the entered data!");
                }
                Close();
            }
            else
            {
                MessageBox.Show("Some fields have wrog values! Check entered data and try again.");
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
    }
}
