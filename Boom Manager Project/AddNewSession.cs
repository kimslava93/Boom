using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.Models;
using LINQ_test.Driver;

namespace Boom_Manager_Project
{
    public partial class FAddNewSession : Form
    {
        private Point? _old;
        private int _repeatCallOfMethodCounter;
        private List<Endpoint> _endpoints;
        private List<Device> _allDevices;
        private readonly List<DevicesWithEndPoints> _devicesWithEndPointsList; 
//        private Device _device1;
        public FAddNewSession()
        {
            _devicesWithEndPointsList = new List<DevicesWithEndPoints>();
            _repeatCallOfMethodCounter = 0;
            InitializeComponent();
        }

        private void AddNewSession_Load(object sender, EventArgs e)
        {
            _allDevices = AddNewSessionController.AddNewSessionControllerInstance().GetDeviceListIPAddress();
//            _device1 = new Device(IPAddress.Parse("192.168.0.201"));
            
            foreach (Device d in _allDevices)
            {
                _endpoints = AddNewSessionController.AddNewSessionControllerInstance()
                    .LoadingOfEndPoints(d);
                _devicesWithEndPointsList.Add(new DevicesWithEndPoints(d, _endpoints));
            }
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

        private void SetDefaultPropertiesForFields()
        {
            if (cbNighTime.Checked)
            {
                _repeatCallOfMethodCounter = 5;
                numUpDPaidPrice.Value =
                    (decimal)DataBaseClass.Instancedb().GetNightTimePriceForPlaystation(cbPlaystationId.Text);
                numUpDPaidPrice.Invalidate();
                tbDiscountCards.Enabled = false;
                tbDiscountCards.Text = @"0";
                tbDiscountCards.ReadOnly = true;
            }
            else
            {
                _repeatCallOfMethodCounter += 2;
                numUpDHoursLeft.Value = 1;
                numUpDMinutesLeft.Value = 0;
                var t = AddNewSessionController.AddNewSessionControllerInstance()
                    .UpdatePrice(tbDiscountCards.Text, cbPlaystationId.Text, 1, 0);
                numUpDPaidPrice.Minimum = t;
                numUpDPaidPrice.Value = t;
            }
        }

//------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------When client will be able to keep money on card------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//            if (tbDiscountCards.Text == Options.OptionsInstance().UsualClient)
//            {
//                _repeatCallOfMethodCounter += 2;
//                numUpDHoursLeft.Value = 1;
//                numUpDMinutesLeft.Value = 0;
//                decimal t = AddNewSessionController.AddNewSessionControllerInstance().UpdatePrice(tbDiscountCards.Text, cbPlaystationId.Text, 1, 0);
//                numUpDPaidPrice.Minimum = t;
//                numUpDPaidPrice.Value = t;
//            }
//            else if (!String.IsNullOrWhiteSpace(tbDiscountCards.Text))
//            {
//                numUpDClientMoneyLeft.Value = numUpDClientMoneyLeft.Maximum;
//                numUpDHoursRemainedOnCard.Value = numUpDHoursRemainedOnCard.Maximum;
//                numUpDMinutesRemainedOnCard.Value = numUpDMinutesRemainedOnCard.Maximum;
//                TimeSpan paidTime = AddNewSessionController.AddNewSessionControllerInstance().UpdateTimeLeft(numUpDClientMoneyLeft.Value,
//                    cbPlaystationId.Text, numUpDClientMoneyLeft.Minimum, numUpDClientMoneyLeft.Maximum);
//                bAddSession.Enabled = true;
//                if (paidTime > TimeSpan.FromHours(1))
//                {
//                    numUpDHoursRemainedOnCard.Value = (paidTime.Days*24 + paidTime.Hours);
//                }
//                else
//                {
//                    bAddSession.Enabled = false;
//                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(15) +
//                                    tbDiscountCards.Text +
//                                    ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(16));
//                }
//            }
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------When client will be able to keep money on card------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------

//        }
        private void IsClientWithCardOrNot()
        {
            if (tbDiscountCards.Text == Options.OptionsInstance().UsualClient)
            {
                gbDepositPayment.Location = AddNewSessionController.AddNewSessionControllerInstance().ActiveLocation;
                gbDepositPayment.Enabled = true;
                gbClientInfo.Location = AddNewSessionController.AddNewSessionControllerInstance().PassiveLocation;
                gbClientInfo.Enabled = false;
                bAddDiscountCard.Enabled = true;
            }
            else
            {
                gbDepositPayment.Location = AddNewSessionController.AddNewSessionControllerInstance().ActiveLocation;
                gbDepositPayment.Enabled = true;
                gbClientInfo.Location = AddNewSessionController.AddNewSessionControllerInstance().PassiveLocation;
                gbClientInfo.Enabled = false;
                bAddDiscountCard.Enabled = false;
            }
            // in case when client will have savings on the card
//            else
//            {
//                gbClientInfo.Location = AddNewSessionController.AddNewSessionControllerInstance().ActiveLocation;
//                gbClientInfo.Enabled = true;
//                gbDepositPayment.Location = AddNewSessionController.AddNewSessionControllerInstance().PassiveLocation;
//                gbDepositPayment.Enabled = false;
//            }
        }

    

        private void numUpDHoursLeft_ValueChanged(object sender, EventArgs e)
        {
            if (_repeatCallOfMethodCounter <= 0)
            {
                _repeatCallOfMethodCounter++;
                decimal priceToPay = AddNewSessionController.AddNewSessionControllerInstance().UpdatePrice(tbDiscountSize.Text, cbPlaystationId.Text,
                    numUpDHoursLeft.Value,
                    numUpDMinutesLeft.Value);
                
                
                if (priceToPay > numUpDPaidPrice.Maximum)
                    numUpDPaidPrice.Value = numUpDPaidPrice.Maximum;
                else if (priceToPay < numUpDPaidPrice.Minimum)
                    numUpDPaidPrice.Value = numUpDPaidPrice.Minimum;
                else
                {
                    numUpDPaidPrice.Value = priceToPay;
                    
                }
            }
            CheckDiscount();
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
            CheckDiscount();
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
                decimal paidPrice = numUpDPaidPrice.Value;
                TimeSpan t = AddNewSessionController.AddNewSessionControllerInstance()
                    .UpdateTimeLeft(paidPrice, cbPlaystationId.Text, numUpDPaidPrice.Minimum, numUpDPaidPrice.Maximum);


                if (t.Hours > numUpDHoursLeft.Maximum)
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
                    numUpDHoursLeft.Value = t.Hours + t.Days*24;
                    numUpDMinutesLeft.Value = t.Minutes;
                }
            }
            CheckDiscount();
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
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(15) +
                                    tbDiscountCards.Text +
                                    ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(16));
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
            if (adcs.ClientID == Options.OptionsInstance().UsualClient || String.IsNullOrWhiteSpace(adcs.ClientID))
            {
                tbDiscountCards.Text = Options.OptionsInstance().UsualClient;//---------------------------------------------------------------CHECK IF THE ANY GENERAL FOR ALL CLIENTS DISCOUNT 
            }

