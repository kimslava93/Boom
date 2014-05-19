using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using LINQ_test.Driver;

namespace Boom_Manager_Project
{
    public partial class FAddNewSession : Form
    {
        private Point? _old;
        private int _repeatCallOfMethodCounter;
        private List<Endpoint> _endpoints;
        private Device _device1;
        public FAddNewSession()
        {
            _repeatCallOfMethodCounter = 0;
            InitializeComponent();

        }

        private void AddNewSession_Load(object sender, EventArgs e)
        {
            _device1 = new Device(IPAddress.Parse("192.168.0.201"));
            _endpoints = AddNewSessionController.AddNewSessionControllerInstance().LoadingOfEndPoints(_device1);
            UpdatePlaystationList();
            IsClientWithCardOrNot();
        }

        private void UpdatePlaystationList()
        {
            cbPlaystationId.ValueMember = "playstation_id";
            cbPlaystationId.DataSource = AddNewSessionController.AddNewSessionControllerInstance().GetAllFreeTablesId();
            
            if (cbPlaystationId.Items.Count > 0)
            {
                cbPlaystationId.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(AddNewSessionController.AddNewSessionControllerInstance().WarningMessages("NoFreePlaces"));
                Close();
            }
        }

//        private void StartTimers()
//        {
//            current_time_timer.Enabled = true;
//            current_time_timer.Start();
//
//            lCurrentDate.Text = _addNewSessionController.StartDate();
//            lCurrentTime.Text = _addNewSessionController.StartTimer();
//        }

        private void cbPlaystationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDefaultPropertiesForFields();
        }
        private void SetDefaultPropertiesForFields()
        {
            if (tbDiscountCards.Text == "0")
            {
                _repeatCallOfMethodCounter += 2;
                numUpDHoursLeft.Value = 1;
                numUpDMinutesLeft.Value = 0;
                decimal t = AddNewSessionController.AddNewSessionControllerInstance().UpdatePrice(tbDiscountCards.Text, cbPlaystationId.Text, 1, 0);
                numUpDPaidPrice.Minimum = t;
                numUpDPaidPrice.Value = t;
            }
            else if (!String.IsNullOrWhiteSpace(tbDiscountCards.Text))
            {
                numUpDClientMoneyLeft.Value = numUpDClientMoneyLeft.Maximum;
                numUpDHoursRemainedOnCard.Value = numUpDHoursRemainedOnCard.Maximum;
                numUpDMinutesRemainedOnCard.Value = numUpDMinutesRemainedOnCard.Maximum;
                TimeSpan paidTime = AddNewSessionController.AddNewSessionControllerInstance().UpdateTimeLeft(numUpDClientMoneyLeft.Value,
                    cbPlaystationId.Text, numUpDClientMoneyLeft.Minimum, numUpDClientMoneyLeft.Maximum);
                bAddSession.Enabled = true;
                if (paidTime > TimeSpan.FromHours(1))
                {
                    numUpDHoursRemainedOnCard.Value = (paidTime.Days*24 + paidTime.Hours);
                }
                else
                {
                    bAddSession.Enabled = false;
                    MessageBox.Show("Insufficient money on card!\nPlease put more money on card(s) with id#" + tbDiscountCards.Text + "\nor add another card for game!");
                }
            }
        }
        private void IsClientWithCardOrNot()
        {
            if (tbDiscountCards.Text == "0")
            {
                gbDepositPayment.Location = AddNewSessionController.AddNewSessionControllerInstance().ActiveLocation;
                gbDepositPayment.Enabled = true;
                gbClientInfo.Location = AddNewSessionController.AddNewSessionControllerInstance().PassiveLocation;
                gbClientInfo.Enabled = false;
            }
            else
            {
                gbClientInfo.Location = AddNewSessionController.AddNewSessionControllerInstance().ActiveLocation;
                gbClientInfo.Enabled = true;
                gbDepositPayment.Location = AddNewSessionController.AddNewSessionControllerInstance().PassiveLocation;
                gbDepositPayment.Enabled = false;
            }
        }

        private void tbDiscountCards_TextChanged(object sender, EventArgs e)
        {
            IsClientWithCardOrNot();
//            SetDefaultPropertiesForFields();
        }

