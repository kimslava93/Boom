using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.Models;
using LINQ_test.Driver;

namespace Boom_Manager_Project.Controllers
{
    class AddNewSessionController
    {
        public readonly Point ActiveLocation = new Point(12, 138);
        public readonly Point PassiveLocation = new Point(456, 150);
//        private readonly int _dailyId;
//        private bool _opTable;
//        private int _repeatCallOfMethodCounter;
        private static AddNewSessionController _addNewSessionController;

        public static AddNewSessionController AddNewSessionControllerInstance()
        {
            return _addNewSessionController ?? (_addNewSessionController = new AddNewSessionController());
        }

//        public AddNewSessionController()
//        {
//            _addNewSessionModel = new AddNewSessionModel();
//        }
        public List<Endpoint> LoadingOfEndPoints(Device dev)
        {
            var endpoints = new List<Endpoint>();
            for (int i = 1; i <= 16 /*table_numComboBox.Items.Count*/; i++)
            {
                var ep = new Endpoint(dev, (byte)i);
                endpoints.Add(ep);
            }
            return endpoints;
        }

        public List<Device> GetDeviceListIPAddress()
        {
            return DataBaseClass.Instancedb().GetDevicesList();
        }

        public int GetDiscountSize(string discount)
        {
            int res = 0;
            if(int.TryParse(discount, out res))
            {
                return res;
            }
            return 0;
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
            List<tables_t> allFreeTables = AddNewSessionModel.InstanceAddNewSessionModel().GetAllFreeTables();
            return allFreeTables;
        }

        public string StartTimer()
        {
            AddNewSessionModel.InstanceAddNewSessionModel().CurrentDateTime = DateTime.Now;
            return AddNewSessionModel.InstanceAddNewSessionModel().CurrentDateTime.ToString("HH:mm:ss");
        }
        public string StartDate()
        {
            AddNewSessionModel.InstanceAddNewSessionModel().CurrentDateTime = DateTime.Now;
            return AddNewSessionModel.InstanceAddNewSessionModel().CurrentDateTime.ToString("dd MMMM");
        }

        public client_info_t GetClientById(string id)
        {
            var clients = DataBaseClass.Instancedb().GetAllClients();
            if (clients != null)
            {
//                var clientMatch = clients.Select(c => c.client_id == id).SingleOrDefault();
                var clientMatch = (from c in clients
                    where c.client_id == id
                    select c).SingleOrDefault();

                if (clientMatch != null)
                {
                    return clientMatch;
                }
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(24));
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(23));
            }
            return null;
        }

        public decimal UpdatePrice(string discountSize, string playstationId, decimal hoursLeft, decimal minutesLeft)
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
                    var price = AddNewSessionModel.InstanceAddNewSessionModel().GetSumToPay(playstationId, toPlay, currentDateTime);
                    if (GetDiscountSize(discountCard) > 0)
                    {

                    }
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

        public bool CheckDoesConsoleExist(string consoleId)
        {
            var tables = DataBaseClass.Instancedb().GetAllFreeTables();
            if (tables != null)
            {
                var result = (from t in tables
                    where t.playstation_id == consoleId
                    select t).SingleOrDefault();
                if (result != null)
                {
                    return true;
                }
            }
            return false;
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
            AddNewSessionModel.InstanceAddNewSessionModel().CurrentDateTime = DateTime.Now;
            try
            {
                if (AddNewSessionModel.InstanceAddNewSessionModel().GetCurrentPriceForPlaystation(playstationId, AddNewSessionModel.InstanceAddNewSessionModel().CurrentDateTime) > 0)
                {
                    TimeSpan paidTime = AddNewSessionModel.InstanceAddNewSessionModel().GetTimeToPlay(remainedMoney, playstationId, AddNewSessionModel.InstanceAddNewSessionModel().CurrentDateTime);

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
//-----------------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------------
//-------------------------------------------in case when client will have his ID and savings----------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------------

//        public List<string> AddNewClientToField(string clientId, string idsTextBox, string namesTextBox,decimal moneyLeftTextBox, string clientName, decimal moneyLeft)
//        {
//            var result = new List<string>();
//            if (!AddNewSessionModel.InstanceAddNewSessionModel().IsRepeated(clientId, idsTextBox))
//            {
//                if (String.IsNullOrWhiteSpace(idsTextBox) || idsTextBox == "0")
//                {
//                    result.Add(clientId);
//                    result.Add(clientName);
//                    result.Add(moneyLeft.ToString(CultureInfo.InvariantCulture));
//                }
//                else
//                {
//                    idsTextBox += "; " + clientId;
//                    result.Add(idsTextBox); //adding id
//                    namesTextBox += "; " + clientName;
//                    result.Add(namesTextBox); //adding name of client
//                    moneyLeft = moneyLeftTextBox + moneyLeft;
//                    result.Add(moneyLeft.ToString(CultureInfo.InvariantCulture));//adding new sum
//                }
//                //                UpdateRemainedTimeOnPaidPriceChanged((double) numericUpDownClientMoneyLeft.Value);
//            }
//            return result;
//        }
//-----------------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------------
        public void AddNewDaySession(string playstationId, string clientId, TimeSpan timeToPlay, double paidSum, DateTime curTime)
        {
            if (EndPointsControl.EndPointsControlInstance().SwitchOn(playstationId))
            {
                AddNewSessionModel.InstanceAddNewSessionModel()
                    .AddNewDaySession(playstationId, clientId, timeToPlay, paidSum, curTime);
            }
        }

        public bool CheckFieldsOnNull(string playstationId, string clientId, TimeSpan timeToPlay, double paidSum)
        {
            if (string.IsNullOrEmpty(playstationId) || string.IsNullOrEmpty(clientId) ||
                timeToPlay == TimeSpan.FromMinutes(0) || paidSum <= 0 || paidSum == null)
            {
                return false;
            }
            return true;
        }

//        private IEnumerable<string> DiscountSplitter(string textToSplitBySemiColumn)
//        {
//            List<string> result = Regex.Split(textToSplitBySemiColumn, "; ").ToList();
//            return result;
//        }
        public void ChooseClientAndAddMoneyOnCard(string clients)
        {
//            var allClients = (List<string>) DiscountSplitter(clients);
            //NOT FINISHEDNOT FINISHEDNOT FINISHEDNOT FINISHEDNOT FINISHEDNOT FINISHEDNOT FINISHEDNOT FINISHED
        }
    }

}