            //-------in case when client will have money on the card!-------------------
//            else
//            {
//                var result = AddNewSessionController.AddNewSessionControllerInstance().AddNewClientToField(adcs.ClientID, tbDiscountCards.Text,
//                    tbClientName.Text, numUpDClientMoneyLeft.Value, adcs.ClientName, adcs.MoneyLeft);
//                if (result != null && result.Count != 0)
//                {
//                    tbDiscountCards.Text = result[0];
//                    tbClientName.Text = result[1];
//                    numUpDClientMoneyLeft.Minimum = decimal.Parse(result[2].Replace(".", ","));
//                    numUpDClientMoneyLeft.Maximum = decimal.Parse(result[2].Replace(".", ","));
//                    numUpDClientMoneyLeft.Value = decimal.Parse(result[2].Replace(".", ","));
//                }
//            }
            IsClientWithCardOrNot();
        }

       

        private void bAddSession_Click(object sender, EventArgs e)
        {
            CheckTable(); 
            UsualClientPriceChanged();
            if (tbDiscountCards.Text == Options.OptionsInstance().UsualClient)
            {
                TimeSpan paidTime =
                    TimeSpan.FromMinutes((double) numUpDHoursLeft.Value*60 + (double) numUpDMinutesLeft.Value);

                if (AddNewSessionController.AddNewSessionControllerInstance().CheckFieldsOnNull(cbPlaystationId.Text, tbDiscountCards.Text, paidTime,
                        (double) numUpDPaidPrice.Value))
                {
                    AddNewSessionController.AddNewSessionControllerInstance()
                        .AddNewDaySession(cbPlaystationId.Text, tbDiscountCards.Text, paidTime,
                            (double) numUpDPaidPrice.Value, DateTime.Now);
//                MessageBox.Show(numUpDPaidPrice.Value.ToString());
                    Close();
                }
                else
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(26));
                }
            }
            else if (tbDiscountCards.Text.Length > 2 && AreBonusLablesEmpty(lPlusTime.Text, lPlusMoney.Text))
            {
                TimeSpan paidTime =
                    TimeSpan.FromMinutes((double)numUpDHoursLeft.Value * 60 + (double)numUpDMinutesLeft.Value).Add(StringToTime(lPlusTime.Text));
                double paidMoney = (double) numUpDPaidPrice.Value + StringToDouble(lPlusMoney.Text);
                if (AddNewSessionController.AddNewSessionControllerInstance().CheckFieldsOnNull(cbPlaystationId.Text, tbDiscountCards.Text, paidTime,
                        paidMoney))
                {
                    AddNewSessionController.AddNewSessionControllerInstance()
                        .AddNewDaySession(cbPlaystationId.Text, tbDiscountCards.Text, paidTime,
                            paidMoney, DateTime.Now);
                    Close();
                }
                else
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(26));
                }



                //----When client will be able to store money on card