        private void numUpDHoursLeft_ValueChanged(object sender, EventArgs e)
        {
            if (_repeatCallOfMethodCounter <= 0)
            {
                _repeatCallOfMethodCounter++;
                decimal t = AddNewSessionController.AddNewSessionControllerInstance().UpdatePrice(tbDiscountCards.Text, cbPlaystationId.Text,
                    numUpDHoursLeft.Value,
                    numUpDMinutesLeft.Value);
                if (t > numUpDPaidPrice.Maximum)
                    numUpDPaidPrice.Value = numUpDPaidPrice.Maximum;
                else if (t < numUpDPaidPrice.Minimum)
                    numUpDPaidPrice.Value = numUpDPaidPrice.Minimum;
                else
                    numUpDPaidPrice.Value = t;
            }
            _repeatCallOfMethodCounter = 0;
        }

        private void numUpDMinutesLeft_ValueChanged(object sender, EventArgs e)
        {
            if (_repeatCallOfMethodCounter <= 0)
            {
                if (numUpDMinutesLeft.Value > 59)
                {
                    numUpDMinutesLeft.Value = 0;
                    numUpDHoursLeft.Value++;
                }
                _repeatCallOfMethodCounter++;
                decimal t = AddNewSessionController.AddNewSessionControllerInstance().UpdatePrice(tbDiscountCards.Text, cbPlaystationId.Text,
                    numUpDHoursLeft.Value, numUpDMinutesLeft.Value);
                if (t < numUpDPaidPrice.Minimum)
                {
                    numUpDPaidPrice.Value = numUpDPaidPrice.Minimum;
                }
                else if (t > numUpDPaidPrice.Maximum)
                {
                    numUpDPaidPrice.Value = numUpDPaidPrice.Maximum;
                }
                else
                {
                    numUpDPaidPrice.Value = t;
                }
            }
            _repeatCallOfMethodCounter = 0;
        }

        private void numUpDPaidPrice_ValueChanged(object sender, EventArgs e)//without card
        {
            UsualClientPriceChanged();
        }
        private void numUpDClientMoneyLeft_ValueChanged(object sender, EventArgs e)//client with card
        {
            ClientPriceChanged();
        }
        private void UsualClientPriceChanged()
        {
            if (_repeatCallOfMethodCounter <= 0)
            {
                _repeatCallOfMethodCounter++;
                TimeSpan t = AddNewSessionController.AddNewSessionControllerInstance().UpdateTimeLeft(numUpDPaidPrice.Value, cbPlaystationId.Text, numUpDPaidPrice.Minimum, numUpDPaidPrice.Maximum);
                if (t.Hours > numUpDHoursLeft.Maximum)
                {
                    bAddSession.Enabled = true;
                    numUpDHoursLeft.Value = numUpDHoursLeft.Maximum;
                    numUpDMinutesLeft.Value = 0;
                }
                else if (t.Hours < numUpDHoursLeft.Minimum)
                {
                    bAddSession.Enabled = false;
                    MessageBox.Show("Insufficient money to play minimum one hour!");
                    numUpDHoursLeft.Value = numUpDHoursLeft.Minimum;
                    numUpDMinutesLeft.Value = 0;
                }
                else
                {
                    bAddSession.Enabled = true;
                    numUpDHoursLeft.Value = t.Hours + t.Days*24;
                    numUpDMinutesLeft.Value = t.Minutes;
                }
            }
            _repeatCallOfMethodCounter = 0;
        }

