using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;

namespace Boom_Manager_Project
{
    public partial class AddMoneyOnDiscountCard : Form
    {
        private readonly string _clientId;
        private bool changedSmth = false;
        private List<object> data;
        public AddMoneyOnDiscountCard(string clientID)
        {
            _clientId = clientID;
            InitializeComponent();
        }

        private void AddMoneyOnDiscountCard_Load(object sender, EventArgs e)
        {
            FulFillCLientInfo();
        }

        private void FulFillCLientInfo()
        {
            if (_clientId != "0")
            {
                tbID.Text = _clientId;
                data = AddMoneyOnDiscountCardController.AddMoneyOnCardControllerInstance().GetClientInfo(_clientId);
                if (!data[0].Equals("No client info"))
                {
                    tbName.Text = data[0].ToString();
                    tbMoneyOnCard.Text = data[1].ToString();
                }
                else
                {
                    MessageBox.Show("Client " + _clientId + " cannot be found info");
                    Close();
                }
            }

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            tbMoneyOnCard.Text =
                AddMoneyOnDiscountCardController.AddMoneyOnCardControllerInstance()
                    .AddMoneyOnCard(tbMoneyOnCard.Text, (double) numUpDMoneyToAdd.Value);
            data[1] = tbMoneyOnCard.Text;
            numUpDMoneyToAdd.Value = 1;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            AddMoneyOnDiscountCardController.AddMoneyOnCardControllerInstance().SubmitChanges(data, _clientId);
            Close();
        }
    }
}
