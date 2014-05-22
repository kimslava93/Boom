using System;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;

namespace Boom_Manager_Project
{
    public partial class DeviceManager : Form
    {
        private Point? _old;
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
            dgvAllDevices.Invalidate();
            if (dgvAllDevices.Rows.Count > 0)
            {
                dgvAllDevices.Rows[0].Selected = true;
                if (dgvAllDevices.CurrentRow != null)
                    LoadEndpointsIndexes((int) dgvAllDevices.CurrentRow.Cells[0].Value);
            }
            else
            {
                dgvAllEndPointsIndexes.DataSource = null;
                dgvAllEndPointsIndexes.Invalidate();
            }
        }

        private void LoadEndpointsIndexes(int deviceId)
        {
            dgvAllEndPointsIndexes.DataSource =
                DeviceManagerContoller.DeviceManagerContollerInstance().GetAllEndpoints(deviceId);
            dgvAllDevices.Invalidate();
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

        private void DeviceManager_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void DeviceManager_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void DeviceManager_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }

        private void dgvAllEndPointsIndexes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAllEndPointsIndexes.CurrentRow != null)
            {
                var ceci = new ChangeEndpointConsoleID((int)dgvAllEndPointsIndexes.CurrentRow.Cells[0].Value, (int)dgvAllDevices.CurrentRow.Cells[0].Value);
//                MessageBox.Show(dgvAllEndPointsIndexes.CurrentRow.Cells[0].Value + "");
                ceci.ShowDialog();
                LoadDevicesList();
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dgvAllDevices.CurrentRow != null)
            {
                DeviceManagerContoller.DeviceManagerContollerInstance()
                    .DeleteDevice((int) dgvAllDevices.CurrentRow.Cells[0].Value);
                LoadDevicesList();
                
                
            }
        }
    }
}
