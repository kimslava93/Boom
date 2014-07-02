using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;

namespace Boom_Manager_Project
{
    public partial class ChangeEndpointConsoleID : Form
    {
        private int _endpointId;
        private int _deviceId;
        public ChangeEndpointConsoleID(int endpointId, int deviceId)
        {
            InitializeComponent();
            _endpointId = endpointId;
            _deviceId = deviceId;
        }

        private void EndPointsManager_Load(object sender, EventArgs e)
        {
            tbEndPointID.Text = _endpointId.ToString(CultureInfo.CurrentCulture);
            LoadConsolesList();
        }

        private void LoadConsolesList()
        {
            cbConsolesList.ValueMember = "playstation_id";
            cbConsolesList.DataSource = ChangeEndpointConsoleIdContolller.EndPointsManagerContolllerInstance().GetConsolesList();
            if (cbConsolesList.Items.Count > 0)
                cbConsolesList.SelectedIndex = 0;
            else
                MessageBox.Show("No consoles in the list");
        }


        private void bClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbEndPointID.Text) && !string.IsNullOrWhiteSpace(cbConsolesList.Text))
            {
                ChangeEndpointConsoleIdContolller.EndPointsManagerContolllerInstance()
                    .ChangePlaystationForEndPoint(int.Parse(tbEndPointID.Text), cbConsolesList.Text, _deviceId);
                Close();
            }
            else
            {
                MessageBox.Show("Wrong input data!");
            }
        }

        private void bSetToZero_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This will set to default(zero) endpoint with ID: " + tbEndPointID.Text +
                                              "\nAre you sure that you want to complete this action?\nPress OK to continue.",
                "Warning!", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                ChangeEndpointConsoleIdContolller.EndPointsManagerContolllerInstance()
                    .ChangePlaystationForEndPoint(int.Parse(tbEndPointID.Text), null, _deviceId);
                Close();
            }
        }

    }
}