        private void ClientPriceChanged()
        {
            if (_repeatCallOfMethodCounter <= 0)
            {
                _repeatCallOfMethodCounter++;
                TimeSpan t = AddNewSessionController.AddNewSessionControllerInstance().UpdateTimeLeft(numUpDClientMoneyLeft.Value,
                    cbPlaystationId.Text, numUpDClientMoneyLeft.Minimum, numUpDClientMoneyLeft.Maximum);
                if (t.Hours > numUpDHoursRemainedOnCard.Maximum)
                {
                    bAddSession.Enabled = true;
                    numUpDHoursRemainedOnCard.Value = numUpDHoursRemainedOnCard.Maximum;
                    numUpDMinutesLeft.Value = 0;
                }
                else if (t.Hours < numUpDHoursRemainedOnCard.Minimum)
                {
                    bAddSession.Enabled = false;
                    MessageBox.Show("Insufficient money on card!\nPlease put more money on card(s) with id#" + tbDiscountCards.Text + "\nor add another card for game!");
                    numUpDHoursRemainedOnCard.Value = numUpDHoursRemainedOnCard.Minimum;
                    numUpDMinutesLeft.Value = 0;
                }
                else
                {
                    bAddSession.Enabled = true;
                    numUpDHoursRemainedOnCard.Value = t.Hours + t.Days*24;
                    numUpDMinutesRemainedOnCard.Value = t.Minutes;
                }
            }
            _repeatCallOfMethodCounter = 0;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAddDiscountCard_Click(object sender, EventArgs e)
        {
            var adcs = new AddDiscountCardToSession();
            adcs.ShowDialog();
            if (adcs.ClientID == "0" || String.IsNullOrWhiteSpace(adcs.ClientID))
            {
                tbDiscountCards.Text = "0";
            }
            else
            {
                var result = AddNewSessionController.AddNewSessionControllerInstance().AddNewClientToField(adcs.ClientID, tbDiscountCards.Text,
                    tbClientName.Text, numUpDClientMoneyLeft.Value, adcs.ClientName, adcs.MoneyLeft);
                if (result != null && result.Count != 0)
                {
                    tbDiscountCards.Text = result[0];
                    tbClientName.Text = result[1];
                    numUpDClientMoneyLeft.Minimum = decimal.Parse(result[2].Replace(".", ","));
                    numUpDClientMoneyLeft.Maximum = decimal.Parse(result[2].Replace(".", ","));
                    numUpDClientMoneyLeft.Value = decimal.Parse(result[2].Replace(".", ","));
                }
            }
            IsClientWithCardOrNot();
        }

       

        private void bAddSession_Click(object sender, EventArgs e)
        {

            if (tbDiscountCards.Text == "0")
            {
                UsualClientPriceChanged();
                TimeSpan paidTime =
                    TimeSpan.FromMinutes((double) numUpDHoursLeft.Value*60 + (double) numUpDMinutesLeft.Value);

                AddNewSessionController.AddNewSessionControllerInstance().AddNewDaySession(cbPlaystationId.Text, tbDiscountCards.Text, paidTime,
                    (double) numUpDPaidPrice.Value,DateTime.Now);
//                MessageBox.Show(numUpDPaidPrice.Value.ToString());
                Close();
            }
            else if (!String.IsNullOrEmpty(tbDiscountCards.Text) && tbDiscountCards.Text.Length > 2)
            {
                ClientPriceChanged();
                TimeSpan paidTime =
                    TimeSpan.FromMinutes((double)numUpDHoursRemainedOnCard.Value * 60 + (double)numUpDMinutesRemainedOnCard.Value);

                AddNewSessionController.AddNewSessionControllerInstance().AddNewDaySession(cbPlaystationId.Text, tbDiscountCards.Text, paidTime,
                    (double)numUpDClientMoneyLeft.Value, DateTime.Now);
                Close();
            }
            
        }

        private void bAddSession_MouseHover(object sender, EventArgs e)
        {
            bAddSession.FlatAppearance.BorderColor = Color.White;
        }

        private void bAddSession_MouseLeave(object sender, EventArgs e)
        {
            bAddSession.FlatAppearance.BorderColor = Color.FromArgb(81, 91, 103);
        }

        private void bCancel_MouseHover(object sender, EventArgs e)
        {
            bCancel.FlatAppearance.BorderColor = Color.White;
        }

        private void bCancel_MouseLeave(object sender, EventArgs e)
        {
            bCancel.FlatAppearance.BorderColor = Color.FromArgb(81, 91, 103);
        }

        private void bAddDiscountCard_MouseHover(object sender, EventArgs e)
        {
            bAddDiscountCard.FlatAppearance.BorderColor = Color.White;
        }

        private void bAddDiscountCard_MouseLeave(object sender, EventArgs e)
        {
            bAddDiscountCard.FlatAppearance.BorderColor = Color.FromArgb(81, 91, 103);
        }

        private void FAddNewSession_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void FAddNewSession_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void FAddNewSession_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }
    }
}