//                ClientPriceChanged();
//                TimeSpan paidTime =
//                    TimeSpan.FromMinutes((double)numUpDHoursRemainedOnCard.Value * 60 + (double)numUpDMinutesRemainedOnCard.Value);
//
//                AddNewSessionController.AddNewSessionControllerInstance().AddNewDaySession(cbPlaystationId.Text, tbDiscountCards.Text, paidTime,
//                    (double)numUpDClientMoneyLeft.Value, DateTime.Now);
//                Close();
            }

//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------When client will be able to keep money on card------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------

//            else if (!String.IsNullOrEmpty(tbDiscountCards.Text) && tbDiscountCards.Text.Length > 2)
//            {
//                ClientPriceChanged();
//                TimeSpan paidTime =
//                    TimeSpan.FromMinutes((double)numUpDHoursRemainedOnCard.Value * 60 + (double)numUpDMinutesRemainedOnCard.Value);
//
//                AddNewSessionController.AddNewSessionControllerInstance().AddNewDaySession(cbPlaystationId.Text, tbDiscountCards.Text, paidTime,
//                    (double)numUpDClientMoneyLeft.Value, DateTime.Now);
//                Close();
//            }
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------------------------------------------------------
            
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
            double result = 0;
            double.TryParse(time, out result);
            return TimeSpan.FromMinutes(result);
        }
        private double StringToDouble(string lMoney)
        {
            string money = lMoney.Substring(3);
            double result;
            double.TryParse(money, out result);
            return result;
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


        //Drag and drop form
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
        //-----------------------------------


        private void bAddMoneyToClient_Click(object sender, EventArgs e)
        {
//            var amd = new AddMoneyOnDiscountCard();
        }
        private void tbDiscountCards_TextChanged(object sender, EventArgs e)
        {
            IsClientWithCardOrNot();
        }
        private void tbDiscountCards_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                //UPDATE FIELDS and STOP INPUT
            }
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

        private void cbPlaystationId_TextChanged(object sender, EventArgs e)
        {
            if (TableIsAvailable())
            {
                SetDefaultPropertiesForFields();
            }
            else
            {
                cbPlaystationId.SelectedIndex = 0;
            }
        }

        private void tbDiscountCards_MouseClick(object sender, MouseEventArgs e)
        {
            tbDiscountCards.SelectAll();
        }

        private void tbDiscountSize_TextChanged(object sender, EventArgs e)
        {
            CheckDiscount();


            //            if (tbDiscountCards.Text != Options.OptionsInstance().UsualClient)
            //            {
            //                int disc =
            //                    AddNewSessionController.AddNewSessionControllerInstance().GetDiscountSize((tbDiscountSize.Text));
            //                if(disc > 0)
            //                {
            //                    var bonusMoney= t*disc/100;
            //                    lPlusMoney.Text = bonusMoney.ToString(CultureInfo.InvariantCulture);
            //
            //                    TimeSpan newTime = AddNewSessionController.AddNewSessionControllerInstance()
            //                        .UpdateTimeLeft(t, cbPlaystationId.Text, numUpDPaidPrice.Minimum, numUpDPaidPrice.Maximum);
            //                    lPlusTime.Text = newTime.ToString(newTime.Hours > 0 ? "HH:mm" : "mm");
            //
            //                    numUpDHoursLeft.Value = newTime.Hours;
            //                    numUpDMinutesLeft.Value = newTime.Minutes;
            //                }
            //            }




            //                if (tbDiscountSize.Text != "0%")
            //                {
            //                    var bonusMoney = paidPrice*AddNewSessionController.AddNewSessionControllerInstance()
            //                                     .GetDiscountSize(tbDiscountSize.Text)/100;
            //                    var bonusTime = AddNewSessionController.AddNewSessionControllerInstance()
            //                        .UpdateTimeLeft((paidPrice + bonusMoney), cbPlaystationId.Text, numUpDPaidPrice.Minimum,
            //                            numUpDPaidPrice.Maximum) - t;
            //
            //                }
//            lPlusMoney.Text

        }

        private void CheckDiscount()
        {
            int discount = AddNewSessionController.AddNewSessionControllerInstance().GetDiscountSize(tbDiscountSize.Text);
            if (discount > 0)
            {
                var bonusMoney = numUpDPaidPrice.Value * discount / 100;
                var bonusTime = AddNewSessionController.AddNewSessionControllerInstance()
                    .UpdateTimeLeft(bonusMoney, cbPlaystationId.Text, 0, numUpDPaidPrice.Maximum);
                lPlusMoney.Text = @" + " + Math.Round(bonusMoney, 0).ToString(CultureInfo.InvariantCulture);
//                if (bonusTime.Hours > 0)
//                {
////                    MessageBox.Show();
//                    lPlusTime.Text = @" + " + bonusTime.Hours + @":" + bonusTime.ToString("mm");
//                }
//                else
//                {
                    lPlusTime.Text = @" + " + Math.Round(bonusTime.TotalMinutes,0);
//                }
//                lPlusTime.Text = @" + " + bonusTime.ToString(bonusTime.Hours > 0 ? "HH:mm" : "mm");
            }
        }

        private bool IsTimeIncludedIntoNightTime()
        {
            return DateTime.Now.Hour > 0 && DateTime.Now.Hour < 7;
        }

        private TimeSpan GetTimeUntil7()
        {
            if (new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0) > (DateTime.Now))
                return (new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0) - (DateTime.Now));
            
                return ((DateTime.Now) - new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0));
        }

        private bool IsTimeNotExeed7Hours(TimeSpan time)
        {
            return time > TimeSpan.FromHours(1) && time < TimeSpan.FromHours(7);
        }

        private void cbNighTime_CheckedChanged(object sender, EventArgs e)
        {
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
                            (decimal) DataBaseClass.Instancedb().GetNightTimePriceForPlaystation(cbPlaystationId.Text);
                        numUpDPaidPrice.Value = numUpDPaidPrice.Minimum;
                        numUpDPaidPrice.Maximum = numUpDPaidPrice.Minimum;
                        numUpDPaidPrice.Invalidate();
                        gbDepositPayment.Enabled = false;
                        _repeatCallOfMethodCounter = 5;
                    }
                    else
                        MessageBox.Show("Time exeed 7 hours! \n Time until 7 am is " + until7Am.Hours + " hours and " +
                                        until7Am.Minutes + " minutes");
                }
                else
                {
                    MessageBox.Show("В данный момент невозможно включить ночной тариф!");
                    cbNighTime.Checked = false;
                }
            }
            else
            {
                tbDiscountCards.Enabled = true;
                tbDiscountCards.Text = @"0";
                tbDiscountCards.ReadOnly = false;
                gbDepositPayment.Enabled = true;
                SetDefaultPropertiesForFields();
            }
        }
    }
}
