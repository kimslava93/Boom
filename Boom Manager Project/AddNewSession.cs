using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;

namespace Boom_Manager_Project
{
    public partial class FAddNewSession : Form
    {
        private int _repeatCallOfMethodCounter;
        private readonly AddNewSessionController _addNewSessionController;
        public FAddNewSession()
        {
            _repeatCallOfMethodCounter = 0;
            InitializeComponent();
            _addNewSessionController = new AddNewSessionController();
        }

        private void AddNewSession_Load(object sender, EventArgs e)
        {
            
            UpdatePlaystationList();
            IsClientWithCardOrNot();
        }

        private void UpdatePlaystationList()
        {
            cbPlaystationId.ValueMember = "playstation_id";
            cbPlaystationId.DataSource = _addNewSessionController.GetAllFreeTablesId();
            
            if (cbPlaystationId.Items.Count > 0)
            {
                cbPlaystationId.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(_addNewSessionController.WarningMessages("NoFreePlaces"));
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
                decimal t = _addNewSessionController.UpdatePrice(tbDiscountCards.Text, cbPlaystationId.Text, 1, 0);
                numUpDPaidPrice.Minimum = t;
                numUpDPaidPrice.Value = t;
            }
            else if (!String.IsNullOrWhiteSpace(tbDiscountCards.Text))
            {
                numUpDClientMoneyLeft.Value = numUpDClientMoneyLeft.Maximum;
                numUpDHoursRemainedOnCard.Value = numUpDHoursRemainedOnCard.Maximum;
                numUpDMinutesRemainedOnCard.Value = numUpDMinutesRemainedOnCard.Maximum;
                TimeSpan paidTime = _addNewSessionController.UpdateUsualClientTimeLeft(numUpDClientMoneyLeft.Value,
                    cbPlaystationId.Text,
                    tbDiscountCards.Text, numUpDClientMoneyLeft.Minimum, numUpDClientMoneyLeft.Maximum);
                numUpDHoursRemainedOnCard.Value = (paidTime.Days*24 + paidTime.Hours);
            }
        }
        private void IsClientWithCardOrNot()
        {
            if (tbDiscountCards.Text == "0")
            {
                gbDepositPayment.Location = _addNewSessionController.ActiveLocation;
                gbDepositPayment.Enabled = true;
                gbClientInfo.Location = _addNewSessionController.PassiveLocation;
                gbClientInfo.Enabled = false;
            }
            else
            {
                gbClientInfo.Location = _addNewSessionController.ActiveLocation;
                gbClientInfo.Enabled = true;
                gbDepositPayment.Location = _addNewSessionController.PassiveLocation;
                gbDepositPayment.Enabled = false;
            }
        }

        private void tbDiscountCards_TextChanged(object sender, EventArgs e)
        {
            IsClientWithCardOrNot();
        }

        private void numUpDHoursLeft_ValueChanged(object sender, EventArgs e)
        {
            if (_repeatCallOfMethodCounter <= 0)
            {
                _repeatCallOfMethodCounter++;
                decimal t = _addNewSessionController.UpdatePrice(tbDiscountCards.Text, cbPlaystationId.Text,
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
                decimal t = _addNewSessionController.UpdatePrice(tbDiscountCards.Text, cbPlaystationId.Text,
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

        private void numUpDPaidPrice_ValueChanged(object sender, EventArgs e)
        {
            UsualClientPriceChanged();
        }

        private void UsualClientPriceChanged()
        {
            if (_repeatCallOfMethodCounter <= 0)
            {
                _repeatCallOfMethodCounter++;
                TimeSpan t = _addNewSessionController.UpdateUsualClientTimeLeft(numUpDPaidPrice.Value, cbPlaystationId.Text,
                    tbDiscountCards.Text, numUpDPaidPrice.Minimum, numUpDPaidPrice.Maximum);
                if (t.Hours > numUpDHoursLeft.Maximum)
                {
                    numUpDHoursLeft.Value = numUpDHoursLeft.Maximum;
                    numUpDMinutesLeft.Value = 0;
                }
                else if (t.Hours < numUpDHoursLeft.Minimum)
                {
                    numUpDHoursLeft.Value = numUpDHoursLeft.Minimum;
                    numUpDMinutesLeft.Value = 0;
                }
                else
                {
                    numUpDHoursLeft.Value = t.Hours + t.Days * 24;
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
                TimeSpan t = _addNewSessionController.UpdateUsualClientTimeLeft(numUpDClientMoneyLeft.Value, cbPlaystationId.Text,
                    tbDiscountCards.Text, numUpDClientMoneyLeft.Minimum, numUpDClientMoneyLeft.Maximum);
                if (t.Hours > numUpDHoursRemainedOnCard.Maximum)
                {
                    numUpDHoursRemainedOnCard.Value = numUpDHoursRemainedOnCard.Maximum;
                    numUpDMinutesLeft.Value = 0;
                }
                else if (t.Hours < numUpDHoursRemainedOnCard.Minimum)
                {
                    numUpDHoursRemainedOnCard.Value = numUpDHoursRemainedOnCard.Minimum;
                    numUpDMinutesLeft.Value = 0;
                }
                else
                {
                    numUpDHoursRemainedOnCard.Value = t.Hours + t.Days * 24;
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
                var result = _addNewSessionController.AddNewClientToField(adcs.ClientID, tbDiscountCards.Text,
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

        private void numUpDClientMoneyLeft_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bAddSession_Click(object sender, EventArgs e)
        {
            if (tbDiscountCards.Text == "0")
            {
                TimeSpan paidTime =
                    TimeSpan.FromMinutes((double) numUpDHoursLeft.Value*60 + (double) numUpDMinutesLeft.Value);

                _addNewSessionController.AddNewDaySession(cbPlaystationId.Text, tbDiscountCards.Text, paidTime,
                    (double) numUpDPaidPrice.Value);
                Close();
            }
            else if (!String.IsNullOrEmpty(tbDiscountCards.Text) && tbDiscountCards.Text.Length > 2)
            {
                MessageBox.Show("ClientWithCard");
                Close();
            }
            
        }
    }
}
