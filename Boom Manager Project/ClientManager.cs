using System;
using System.Globalization;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
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
            LoadDiscountsComboBox();
        }

        private void ClientManager_Load(object sender, EventArgs e)
        {
            LoadMode();
        }

        private void LoadDiscountsComboBox()
        {
            cbAllDiscounts.DataSource =
                ClientManagerController.ClientManagerControllerInstance().GetListOfAvailableDiscounts();
            cbAllDiscounts.Invalidate();
            if (cbAllDiscounts.Items.Count > 0)
            {
                cbAllDiscounts.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(51));
            }
        }

        private void LoadMode()
        {
            if (!String.IsNullOrWhiteSpace(_command) && _command == CREATE)
            {
                bApply.Text = @"Create";
                gbClientInfo.Text = @"Create client";
                cbClients.Location = ClientManagerController.ClientManagerControllerInstance().CREATEMode;
                tbClientId.Location = ClientManagerController.ClientManagerControllerInstance().EDITMode;
                cbClients.Enabled = false;
                tbClientId.Enabled = true;
                numUpdBDay.Enabled = true;
                numUpdBMonth.Enabled = true;
                numUpdBYear.Enabled = true;
                cbAllDiscounts.Enabled = true;
                numUpDSavings.Enabled = true;
                tbPlayedSum.Enabled = false;
                tbActivationDate.Text = DateTime.Now.ToShortDateString();
            }
            else if (!String.IsNullOrWhiteSpace(_command) && _command == EDIT)
            {
                UpdateClientsList();
                if (!String.IsNullOrWhiteSpace(cbClients.Text))
                {
                    if (cbClients.Items.Count > 0)
                        cbClients.SelectedIndex = 0;
                }
                
                bApply.Text = @"Применить";
                gbClientInfo.Text = @"Правка клиента";
                cbClients.Location = ClientManagerController.ClientManagerControllerInstance().EDITMode;
                tbClientId.Location = ClientManagerController.ClientManagerControllerInstance().CREATEMode;
                cbClients.Enabled = true;
                tbClientId.Enabled = false;
               
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(37));
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
            if (c.birthday != null)
            {
                numUpdBDay.Text = c.birthday.Value.Day.ToString(CultureInfo.InvariantCulture);
                numUpdBMonth.Text = c.birthday.Value.Month.ToString(CultureInfo.InvariantCulture);
                numUpdBYear.Text = c.birthday.Value.Year.ToString(CultureInfo.InvariantCulture);
            }

            tbEmail.Text = c.email;
            
            if (c.pers_discount != null)
                cbAllDiscounts.Text = c.pers_discount.ToString();

            tbPlayedSum.Text = c.played_sum.ToString(CultureInfo.InvariantCulture);
            
            if (cbClients.Text == Options.OptionsInstance().UsualClient)
            {
                tbName.Enabled = false;
                tbActivationDate.Enabled = false;
                numUpdBDay.Enabled = false;
                numUpdBMonth.Enabled = false;
                numUpdBYear.Enabled = false;
                tbEmail.Enabled = false;
                tbPlayedSum.Enabled = false;
                cbAllDiscounts.Enabled = false;
                tbPhone.Enabled = false;
                numUpDSavings.Value = 0;
                numUpDSavings.Enabled = false;
            }
            else
            {
                account_savings_t s =
                ClientManagerController.ClientManagerControllerInstance().GetClientSavings(cbClients.Text);
                numUpDSavings.Value = (decimal)s.savings;
                cbAllDiscounts.Enabled = false;
                numUpdBDay.Enabled = true;
                numUpdBMonth.Enabled = true;
                numUpdBYear.Enabled = true;
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
            var bday = new DateTime((int)numUpdBYear.Value, (int)numUpdBMonth.Value, (int)numUpdBDay.Value);
            ClientManagerController.ClientManagerControllerInstance()
                .CreateNewClient(tbClientId.Text, tbName.Text, tbEmail.Text, bday,
                    tbPhone.Text, tbActivationDate.Text, double.Parse(cbAllDiscounts.Text), int.Parse(tbPlayedSum.Text));
            Close();
        }


        private void cbAllClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             var t = ClientManagerController.ClientManagerControllerInstance().GetPriceForDiscount(int.Parse(cbAllDiscounts.Text)).ToString(CultureInfo.InvariantCulture);
            if (!string.IsNullOrEmpty(cbAllDiscounts.Text))
                tbPlayedSum.Text = t;
        }


    }
}
