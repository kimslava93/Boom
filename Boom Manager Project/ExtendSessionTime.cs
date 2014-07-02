using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    public partial class ExtendSessionTime : Form
    {
        private int _repeatCallOfMethodCounter;
        private Point? _old;
        private readonly DaySessionClass _sessionToExtend;
        public ExtendSessionTime(DaySessionClass sessionToExtend)
        {
            _sessionToExtend = sessionToExtend;
            InitializeComponent();
        }

        private void ExtendSessionTime_Load(object sender, EventArgs e)
        {
            SetPositionOfGb();
            FulFillTbs();
            CheckDiscount();
        }
//        private void CheckOnNightTime
        private void SetPositionOfGb()
        {
            //if (_sessionToExtend.Клиент == @"Usual Client")//Options.OptionsInstance().UsualClient)
            //{
                gbExtendUsualClient.Location =
                    ExtendSessionTimeController.ExtendSessionTimeControllerInstance().VisibleLocation;
                gbExtendWithCard.Location =
                    ExtendSessionTimeController.ExtendSessionTimeControllerInstance().HiddenLocation;
            //}
            //else if(!string.IsNullOrWhiteSpace(_sessionToExtend.Клиент))
            //{
            //    gbExtendUsualClient.Location =
            //        ExtendSessionTimeController.ExtendSessionTimeControllerInstance().VisibleLocation;
            //    gbExtendWithCard.Location =
            //        ExtendSessionTimeController.ExtendSessionTimeControllerInstance().HiddenLocation;
                //gbExtendUsualClient.Location =
                //    ExtendSessionTimeController.ExtendSessionTimeControllerInstance().HiddenLocation;
                //gbExtendWithCard.Location =
                //    ExtendSessionTimeController.ExtendSessionTimeControllerInstance().VisibleLocation;
            //}
        }

        private void FulFillTbs()
        {
            tbSessionID.Text = _sessionToExtend.Сессия.ToString(CultureInfo.InvariantCulture);
            tbDiscountCards.Text = _sessionToExtend.Клиент;

            numUpDMinutesExtend.Value = 30; //minimum is 30 minutes
            numUpDMoneyExtend.Minimum = AddNewSessionController.AddNewSessionControllerInstance()
                .UpdatePrice(Options.OptionsInstance().UsualClient, _sessionToExtend.Приставка, 0, 30,
                    _sessionToExtend.Конец);
                //minimum price is 30 minutes
            tbEndTimeWas.Text = _sessionToExtend.Конец.ToString("dd-MMMM HH:mm");
            if (_sessionToExtend.Клиент != @"Usual Client" && !string.IsNullOrEmpty(_sessionToExtend.Клиент)) //Options.OptionsInstance().UsualClient)
            {
                tbDiscountSize.Text =
                    ExtendSessionTimeController.ExtendSessionTimeControllerInstance()
                        .GetClientsDiscountInfoBySessionId(_sessionToExtend.Сессия)
                        .ToString(CultureInfo.InvariantCulture);
            }
            //else
            //{
            //    dgvClientsPerTable.DataSource =
            //        ExtendSessionTimeController.ExtendSessionTimeControllerInstance()
            //            .GetClientsTable(_sessionToExtend.Сессия);
            //    dgvClientsPerTable.Invalidate();
            //}
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bApply_Click(object sender, EventArgs e)
        {
//            if (tbEndTimeWas.Text != tbEndTimeWill.Text)

            if(tbDiscountCards.Text == @"Usual Client"/*Options.OptionsInstance().UsualClient*/)
            {
               ExtendSessionTimeController.ExtendSessionTimeControllerInstance()
                    .ExtendTimeForSession(_sessionToExtend, (int) numUpDHoursExtend.Value,
                        (int) numUpDMinutesExtend.Value, (double) numUpDMoneyExtend.Value);
            }
            else if (tbDiscountCards.Text.Length > 2 && AreBonusLablesEmpty(lPlusTime.Text, lPlusMoney.Text))
            {
                TimeSpan paidTime =
                   TimeSpan.FromMinutes((double)numUpDHoursExtend.Value * 60 + (double)numUpDMinutesExtend.Value).Add(StringToTime(lPlusTime.Text));
                double paidMoney = (double)numUpDMoneyExtend.Value + StringToDouble(lPlusMoney.Text);
                ExtendSessionTimeController.ExtendSessionTimeControllerInstance()
                    .ExtendTimeForSession(_sessionToExtend, paidTime.Hours,
                        paidTime.Minutes, paidMoney);
            }
            Close();

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
        private void CheckDiscount()
        {
            int discount = AddNewSessionController.AddNewSessionControllerInstance().GetDiscountSize(tbDiscountSize.Text);
            if (discount > 0)
            {
                var bonusMoney = numUpDMoneyExtend.Value * discount / 100;
                var bonusTime = AddNewSessionController.AddNewSessionControllerInstance()
                    .UpdateTimeLeft(bonusMoney, _sessionToExtend.Приставка, 0, numUpDMoneyExtend.Maximum);
                lPlusMoney.Text = @" + " + Math.Round(bonusMoney, 0).ToString(CultureInfo.InvariantCulture);
                //                if (bonusTime.Hours > 0)
                //                {
                ////                    MessageBox.Show();
                //                    lPlusTime.Text = @" + " + bonusTime.Hours + @":" + bonusTime.ToString("mm");
                //                }
                //                else
                //                {
                lPlusTime.Text = @" + " + Math.Round(bonusTime.TotalMinutes, 0);
                //                }
                //                lPlusTime.Text = @" + " + bonusTime.ToString(bonusTime.Hours > 0 ? "HH:mm" : "mm");
            }
            else
            {
                lPlusTime.Text = "";
                lPlusMoney.Text = "";
            }
        }
        private void numUpDHoursExtend_ValueChanged(object sender, EventArgs e)
        {
            numUpDMinutesExtend.Minimum = numUpDHoursExtend.Value == 0 ? 30 : 0;
            if (_repeatCallOfMethodCounter <= 0)
            {
                _repeatCallOfMethodCounter++;
                decimal t = AddNewSessionController.AddNewSessionControllerInstance().UpdatePrice(Options.OptionsInstance().UsualClient, _sessionToExtend.Приставка,
                    numUpDHoursExtend.Value,
                    numUpDMinutesExtend.Value, DateTime.Now);
                if (t > numUpDMoneyExtend.Maximum)
                    numUpDMoneyExtend.Value = numUpDMoneyExtend.Maximum;
                else if (t < numUpDMoneyExtend.Minimum)
                    numUpDMoneyExtend.Value = numUpDMoneyExtend.Minimum;
                else
                    numUpDMoneyExtend.Value = t;
            }
            UpdateEndTime();
            CheckDiscount();
            _repeatCallOfMethodCounter = 0;
        }

        private void numUpDMinutesExtend_ValueChanged(object sender, EventArgs e)
        {
            numUpDMinutesExtend.Minimum = numUpDHoursExtend.Value == 0 ? 30 : 0;
            if (_repeatCallOfMethodCounter <= 0)
            {
                if (numUpDMinutesExtend.Value > 59)
                {
                    numUpDMinutesExtend.Value = 0;
                    numUpDHoursExtend.Value++;
                }
                _repeatCallOfMethodCounter++;
                decimal t = AddNewSessionController.AddNewSessionControllerInstance().UpdatePrice(Options.OptionsInstance().UsualClient, _sessionToExtend.Приставка,
                    numUpDHoursExtend.Value, numUpDMinutesExtend.Value, DateTime.Now);
                if (t < numUpDMoneyExtend.Minimum)
                {
                    numUpDMoneyExtend.Value = numUpDMoneyExtend.Minimum;
                }
                else if (t > numUpDMoneyExtend.Maximum)
                {
                    numUpDMoneyExtend.Value = numUpDMoneyExtend.Maximum;
                }
                else
                {
                    numUpDMoneyExtend.Value = t;
                }
            }
            UpdateEndTime();
            CheckDiscount();
            _repeatCallOfMethodCounter = 0;
        }

        private void numUpDMoneyExtend_ValueChanged(object sender, EventArgs e)
        {
            if (numUpDMoneyExtend.Value > numUpDMoneyExtend.Minimum)
            {
                UsualClientPriceChanged();
            }
            else
            {
                numUpDMoneyExtend.Value = numUpDMoneyExtend.Minimum;
            }
        }

        private void UsualClientPriceChanged()
        {
            if (_repeatCallOfMethodCounter <= 0)
            {
                _repeatCallOfMethodCounter++;
                TimeSpan t =
                    AddNewSessionController.AddNewSessionControllerInstance()
                        .UpdateTimeLeft(numUpDMoneyExtend.Value, _sessionToExtend.Приставка,
                            numUpDMoneyExtend.Minimum, numUpDMoneyExtend.Maximum);
                if (t.Hours > numUpDHoursExtend.Maximum)
                {
//                    bApply.Enabled = true;
                    numUpDHoursExtend.Value = numUpDHoursExtend.Maximum;
                    numUpDMinutesExtend.Value = 0;
                }
                else if (t.Hours < numUpDHoursExtend.Minimum)
                {
//                    bApply.Enabled = false;
                    MessageBox.Show("Insufficient money to play minimum one hour!");
                    numUpDHoursExtend.Value = numUpDHoursExtend.Minimum;
                    numUpDMinutesExtend.Value = 0;
                }
                else
                {
//                    if (t.Minutes == 30 && t.Hours == 0)
//                    {
//                        numUpDMoneyExtend.Minimum = numUpDMoneyExtend.Value;
//                    }
//                    bApply.Enabled = true;
                    numUpDHoursExtend.Value = t.Hours + t.Days * 24;
                    numUpDMinutesExtend.Value = t.Minutes;
                }
            }
            _repeatCallOfMethodCounter = 0;
        }

        private void UpdateEndTime()
        {
            tbEndTimeWill.Text = (_sessionToExtend.Конец.Add(
                TimeSpan.FromHours((int) numUpDHoursExtend.Value).Add(+
                    TimeSpan.FromMinutes((int) numUpDMinutesExtend.Value)))).ToString(
                        "dd-MMMM HH:mm");
        }

        private void bAddMoney_Click(object sender, EventArgs e)
        {
            if (dgvClientsPerTable.CurrentRow != null)
            {
                ExtendSessionTimeController.ExtendSessionTimeControllerInstance()
                    .AddMoney((string) dgvClientsPerTable.CurrentRow.Cells[0].Value);
                ExtendSessionTimeController.ExtendSessionTimeControllerInstance().UpdatePrices(_sessionToExtend);
                Close();

            }
        }

        private void ExtendSessionTime_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void ExtendSessionTime_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void ExtendSessionTime_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }

        private void gbExtendUsualClient_Enter(object sender, EventArgs e)
        {

        }

      
    }
}
