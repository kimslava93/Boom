using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;
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
            if (CheckTableAvailability())
            {
                SetDefaultPropertiesForFields();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(25));
            }
        }

        private bool CheckTableAvailability()
        {
            return AddNewSessionController.AddNewSessionControllerInstance().CheckDoesConsoleExist(cbPlaystationId.Text);
        }

        private void SetDefaultPropertiesForFields()
        {
            if (tbDiscountCards.Text == @"0")
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
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(15) +
                                    tbDiscountCards.Text +
                                    ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(16));
                }
            }
        }
        private void IsClientWithCardOrNot()
        {
            if (tbDiscountCards.Text == @"0")
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
                decimal paidPrice = numUpDPaidPrice.Value;
                if (tbDiscountSize.Text != @"0%")
                {
                    paidPrice += paidPrice*
                                 AddNewSessionController.AddNewSessionControllerInstance()
                                     .GetDiscountSize(tbDiscountSize.Text)/100;
                }
                TimeSpan t = AddNewSessionController.AddNewSessionControllerInstance().UpdateTimeLeft(paidPrice, cbPlaystationId.Text, numUpDPaidPrice.Minimum, numUpDPaidPrice.Maximum);
                
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
            if (adcs.ClientID == "0" || String.IsNullOrWhiteSpace(adcs.ClientID))
            {
                tbDiscountCards.Text = @"0";//--------------------------------------------------------------------------------------CHECK IF THE ANY GENERAL FOR ALL CLIENTS DISCOUNT 
            }

            //in case when client will have money on the card!
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
            if (tbDiscountCards.Text == @"0")
            {
                UsualClientPriceChanged();
                TimeSpan paidTime =
                    TimeSpan.FromMinutes((double) numUpDHoursLeft.Value*60 + (double) numUpDMinutesLeft.Value);

                if (AddNewSessionController.AddNewSessionControllerInstance()
                    .CheckFieldsOnNull(cbPlaystationId.Text, tbDiscountCards.Text, paidTime,
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
            else if (!String.IsNullOrEmpty(tbDiscountCards.Text) && tbDiscountCards.Text.Length > 2)
            {
                ClientPriceChanged();
                TimeSpan paidTime =
                    TimeSpan.FromMinutes((double)numUpDHoursRemainedOnCard.Value * 60 + (double)numUpDMinutesRemainedOnCard.Value);

                AddNewSessionController.AddNewSessionControllerInstance().AddNewDaySession(cbPlaystationId.Text, tbDiscountCards.Text, paidTime,
                    (double)numUpDClientMoneyLeft.Value, DateTime.Now);
                Close();
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

        private void bAddMoneyToClient_Click(object sender, EventArgs e)
        {
//            var amd = new AddMoneyOnDiscountCard();
        }
        private void tbDiscountCards_TextChanged(object sender, EventArgs e)
        {
            IsClientWithCardOrNot();

            //            SetDefaultPropertiesForFields();
        }
        private void tbDiscountCards_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
//                MessageBox.Show(@"Enter pressed!");
                if (!string.IsNullOrWhiteSpace(tbDiscountCards.Text))
                {
                    var c =
                        AddNewSessionController.AddNewSessionControllerInstance().GetClientById(tbDiscountCards.Text);
                    if (c != null)
                    {
                        tbDiscountSize.Text = (c.pers_discount).ToString();
                        tbDiscountCards.Text = c.name;

//                        MessageBox.Show(c.name);
                    }
                    else
                    {
                        MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(24));
                        tbDiscountCards.Text = @"0";
                        tbDiscountCards.SelectAll();
                        cbPlaystationId.Focus();
                    }
                }
                //UPDATE FIELDS and STOP INPUT
            }
        }

        private void CheckTable()
        {
            if (!string.IsNullOrEmpty(cbPlaystationId.Text) && CheckTableAvailability())
            {
                SetDefaultPropertiesForFields();
            }
            else
            {
                UpdatePlaystationList();
//                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(25));
            }
        }

        private void cbPlaystationId_TextChanged(object sender, EventArgs e)
        {
            if (CheckTableAvailability())
            {
                SetDefaultPropertiesForFields();
            }
            else
            {
                cbPlaystationId.Text = "";
            }
        }

        private void tbDiscountCards_MouseClick(object sender, MouseEventArgs e)
        {
            tbDiscountCards.SelectAll();
        }
    }
}
