using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.HardwareConnectionDriver;
using Boom_Manager_Project.Models;

namespace Boom_Manager_Project
{
    public partial class FAddNewSession : Form
    {
        private Point? _old;
        private int _repeatCallOfMethodCounter;
        private List<Endpoint> _endpoints;
        private List<Device> _allDevices;
        private static readonly TimeSpan MinimumTime = new TimeSpan(0, 0, 30, 0);
        private int _buttonPressCounter = 1;
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
            Options.OptionsInstance().TakeScreenShot();
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
            _buttonPressCounter = 1;
            if (TableIsAvailable())
            {
                Options.OptionsInstance().TakeScreenShot();
                SetDefaultPropertiesForFields();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(25));
                Options.OptionsInstance().TakeScreenShot();
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
                TextFileWriter.TextFileWriterInstance()
                  .AddSomeDataToLogReport(
                      "В форме \"Добавить сессию\" были загружены дефолтовые значения для ночного пакета.",
                      Options.FileTypeActionsLogs);
            }
            else
            {
                _repeatCallOfMethodCounter = 2;
//                numUpDHoursLeft.Minimum = 1;//MinimumTime.Hours;
                numUpDHoursLeft.Value = 1;//MinimumTime.Hours;
                numUpDMinutesLeft.Minimum = 0;//MinimumTime.Minutes;
                numUpDMinutesLeft.Value = 0;//MinimumTime.Minutes;
                var t = AddNewSessionController.AddNewSessionControllerInstance()
                    .UpdatePrice( cbPlaystationId.Text, 1, 0,DateTime.Now);
                var minimum = AddNewSessionController.AddNewSessionControllerInstance()
                    .UpdatePrice(cbPlaystationId.Text, MinimumTime.Hours, MinimumTime.Minutes, DateTime.Now);
                tbDiscountCards.Enabled = true;
                tbDiscountCards.Text = @"0";
                tbDiscountSize.Text = @"0";
                tbDiscountCards.ReadOnly = false;
                numUpDPaidPrice.Minimum = minimum;
                numUpDPaidPrice.Maximum = 18900;
                numUpDPaidPrice.Value = t;
                _repeatCallOfMethodCounter = 0;
                TextFileWriter.TextFileWriterInstance()
                    .AddSomeDataToLogReport(
                        "В форме \"Добавить сессию\" были загружены дефолтовые значения.",
                        Options.FileTypeActionsLogs);
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
                TextFileWriter.TextFileWriterInstance()
                    .AddSomeDataToLogReport(
                        "В форме \"Добавить сессию\" было загружено клиент с карточкой.",
                        Options.FileTypeActionsLogs);
            }
            else
            {
                gbDepositPayment.Location = AddNewSessionController.AddNewSessionControllerInstance().ActiveLocation;
                gbDepositPayment.Enabled = true;
                gbClientInfo.Location = AddNewSessionController.AddNewSessionControllerInstance().PassiveLocation;
                gbClientInfo.Enabled = false;
                bAddDiscountCard.Enabled = false;
                TextFileWriter.TextFileWriterInstance()
                    .AddSomeDataToLogReport(
                        "В форме \"Добавить сессию\" было загружено обычный клиент.",
                        Options.FileTypeActionsLogs);
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
            _buttonPressCounter = 1;
            Options.OptionsInstance().TakeScreenShot();
            if (_repeatCallOfMethodCounter <= 0)
            {
                TextFileWriter.TextFileWriterInstance()
                    .AddSomeDataToLogReport(
                        "В форме \"Добавить сессию\" в поле \"Остаток часов\" было введено ",
                        Options.FileTypeActionsLogs);
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
                    numUpDMinutesLeft.Value,DateTime.Now);
                
                
                if (priceToPay > numUpDPaidPrice.Maximum)
                    numUpDPaidPrice.Value = numUpDPaidPrice.Maximum;
                else if (priceToPay < numUpDPaidPrice.Minimum)
                    numUpDPaidPrice.Value = numUpDPaidPrice.Minimum;
                else
                {
                    numUpDPaidPrice.Value = priceToPay;
                    TextFileWriter.TextFileWriterInstance()
                        .AddSomeDataToLogReport(
                            "Данные " + priceToPay + " в форме \"Добавить сессию\"  в поле \"Оплачено\" были введены.",
                            Options.FileTypeActionsLogs);
                    Options.OptionsInstance().TakeScreenShot();
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
                TextFileWriter.TextFileWriterInstance()
                    .AddSomeDataToLogReport(
                        "Данные " + numUpDMinutesLeft.Value +
                        " в форме \"Добавить сессию\"  в поле \"Остаток минут\" были введены.",
                        Options.FileTypeActionsLogs);
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
                    numUpDHoursLeft.Value, numUpDMinutesLeft.Value,DateTime.Now);
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
                    TextFileWriter.TextFileWriterInstance()
                        .AddSomeDataToLogReport(
                            "Данные " + t +
                            " в форме \"Добавить сессию\"  в поле \"Оплачено\" были введены.",
                            Options.FileTypeActionsLogs);

                } 
                _repeatCallOfMethodCounter = 0;
            }
            CheckDiscount();
           
        }

        private void numUpDPaidPrice_ValueChanged(object sender, EventArgs e)//without card
        {
            _buttonPressCounter = 1;
            Options.OptionsInstance().TakeScreenShot();
            if (numUpDPaidPrice.Value >= numUpDPaidPrice.Maximum || numUpDPaidPrice.Value < numUpDPaidPrice.Minimum ||
                double.IsInfinity((double) numUpDPaidPrice.Value))
            {
               // MessageBox.Show("NOT");
                TextFileWriter.TextFileWriterInstance()
                    .AddSomeDataToLogReport(
                        "Данные " + numUpDPaidPrice.Value + " в форме \"Добавить сессию\" были введены данные в поле \"Оплачено\".",
                        Options.FileTypeActionsLogs);
                SetDefaultPropertiesForFields();
            }
            UsualClientPriceChanged();
            Options.OptionsInstance().TakeScreenShot();
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
                    .UpdateTimeLeft(paidPrice, cbPlaystationId.Text, numUpDPaidPrice.Minimum, numUpDPaidPrice.Maximum, DateTime.Now);

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
                    
                    numUpDHoursLeft.Value = t.Hours + t.Days*24;
                    numUpDMinutesLeft.Value = t.Minutes;
                    TextFileWriter.TextFileWriterInstance()
                        .AddSomeDataToLogReport(
                            "Данные " + numUpDPaidPrice.Value +
                            " в форме \"Добавить сессию\" были введены данные в поле \"Оплачено\".",
                            Options.FileTypeActionsLogs);
                }
                _repeatCallOfMethodCounter = 0;
            }
            CheckDiscount();
            
        }

        private void ClientPriceChanged()
        {
            if (_repeatCallOfMethodCounter <= 0)
            {
                _repeatCallOfMethodCounter++;
                TimeSpan t = AddNewSessionController.AddNewSessionControllerInstance().UpdateTimeLeft(numUpDClientMoneyLeft.Value,
                    cbPlaystationId.Text, numUpDClientMoneyLeft.Minimum, numUpDClientMoneyLeft.Maximum, DateTime.Now);
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
                    TextFileWriter.TextFileWriterInstance()
                  .AddSomeDataToLogReport(
                      "Данные " + numUpDPaidPrice.Value + " в форме \"Добавить сессию\" были введены данные в поле \"Оплачено\".",
                      Options.FileTypeActionsLogs);
                }
            }
            _repeatCallOfMethodCounter = 0;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
