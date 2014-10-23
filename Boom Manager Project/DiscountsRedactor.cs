using System;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;

namespace Boom_Manager_Project
{
    public partial class DiscountsRedactor : Form
    {
        public DiscountsRedactor()
        {
            InitializeComponent();
        }

        private void DiscountsRedactor_Load(object sender, EventArgs e)
        {
            SetDefaultCurrentDate();
        }

        private void bRequirementsContinue_Click(object sender, EventArgs e)
        {
            var t = new TimeSpan((int)numUpDHoursRequirement.Value, (int)numUpDMinutesRequirements.Value, (int)numUpDSecondsRequirements.Value);
            if (t.Equals(new TimeSpan()))
            {
                t = new TimeSpan();
            }

            DiscountRedactorController.InstanceDiscountRedactorController()
                .CreateNewRequirement(t, tbItemRequiredToBuy.Text, (int) numUpDNumOfItemsRequired.Value,
                    (double) numUpDMOneySumRequiredToPay.Value);
        }

        private void bBonusContinue_Click(object sender, EventArgs e)
        {
            var t = new TimeSpan((int)numUpDBonusHours.Value, (int)numUpDBonusMinutes.Value, (int)numUpDBonusSeconds.Value);
            if (t.Equals(new TimeSpan()))
            {
                t = new TimeSpan();
            }

            DiscountRedactorController.InstanceDiscountRedactorController()
                .CreateNewBonus(t, tbBonusItem.Text, (int)numUpDBonusNumOfItem.Value,
                    (double)numUpDBonusMoneySum.Value, (double)numUpBonusSumDiscount.Value);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nFinishPromoData_Click(object sender, EventArgs e)
        {
            var dtStart = new DateTime((int) numUpDStartYear.Value, GetMonthNum(ddStartMonth.Text),
                (int) numUpDStartDay.Value, (int) numUpDStartHour.Value, (int) numUpDStartMinute.Value,
                (int) numUpDStartSecond.Value);
            var dtEnd = new DateTime((int)numUpDEndYear.Value, GetMonthNum(ddEndMonth.Text),
                (int)numUpDEndDay.Value, (int)numUpDEndHour.Value, (int)numUpDEndMinute.Value,
                (int)numUpDEndSecond.Value);
            DiscountRedactorController.InstanceDiscountRedactorController()
                .CreateNewDiscount(tbDescription.Text, dtStart, dtEnd, cbCurrentState.Text, tbTimeZones.Text,
                    tbPLaystations.Text, cbAuditory.Text);
        }

        private int GetMonthNum(string month)
        {
            switch (month)
            {
                case "Январь":
                    return 1;
                case "Февраль":
                    return 2;
                case "Март":
                    return 3;
                case "Апрель":
                    return 4;
                case "Май":
                    return 5;
                case "Июнь":
                    return 6;
                case "Июль":
                    return 7;
                case "Август":
                    return 8;
                case "Сентябрь":
                    return 9;
                case "Октябрь":
                    return 10;
                case "Ноябрь":
                    return 11;
                case "Декабрь":
                    return 12;
            }
            return 0;
        }

        private void bAddRequirementItems_Click(object sender, EventArgs e)
        {
            tbItemRequiredToBuy.Text = DiscountRedactorController.InstanceDiscountRedactorController().OpenAddItemRequirements();
        }

        private void bAdItemsForBonus_Click(object sender, EventArgs e)
        {
            tbBonusItem.Text = DiscountRedactorController.InstanceDiscountRedactorController().OpenAddBonusItem();
        }

        private void SetDefaultCurrentDate()
        {
            DateTime t = DateTime.Now;
            numUpDStartDay.Value = t.Day;
            ddStartMonth.SelectedIndex = t.Month - 1;
            numUpDStartYear.Value = t.Year;
            numUpDStartHour.Value = t.Hour;
            numUpDStartMinute.Value = t.Minute;
            numUpDStartSecond.Value = t.Second;
        }

        private void bAddAvailableTimeZones_Click(object sender, EventArgs e)
        {
            tbTimeZones.Text = DiscountRedactorController.InstanceDiscountRedactorController().OpenAddAvailableTimezones();
        }

        private void bAddAvailablePLaystations_Click(object sender, EventArgs e)
        {
            tbPLaystations.Text = DiscountRedactorController.InstanceDiscountRedactorController().OpenAddAvailablePlaystations();
        }

        private void bOr_Click(object sender, EventArgs e)
        {
            tbBonusItem.Text += @"||" + DiscountRedactorController.InstanceDiscountRedactorController().OpenAddExchageableItems();
        }
    }

}
