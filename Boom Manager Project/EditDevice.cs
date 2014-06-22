using System;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class EditDevice : Form
    {
        private readonly int _deviceID;
        private readonly string _deviceIpAdress;
        public EditDevice(int deviceID, string ipAddress)
        {
            InitializeComponent();
            _deviceID = deviceID;
            _deviceIpAdress = ipAddress;
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(numUpdDeviceId.Text) && !String.IsNullOrEmpty(mtbIpAddress.Text))
            {
                DataBaseClass.Instancedb().EditDevice((int) numUpdDeviceId.Value, mtbIpAddress.Text);
                Close();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(9));
            }
        }

        private void EditDevice_Load(object sender, EventArgs e)
        {
            numUpdDeviceId.Value = _deviceID;
            numUpdDeviceId.Invalidate();
            mtbIpAddress.Text = _deviceIpAdress;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
