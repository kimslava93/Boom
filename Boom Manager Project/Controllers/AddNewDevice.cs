using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boom_Manager_Project.Controllers
{
    public partial class AddNewDevice : Form
    {
        public AddNewDevice()
        {
            InitializeComponent();
        }
        private void AddNewDevice_Load(object sender, EventArgs e)
        {
           SetMask();
        }

        private void SetMask()
        {
            mtbIpAddress.Text = "   .   .   .   ";
            mtbIpAddress.PromptChar = ' ';
            mtbIpAddress.Mask = "009.009.009.900";
            mtbIpAddress.ResetOnSpace = false;
            mtbIpAddress.SkipLiterals = false;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            AddNewDeviceController.AddNewSessionControllerInstance()
                .AddNewDevice((int) numUpdDeviceId.Value, mtbIpAddress.Text);
            Close();
        }

        private void mtbIpAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

       
    }
}
