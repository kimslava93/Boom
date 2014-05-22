using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Controllers
{
    public partial class ClientManager : Form
    {
        private const string CREATE = "create";
        private const string EDIT = "edit";
        private readonly string _command;

        public ClientManager(string command)
        {
            InitializeComponent();
            _command = command;
        }

        private void ClientManager_Load(object sender, EventArgs e)
        {
            LoadMode();
        }

        private void LoadMode()
        {
            if (!String.IsNullOrWhiteSpace(_command) && _command == CREATE)
            {
                bApply.Text = "Create";
                gbClientInfo.Text = "Create client";
                cbClients.Location = ClientManagerController.ClientManagerControllerInstance().CREATEMode;
                numUpDClientIdCreate.Location = ClientManagerController.ClientManagerControllerInstance().EDITMode;
                cbClients.Enabled = false;
                numUpDClientIdCreate.Enabled = true;
                tbBirthday.Enabled = true;
                numUpDDiscount.Enabled = true;
                tbBirthday.Enabled = true;
                numUpDSavings.Enabled = true;
                tbPlayedSum.Enabled = false;
            }
            else if (!String.IsNullOrWhiteSpace(_command) && _command == EDIT)
            {
                UpdateClientsList();
                if (!String.IsNullOrWhiteSpace(cbClients.Text))
                {
                    if (cbClients.Items.Count > 0)
                        cbClients.SelectedIndex = 0;
                }
                
                bApply.Text = "Apply";
                gbClientInfo.Text = "Edit client info";
                cbClients.Location = ClientManagerController.ClientManagerControllerInstance().EDITMode;
                numUpDClientIdCreate.Location = ClientManagerController.ClientManagerControllerInstance().CREATEMode;
                cbClients.Enabled = true;
                numUpDClientIdCreate.Enabled = false;
               
            }
            else
            {
                MessageBox.Show("Unknown mode! Please check the input data!");
            }
        }

        private void UpdateClientsList()
        {
            cbClients.DataSource = ClientManagerController.ClientManagerControllerInstance().GetAllClients();
            if (cbClients.Items.Count > 0)
                cbClients.SelectedIndex = 0;
        }

        private void FulFillClientInfo()
        {
            client_info_t c = ClientManagerController.ClientManagerControllerInstance().GetClientInfo(cbClients.Text);
            
            tbName.Text = c.name;
            tbActivationDate.Text = c.activation_date.ToString(CultureInfo.InvariantCulture);
            tbBirthday.Text = c.birthday.ToString();
            tbEmail.Text = c.email;
            
            if (c.pers_discount != null)
                numUpDDiscount.Value = (decimal)c.pers_discount;

            tbPlayedSum.Text = c.played_sum.ToString(CultureInfo.InvariantCulture);
            
            if (cbClients.Text == "0")
            {
                tbName.Enabled = false;
                tbActivationDate.Enabled = false;
                tbBirthday.Enabled = false;
                tbEmail.Enabled = false;
                tbPlayedSum.Enabled = false;
                numUpDDiscount.Enabled = false;
                tbPhone.Enabled = false;
                numUpDSavings.Value = 0;
                numUpDSavings.Enabled = false;
            }
            else
            {
                account_savings_t s =
                ClientManagerController.ClientManagerControllerInstance().GetClientSavings(cbClients.Text);
                numUpDSavings.Value = (decimal)s.savings;
                numUpDDiscount.Enabled = false;
                tbBirthday.Enabled = true;
                tbName.Enabled = true;
                tbPhone.Enabled = true;
                tbActivationDate.Enabled = false;
                tbEmail.Enabled = true;
                numUpDSavings.Enabled = false;
                tbPlayedSum.Enabled = false;
            }
        }

        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
           FulFillClientInfo();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            ClientManagerController.ClientManagerControllerInstance()
                .CreateNewClient((int) numUpDClientIdCreate.Value, tbName.Text, tbEmail.Text, tbBirthday.Text,
                    tbPhone.Text, tbActivationDate.Text, (double) numUpDSavings.Value, 0);
        }


    }
}