//            TextFileWriter.TextFileWriterInstance().AddSomeDataToLogReport("");
            TextFileWriter.TextFileWriterInstance()
                  .AddSomeDataToLogReport(
                      "Кнопка \"Закрыть\" в форме \"Добавить сессию\" была нажата.",
                      Options.FileTypeActionsLogs);
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


//        private void ValidateFields()
//        {
//            var time = new TimeSpan((int)numUpDHoursExtend.Value / 24, (int)numUpDHoursExtend.Value % 24, (int)numUpDMinutesExtend.Value, 0);
//            var paidTime =
//                AddNewSessionController.AddNewSessionControllerInstance()
//                    .UpdateTimeLeft(numUpDMoneyExtend.Value, _sessionToExtend.Приставка, 0, 18900);
//            if (time != paidTime)
//            {
//                numUpDHoursExtend.Value = paidTime.Hours;
//                numUpDMinutesExtend.Value = paidTime.Minutes;
//            }
//        }
        private void bAddSession_Click(object sender, EventArgs e)
        {
            if (_buttonPressCounter-- <= 0)
            {
                if (tbDiscountCards.Text == Options.OptionsInstance().UsualClient || tbDiscountCards.Text == @"Usual Client")
                {
                    TimeSpan paidTime =
                        TimeSpan.FromMinutes((double) numUpDHoursLeft.Value*60 + (double) numUpDMinutesLeft.Value);

                    if (AddNewSessionController.AddNewSessionControllerInstance()
                        .CheckFieldsOnNull(cbPlaystationId.Text, tbDiscountCards.Text, paidTime,
                            (double) numUpDPaidPrice.Value))
                    {
                        AddNewSessionController.AddNewSessionControllerInstance()
                            .AddNewDaySession(cbPlaystationId.Text, tbDiscountCards.Text, 0, paidTime,
                                (double) numUpDPaidPrice.Value, DateTime.Now);
                        TextFileWriter.TextFileWriterInstance()
                            .AddSomeDataToLogReport(
                                "В форме \"Добавить сессию\" были введены данные в поле Оплачено = " +
                                numUpDPaidPrice.Value + " сом. Оплаченное время = " + paidTime + ", на приставку " +
                                cbPlaystationId.Text + ", с Карточкой " + tbDiscountCards.Text,
                                Options.FileTypeActionsLogs);
                        Options.OptionsInstance().TakeScreenShot();
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
                        TimeSpan.FromMinutes((double) numUpDHoursLeft.Value*60 + (double) numUpDMinutesLeft.Value)
                            .Add(StringToTime(lPlusTime.Text));
                    double paidMoney = (double) numUpDPaidPrice.Value + StringToDouble(lPlusMoney.Text);
                    if (AddNewSessionController.AddNewSessionControllerInstance()
                        .CheckFieldsOnNull(cbPlaystationId.Text, tbDiscountCards.Text, paidTime,
                            paidMoney))
                    {
                        AddNewSessionController.AddNewSessionControllerInstance()
                            .AddNewDaySession(cbPlaystationId.Text, tbDiscountCards.Text,
                                StringToDouble(lPlusMoney.Text),
                                paidTime,
                                paidMoney, DateTime.Now);
                        TextFileWriter.TextFileWriterInstance()
                            .AddSomeDataToLogReport(
                                "В форме \"Добавить сессию\" были введены данные в поле Оплачено = " +
                                numUpDPaidPrice.Value + " сом. Оплаченное время = " + paidTime + ", на приставку " +
                                cbPlaystationId.Text + ", с Карточкой " + tbDiscountCards.Text,
                                Options.FileTypeActionsLogs);
                        Options.OptionsInstance().TakeScreenShot();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(26));
                    }
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
            else
            {
                Options.OptionsInstance().TakeScreenShot();
                IsDiscountValid(tbDiscountCards.Text);
                CheckTable();
//                if ((tbDiscountCards.Text.Length > 2 && AreBonusLablesEmpty(lPlusTime.Text, lPlusMoney.Text)))
//                {
//                    ClientPriceChanged();
//                }
//                else if (tbDiscountCards.Text == Options.OptionsInstance().UsualClient)
//                {
                    UsualClientPriceChanged();
//                }
                Options.OptionsInstance().TakeScreenShot();
                
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
            _buttonPressCounter = 1;
            IsClientWithCardOrNot();
//            Options.OptionsInstance().TakeScreenShot();
        }
        private void tbDiscountCards_KeyPress(object sender, KeyPressEventArgs e)
        {
            _buttonPressCounter = 1;
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrWhiteSpace(tbDiscountCards.Text))
                {
                    TextFileWriter.TextFileWriterInstance()
                        .AddSomeDataToLogReport(
                            "В форме \"Добавить сессию\" было заполнено поле \"Скидка\" " +tbDiscountCards.Text+ ", и выбита скидка в размере " +tbDiscountSize.Text+"%",
                            Options.FileTypeActionsLogs);
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
            TextFileWriter.TextFileWriterInstance()
                .AddSomeDataToLogReport(
                    "В форме \"Добавить сессию\" было нажато поле \"Скидка\" ",
                    Options.FileTypeActionsLogs);
        }

        private void tbDiscountSize_TextChanged(object sender, EventArgs e)
        {
            CheckDiscount();
            Options.OptionsInstance().TakeScreenShot();

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
                    .UpdateTimeLeft(bonusMoney, cbPlaystationId.Text, 0, numUpDPaidPrice.Maximum, DateTime.Now);
                lPlusMoney.Text = @" + " + Math.Ceiling(bonusMoney).ToString(CultureInfo.InvariantCulture);
//                if (bonusTime.Hours > 0)
//                {
////                    MessageBox.Show();
//                    lPlusTime.Text = @" + " + bonusTime.Hours + @":" + bonusTime.ToString("mm");
//                }
//                else
//                {
                    lPlusTime.Text = @" + " + Math.Ceiling(bonusTime.TotalMinutes);
//                }
//                lPlusTime.Text = @" + " + bonusTime.ToString(bonusTime.Hours > 0 ? "HH:mm" : "mm");
            }
            else
            {
                lPlusTime.Text = "";
                lPlusMoney.Text = "";
            }
        }

        private bool IsTimeIncludedIntoNightTime()
        {
            return DateTime.Now.Hour >= 0 && DateTime.Now.Hour <= 7;
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
                            (decimal) DataBaseClass.Instancedb().GetNightTimePriceForPlaystation(cbPlaystationId.Text);
                        numUpDPaidPrice.Value = numUpDPaidPrice.Minimum;
                        numUpDPaidPrice.Maximum = numUpDPaidPrice.Minimum;
                        numUpDPaidPrice.Invalidate();
                        gbDepositPayment.Enabled = false;
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
                gbDepositPayment.Enabled = true;
                SetDefaultPropertiesForFields();
            }
            Options.OptionsInstance().TakeScreenShot();
        }

        private void numUpDPaidPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bAddSession.Focus();
            }
        }
    }
}
