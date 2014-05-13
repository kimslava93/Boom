using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.Models;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project
{
    class AddNewSessionController
    {
        public readonly Point ActiveLocation = new Point(12, 138);
        public readonly Point PassiveLocation = new Point(388, 150);
//        private readonly int _dailyId;
//        private bool _opTable;
//        private int _repeatCallOfMethodCounter;
        private readonly AddNewSessionModel _addNewSessionModel;
        private static AddNewSessionController _addNewSessionController;

        public static AddNewSessionController AddNewSessionControllerInstance()
        {
            return _addNewSessionController ?? (_addNewSessionController = new AddNewSessionController());
        }

        public AddNewSessionController()
        {
            _addNewSessionModel = new AddNewSessionModel();
        }

        public string WarningMessages(string type)
        {
            if (type == "NoFreePlaces")
            {
                return "There is no available free consoles. Sorry for that!";
            }
            if (type == "TimeZoePriceError")
            {
                return "Probably that the price of this playstation is lower than 0.\n" +
                       "To solve this problem you need to change price of this table in the Timezone redactor!";
            }
            if (type == "UpdateTimeError")
            {
                return "Error occured during updating paid time values!";
            }
            return "";
        }

        public List<tables_t> GetAllFreeTablesId()
        {
            List<tables_t> allFreeTables = _addNewSessionModel.GetAllFreeTables();
            return allFreeTables;
        }

        public string StartTimer()
        {
            _addNewSessionModel.CurrentDateTime = DateTime.Now;
            return _addNewSessionModel.CurrentDateTime.ToString("HH:mm:ss");
        }
        public string StartDate()
        {
            _addNewSessionModel.CurrentDateTime = DateTime.Now;
            return _addNewSessionModel.CurrentDateTime.ToString("dd MMMM");
        }

        public decimal UpdatePrice(string discountCard, string playstationId, decimal hoursLeft, decimal minutesLeft)
        {
            var currentDateTime = DateTime.Now;
            if (hoursLeft < 0 || minutesLeft < 0)
            {
                return 0;
            }
//            if (discountCard == "0")
//            {
                if (hoursLeft >= 0 || minutesLeft >= 0)
                {
                    var toPlay = new TimeSpan((int)hoursLeft / 24, (int)hoursLeft - ((int)hoursLeft / 24) * 24, (int)minutesLeft, 0);
                    var price = _addNewSessionModel.GetSumToPay(playstationId, toPlay, currentDateTime);
                    if (price < 0)
                    {
                        return 0;
                    }
                    return Math.Round((decimal) price, 2);
                }
//            }
//            else
//            {
//                if (hoursLeft >= 0 || minutesLeft >= 0)
//                {
//                    var toPlay = new TimeSpan((int) hoursLeft/24, (int) hoursLeft - ((int) hoursLeft/24)*24,
//                        (int) minutesLeft, 0);
//
//                    double price = _addNewSessionModel.GetSumToPay(playstationId, toPlay, currentDateTime);
//                    return Math.Round((decimal) price, 2);
//                }
//            }
            return 0;
        }

        public TimeSpan UpdateTimeLeft(decimal priceValue, string playstationId, decimal minimumValue,
            decimal maximumValue)
        {
            if (!CheckOnNormalPrice(priceValue, minimumValue, maximumValue))
            {
                priceValue = minimumValue;
            }
            TimeSpan result = UpdateRemainedTimeOnPaidPriceChanged((double) priceValue, playstationId);
            return result;
        }

        private bool CheckOnNormalPrice(decimal priceToCheck, decimal minimum, decimal maximum)
        {
            if (priceToCheck > maximum ||
                priceToCheck < minimum)
            {
                return false;
            }
            return true;
        }

        private TimeSpan UpdateRemainedTimeOnPaidPriceChanged(double remainedMoney, string playstationId)
        {
            _addNewSessionModel.CurrentDateTime = DateTime.Now;
            try
            {
                if (_addNewSessionModel.GetCurrentPriceForPlaystation(playstationId, _addNewSessionModel.CurrentDateTime) > 0)
                {
                    TimeSpan paidTime = _addNewSessionModel.GetTimeToPlay(remainedMoney, playstationId,_addNewSessionModel.CurrentDateTime);

                    if ((paidTime.Days) * 24 + paidTime.Hours > 0 || paidTime.Minutes > 0)
                    {
                        return paidTime;
                    }
                }
                else
                {
                    MessageBox.Show(WarningMessages("TimeZonePriceError"));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(WarningMessages("UpdateTimeError"));
            }
            return new TimeSpan();
        }
        public List<string> AddNewClientToField(string clientId, string idsTextBox, string namesTextBox,decimal moneyLeftTextBox, string clientName, decimal moneyLeft)
        {
            var result = new List<string>();
            if (!_addNewSessionModel.IsRepeated(clientId, idsTextBox))
            {
                if (String.IsNullOrWhiteSpace(idsTextBox) || idsTextBox == "0")
                {
                    result.Add(clientId);
                    result.Add(clientName);
                    result.Add(moneyLeft.ToString(CultureInfo.InvariantCulture));
                }
                else
                {
                    idsTextBox += "; " + clientId;
                    result.Add(idsTextBox); //adding id
                    namesTextBox += "; " + clientName;
                    result.Add(namesTextBox); //adding name of client
                    moneyLeft = moneyLeftTextBox + moneyLeft;
                    result.Add(moneyLeft.ToString(CultureInfo.InvariantCulture));//adding new sum
                }
                //                UpdateRemainedTimeOnPaidPriceChanged((double) numericUpDownClientMoneyLeft.Value);
            }
            return result;
        }
        public void AddNewDaySession(string playstationId, string clientId, TimeSpan timeToPlay, double paidSum, DateTime curTime)
        {
            _addNewSessionModel.AddNewDaySession(playstationId, clientId, timeToPlay, paidSum, curTime);
        }

        
    }

}
