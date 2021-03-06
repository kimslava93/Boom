﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.Models;

namespace Boom_Manager_Project
{
    //-----------------------------------------------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------------------------------------------
    //------------------------------------------------WHEN WILL BE INTEGRATED CLIENT SAVINGS ACCOUNT-------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------------------------------------------
    public partial class AddDiscountCardToSession : Form
    {
        public string ClientID { get; set; }
        public string ClientName { get; set; }
        public decimal MoneyLeft { get; set; }
        private Point? _old;
//        private readonly AddDiscountToSessionModel _adcts;
        public AddDiscountCardToSession()
        {
            InitializeComponent();
           
//            _adcts = new AddDiscountToSessionModel();
        }

        private void AddDiscountCardToSession_Load(object sender, EventArgs e)
        {
            if (!AddDiscountToSessionModel.AddDiscountToSessionModelInstance().IsThereAnyClients())
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(23));
                Close();
            }
            FullFillCbOfClients();
        }

        private void FullFillCbOfClients()
        {
            cbDiscountCard.ValueMember = "client_id";
            cbDiscountCard.DataSource = AddDiscountToSessionModel.AddDiscountToSessionModelInstance().GetClientList();
            if (cbDiscountCard.Items.Count > 0)
                cbDiscountCard.SelectedIndex = 0;
            else
                MessageBox.Show(AddDiscountToSessionModel.AddDiscountToSessionModelInstance().GetWarning("noClients"));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClientID = Options.OptionsInstance().UsualClient;
            ClientName = "Usual client";
            MoneyLeft = (decimal)0.0;
            Close();
        }

        private void cbDiscountCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAllData();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            CheckAllData();
            Close();
        }

        private void CheckAllData()
        {
            List<string> result = AddDiscountToSessionModel.AddDiscountToSessionModelInstance().GetClientInfo(cbDiscountCard.Text);
            tbClientName.Text = result[1];
            tbClientsMoneyLeft.Text = result[2]; //Счетчик.ToString(CultureInfo.InvariantCulture);
            ClientID = result[0];
            MoneyLeft = decimal.Parse(result[2].Replace(".", ",")); //if (double.TryParse(values[i, j].Replace(".", ","), out tmp))
            ClientName = result[1];
        }

        private void bAddMoney_Click(object sender, EventArgs e)
        {
            var amodc = new AddMoneyOnDiscountCard(ClientID);
            amodc.ShowDialog();
            FullFillCbOfClients();
        }

        private void lMoneyLeft_Click(object sender, EventArgs e)
        {

        }

        private void lClientName_Click(object sender, EventArgs e)
        {

        }

        private void lDsicountId_Click(object sender, EventArgs e)
        {

        }

        private void tbClientsMoneyLeft_TextChanged(object sender, EventArgs e)
        {

        }

        private void lAddMoney_Click(object sender, EventArgs e)
        {

        }

        private void tbClientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCancel_MouseHover(object sender, EventArgs e)
        {

        }

        private void bCancel_MouseLeave(object sender, EventArgs e)
        {

        }

        private void AddDiscountCardToSession_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void AddDiscountCardToSession_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void AddDiscountCardToSession_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }
    }
}
