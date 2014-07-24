using System;
using System.Globalization;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.Models;

namespace Boom_Manager_Project
{
    public partial class TimeTester : Form
    {
        private int _buttonPressCounter = 1;
        private static readonly TimeSpan MinimumTime = new TimeSpan(0, 0, 30, 0);
        private int _repeatCallOfMethodCounter;
        public TimeTester()
        {
            InitializeComponent();
        }

        private void TimeTester_Load(object sender, EventArgs e)
        {
            _repeatCallOfMethodCounter = 0;
            UpdatePlaystationList();
            IsClientWithCardOrNot();
        }

        private void numUpDPaidPrice_ValueChanged(object sender, EventArgs e)
        {
            _buttonPressCounter = 1;
            if (numUpDPaidPrice.Value >= numUpDPaidPrice.Maximum || numUpDPaidPrice.Value < numUpDPaidPrice.Minimum ||
                double.IsInfinity((double)numUpDPaidPrice.Value))
            {
                SetDefaultPropertiesForFields();
            }
            UsualClientPriceChanged();
        }
        private void SetDefaultPropertiesForFields()
        {
            if (cbNighTime.Checked)
            {
                _repeatCallOfMethodCounter = 5;

                var t =
                    (decimal)DataBaseClass.Instancedb().GetNightTimePriceForPlaystation(cbPlaystationId.Text);
                numUpDPaidPrice.Minimum = t;
                numUpDPaidPrice.Maximum = t;
                numUpDPaidPrice.Value = t;
                numUpDPaidPrice.Invalidate();
                tbDiscountCards.Enabled = false;
                tbDiscountCards.Text = @"0";
                tbDiscountSize.Text = @"0";
                tbDiscountCards.ReadOnly = true;
            }
            else
            {
                _repeatCallOfMethodCounter = 2;
                numUpDHoursLeft.Value = 1;//MinimumTime.Hours;
                numUpDMinutesLeft.Minimum = 0;//MinimumTime.Minutes;
                numUpDMinutesLeft.Value = 0;//MinimumTime.Minutes;
                var t = AddNewSessionController.AddNewSessionControllerInstance()
                    .UpdatePrice(cbPlaystationId.Text, 1, 0, DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value));
                
                var minimum = AddNewSessionController.AddNewSessionControllerInstance()
                    .UpdatePrice(cbPlaystationId.Text, MinimumTime.Hours, MinimumTime.Minutes, DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value));
                tbDiscountCards.Enabled = true;
                tbDiscountCards.Text = @"0";
                tbDiscountSize.Text = @"0";
                tbDiscountCards.ReadOnly = false;
                numUpDPaidPrice.Minimum = minimum;
                numUpDPaidPrice.Maximum = 18900;
                numUpDPaidPrice.Value = t;
                _repeatCallOfMethodCounter = 0;
            }
        }
        private void UsualClientPriceChanged()
        {
            if (_repeatCallOfMethodCounter <= 0)
            {
                _repeatCallOfMethodCounter++;
                decimal paidPrice = numUpDPaidPrice.Value;
                TimeSpan t = AddNewSessionController.AddNewSessionControllerInstance()
                    .UpdateTimeLeft(paidPrice, cbPlaystationId.Text, numUpDPaidPrice.Minimum, numUpDPaidPrice.Maximum, DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value));

                if (numUpDMinutesLeft.Value < numUpDMinutesLeft.Minimum)
                {
                    numUpDMinutesLeft.Value = numUpDMinutesLeft.Minimum;
                }
                if ((t.Hours + t.Days * 24) > numUpDHoursLeft.Maximum)
                {
                    bAddSession.Enabled = true;
                    numUpDHoursLeft.Value = numUpDHoursLeft.Maximum;
                    numUpDMinutesLeft.Value = 0;
                }
                else if (t.Hours < numUpDHoursLeft.Minimum)
                {
                    bAddSession.Enabled = false;
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(17));
                    numUpDHoursLeft.Value = numUpDHoursLeft.Minimum;
                    numUpDMinutesLeft.Value = 0;
                }
                else
                {
                    bAddSession.Enabled = true;

                    numUpDHoursLeft.Value = t.Hours + t.Days * 24;
                    numUpDMinutesLeft.Value = t.Minutes;
                }
                _repeatCallOfMethodCounter = 0;
            }
            CheckDiscount();

        }
        private void CheckDiscount()
        {
            int discount = AddNewSessionController.AddNewSessionControllerInstance().GetDiscountSize(tbDiscountSize.Text);
            if (discount > 0)
            {
                var bonusMoney = numUpDPaidPrice.Value * discount / 100;
                var bonusTime = AddNewSessionController.AddNewSessionControllerInstance()
                    .UpdateTimeLeft(bonusMoney, cbPlaystationId.Text, 0, numUpDPaidPrice.Maximum, DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value));
                lPlusMoney.Text = @" + " + Math.Ceiling(bonusMoney).ToString(CultureInfo.InvariantCulture);

                lPlusTime.Text = @" + " + Math.Ceiling(bonusTime.TotalMinutes);

            }
            else
            {
                lPlusTime.Text = "";
                lPlusMoney.Text = "";
            }
        }

        private void numUpDHoursLeft_ValueChanged(object sender, EventArgs e)
        {
            _buttonPressCounter = 1;
            if (_repeatCallOfMethodCounter <= 0)
            {
                if (numUpDHoursLeft.Value <= 0)
                {
                    numUpDMinutesLeft.Minimum = 30;
                }
                else
                {
                    numUpDMinutesLeft.Minimum = 0;
                }
                _repeatCallOfMethodCounter++;
                decimal priceToPay = AddNewSessionController.AddNewSessionControllerInstance().UpdatePrice(cbPlaystationId.Text,
                    numUpDHoursLeft.Value,
                    numUpDMinutesLeft.Value, DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value));


                if (priceToPay > numUpDPaidPrice.Maximum)
                    numUpDPaidPrice.Value = numUpDPaidPrice.Maximum;
                else if (priceToPay < numUpDPaidPrice.Minimum)
                    numUpDPaidPrice.Value = numUpDPaidPrice.Minimum;
                else
                {
                    numUpDPaidPrice.Value = priceToPay;
                }
                _repeatCallOfMethodCounter = 0;
            }
            CheckDiscount();
        }

        private void numUpDMinutesLeft_ValueChanged(object sender, EventArgs e)
        {
            _buttonPressCounter = 1;
            if (_repeatCallOfMethodCounter <= 0)
            {
                _repeatCallOfMethodCounter++;
                if (numUpDHoursLeft.Value == 0)
                {
                    numUpDMinutesLeft.Minimum = 30;
                }
                else
                {
                    numUpDMinutesLeft.Minimum = 0;
                }

                if (numUpDMinutesLeft.Value > 59)
                {
                    numUpDMinutesLeft.Minimum = 0;
                    numUpDMinutesLeft.Value = 0;
                    numUpDHoursLeft.Value++;
                }

                decimal t = AddNewSessionController.AddNewSessionControllerInstance().UpdatePrice(cbPlaystationId.Text,
                    numUpDHoursLeft.Value, numUpDMinutesLeft.Value, DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value));
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
                _repeatCallOfMethodCounter = 0;
            }
            CheckDiscount();
           
        }

        private void tbDiscountSize_TextChanged(object sender, EventArgs e)
        {
            CheckDiscount();
        }

        private void cbPlaystationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            _buttonPressCounter = 1;
            if (TableIsAvailable())
            {
                SetDefaultPropertiesForFields();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(25));
            }
        }
        private bool TableIsAvailable()
        {
            return AddNewSessionController.AddNewSessionControllerInstance().CheckDoesConsoleExist(cbPlaystationId.Text);
        }
        private bool IsTimeIncludedIntoNightTime()
        {
            return DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value).Hour >= 0 && DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value).Hour <= 7;
        }

        private TimeSpan GetTimeUntil7()
        {
            if (new DateTime(DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value).Year, DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value).Month, DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value).Day, 7, 0, 0) > (DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value)))
                return (new DateTime(DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value).Year, DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value).Month, DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value).Day, 7, 0, 0) - (DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value)));

            return ((DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value)) - new DateTime(DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value).Year, DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value).Month, DateTime.Parse(DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+" "+ numUpDCurHour.Value + ":" + numUpDCurMinute.Value + ":" + numUpDCurTimeSeconds.Value).Day, 7, 0, 0));
        }

        private bool IsTimeNotExeed7Hours(TimeSpan time)
        {
            return time > TimeSpan.FromHours(1) && time < TimeSpan.FromHours(7);
        }

        private void cbNighTime_CheckedChanged(object sender, EventArgs e)
        {
            _buttonPressCounter = 0;
            if (cbNighTime.Checked)
            {
                tbDiscountCards.Enabled = false;
                tbDiscountCards.Text = @"0";
                tbDiscountCards.ReadOnly = true;
                if (IsTimeIncludedIntoNightTime())
                {
                    TimeSpan until7Am = GetTimeUntil7();
                    if (IsTimeNotExeed7Hours(until7Am))
                    {
                        _repeatCallOfMethodCounter = 5;
                        numUpDHoursLeft.Value = until7Am.Hours;
                        numUpDHoursLeft.Invalidate();
                        _repeatCallOfMethodCounter = 5;
                        numUpDMinutesLeft.Value = until7Am.Minutes;
                        numUpDMinutesLeft.Invalidate();
                        _repeatCallOfMethodCounter = 5;
                        numUpDPaidPrice.Minimum =
                            (decimal)DataBaseClass.Instancedb().GetNightTimePriceForPlaystation(cbPlaystationId.Text);
                        numUpDPaidPrice.Value = numUpDPaidPrice.Minimum;
                        numUpDPaidPrice.Maximum = numUpDPaidPrice.Minimum;
                        numUpDPaidPrice.Invalidate();
                        _repeatCallOfMethodCounter = 5;
                    }
                    else
                    {
                        MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(33) +
                                        until7Am.Hours +
                                        ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(34) +
                                        until7Am.Minutes +
                                        ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(35));
                        cbNighTime.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(36));
                    cbNighTime.Checked = false;
                }
            }
            else
            {
                tbDiscountCards.Enabled = true;
                tbDiscountCards.Text = @"0";
                tbDiscountCards.ReadOnly = false;
                SetDefaultPropertiesForFields();
            }
        }
        private void UpdatePlaystationList()
        {
            _repeatCallOfMethodCounter++;
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
            _repeatCallOfMethodCounter = 0;
        }
        private void bAddSession_Click(object sender, EventArgs e)
        {
            IsDiscountValid(tbDiscountCards.Text);
            CheckTable();
            UsualClientPriceChanged();
        }
        private void CheckTable()
        {
            if (string.IsNullOrEmpty(cbPlaystationId.Text) || !TableIsAvailable())
            {
                UpdatePlaystationList();
                SetDefaultPropertiesForFields();
            }
            //            else
            //            {
            //                
            ////                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(25));
            //            }
        }
        private void IsDiscountValid(string discountName)
        {
            if (!AddNewSessionController.AddNewSessionControllerInstance().CheckDoesClientExist(discountName))
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(50));
                SetDefaultPropertiesForFields();
            }
        }

        private bool AreBonusLablesEmpty(string lTime, string lMoney)
        {
            if (string.IsNullOrEmpty(lTime) || string.IsNullOrEmpty(lMoney)) return false;
            TimeSpan timeResult = StringToTime(lTime);
            double moneyResult = StringToDouble(lMoney);
            //            double.TryParse(lMoney, out moneyResult);
            if (timeResult.TotalSeconds > 0 && moneyResult > 0)
            {
                return true;
            }
            return false;
        }

        private TimeSpan StringToTime(string lTime)
        {
            string time = lTime.Substring(3);
            double result;
            double.TryParse(time, out result);
            return TimeSpan.FromMinutes(result);
        }
        private double StringToDouble(string lMoney)
        {
            //if(lMoney > 0)
            string money = lMoney.Substring(3);
            double result;
            double.TryParse(money, out result);
            return result;
        }

        private void tbDiscountCards_TextChanged(object sender, EventArgs e)
        {
            IsClientWithCardOrNot();
        }
        private void IsClientWithCardOrNot()
        {
        }

        private void tbDiscountCards_KeyPress(object sender, KeyPressEventArgs e)
        {
            _buttonPressCounter = 1;
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrWhiteSpace(tbDiscountCards.Text))
                {
                    var c =
                        AddNewSessionController.AddNewSessionControllerInstance().GetClientById(tbDiscountCards.Text);
                    if (c != null)
                    {
                        AddNewSessionModel.InstanceAddNewSessionModel().ClientId = tbDiscountCards.Text;
                        tbDiscountSize.Text = (c.pers_discount).ToString();
                        tbDiscountCards.Text = c.name;
                    }
                    else
                    {
                        MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(24));
                        tbDiscountCards.Text = Options.OptionsInstance().UsualClient;
                        tbDiscountCards.SelectAll();
                        cbPlaystationId.Focus();
                    }
                }
                else
                {
                    tbDiscountCards.Text = Options.OptionsInstance().UsualClient;
                    tbDiscountSize.Text = @"0";

                }
                //UPDATE FIELDS and STOP INPUT
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSetCurTime_Click(object sender, EventArgs e)
        {
            numUpDCurHour.Value = DateTime.Now.Hour;
            numUpDCurMinute.Value = DateTime.Now.Minute;
            numUpDCurTimeSeconds.Value = DateTime.Now.Second;

        }
    }
}
