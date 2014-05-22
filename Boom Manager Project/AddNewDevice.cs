using System;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;

namespace Boom_Manager_Project
{
    public partial class AddNewDevice : Form
    {
        private Point? _old;
        public AddNewDevice()
        {
            InitializeComponent();
        }
        private void AddNewDevice_Load(object sender, EventArgs e)
        {
//           SetMask();
        }

//        private void SetMask()
//        {
//            mtbIpAddress.Text = "192.168.0.   ";
//            mtbIpAddress.PromptChar = ' ';
//            mtbIpAddress.Mask = "192.168.0.900";
//            mtbIpAddress.ResetOnSpace = false;
//            mtbIpAddress.SkipLiterals = false;
//        }

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
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void AddNewDevice_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void AddNewDevice_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void AddNewDevice_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }

       
    }
}
