using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            StartTimers();
            UpdatePlaystationList();
            IsClientWithCardOrNot();
//            numUpDPaidPrice.Minimum = numUpDPaidPrice.Value;
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

        private void StartTimers()
        {
            current_time_timer.Enabled = true;
            current_time_timer.Start();

            lCurrentDate.Text = _addNewSessionController.StartDate();
            lCurrentTime.Text = _addNewSessionController.StartTimer();
        }

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
                decimal t = _addNewSessionController.SetPrice(tbDiscountCards.Text, cbPlaystationId.Text, 1, 0);
                numUpDPaidPrice.Minimum = t;
                numUpDPaidPrice.Value = t;
            }
            else if (!String.IsNullOrWhiteSpace(tbDiscountCards.Text))
            {
                numUpDClientMoneyLeft.Value = numUpDClientMoneyLeft.Maximum;
                numUpDHoursRemainedOnCard.Value = numUpDHoursRemainedOnCard.Maximum;
                numUpDMinutesRemainedOnCard.Value = numUpDMinutesRemainedOnCard.Maximum;
                TimeSpan paidTime = _addNewSessionController.PaidPriceChanged(numUpDClientMoneyLeft.Value,
                    cbPlaystationId.Text,
                    tbDiscountCards.Text, numUpDClientMoneyLeft.Minimum, numUpDClientMoneyLeft.Maximum);
                numUpDHoursRemainedOnCard.Value = (decimal) (paidTime.TotalDays - paidTime.Hours);
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
                decimal t = _addNewSessionController.SetPrice(tbDiscountCards.Text, cbPlaystationId.Text,
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
                decimal t = _addNewSessionController.SetPrice(tbDiscountCards.Text, cbPlaystationId.Text,
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
            if (_repeatCallOfMethodCounter <= 0)
            {
                _repeatCallOfMethodCounter++;
                TimeSpan t = _addNewSessionController.PaidPriceChanged(numUpDPaidPrice.Value, cbPlaystationId.Text,
                    tbDiscountCards.Text, numUpDPaidPrice.Minimum, numUpDPaidPrice.Maximum);
                if (t.Hours > numUpDHoursLeft.Maximum)
                {
                    numUpDHoursLeft.Value = numUpDHoursLeft.Maximum;
//                    numUpDMinutesLeft.Value = numUpDMinutesLeft.Maximum;
                }
                else if (t.Hours < numUpDHoursLeft.Minimum)
                {
                    numUpDHoursLeft.Value = numUpDHoursLeft.Minimum;
//                    numUpDMinutesLeft.Value = numUpDMinutesLeft.Minimum;
                }
                else
                {
                    numUpDHoursLeft.Value = t.Hours + t.Days*24;
                    numUpDMinutesLeft.Value = t.Minutes;
                }
            }
            _repeatCallOfMethodCounter = 0;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
