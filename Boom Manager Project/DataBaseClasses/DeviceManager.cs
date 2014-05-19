using System;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;

namespace Boom_Manager_Project.DataBaseClasses
{
    public partial class DeviceManager : Form
    {
        public DeviceManager()
        {
            InitializeComponent();
            
        }

        private void DeviceManager_Load(object sender, EventArgs e)
        {
            LoadDevicesList();
        }

        private void LoadDevicesList()
        {
            dgvAllDevices.DataSource = DeviceManagerContoller.DeviceManagerContollerInstance().GetAllDevices();
            if (dgvAllDevices.Rows.Count > 0)
            {
                dgvAllDevices.Rows[0].Selected = true;
                if (dgvAllDevices.CurrentRow != null)
                    LoadEndpointsIndexes((int)dgvAllDevices.CurrentRow.Cells[0].Value);
            }
        }

        private void LoadEndpointsIndexes(int deviceId)
        {
            dgvAllEndPointsIndexes.DataSource =
                DeviceManagerContoller.DeviceManagerContollerInstance().GetAllEndpoints(deviceId);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            var and = new AddNewDevice();
            and.ShowDialog();
            LoadDevicesList();
        }
    }
}
