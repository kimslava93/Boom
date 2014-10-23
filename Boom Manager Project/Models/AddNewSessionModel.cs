using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Models
{
    class AddNewSessionModel
    {
       
        public DateTime CurrentDateTime;
        private static AddNewSessionModel _addNewSessionModel;
        public string ClientId;
        public static AddNewSessionModel InstanceAddNewSessionModel()
        {
            return _addNewSessionModel ?? (_addNewSessionModel = new AddNewSessionModel());
        }

        public AddNewSessionModel ()
        {
            CurrentDateTime = DateTime.Now;
        }
        public List<tables_t> GetAllFreeTables()
        {
            return DataBaseClass.Instancedb().GetAllFreeTables();
        }
        public double GetSumToPay(string playstationId, TimeSpan paidTime, DateTime startTime)
        {
            double sum = 0.0;
            DateTime endTime = startTime;
            if (paidTime.TotalMinutes >= 60)
            {
                if (endTime.Minute != 0)
                {
                    var toAccurateTime2 = new TimeSpan(0, 0, 60 - endTime.Minute, 60 - endTime.Second,
                        1000 - endTime.Millisecond);

                    sum += toAccurateTime2.TotalMilliseconds*GetCurrentPriceForPlaystation(playstationId, endTime)/1000/
                           60/60;
                    endTime = endTime.AddMilliseconds(toAccurateTime2.TotalMilliseconds);
                    paidTime = paidTime.Subtract(toAccurateTime2);
                }
                var cycles = (int) paidTime.TotalHours;
                for (int i = 0; i < cycles; i++)
                {
                    sum += GetCurrentPriceForPlaystation(playstationId, endTime);
                    endTime = endTime.AddHours(1);
                    paidTime = paidTime.Subtract(TimeSpan.FromHours(1));
                }
                if (paidTime.TotalMinutes > 0)
                {
//                    return sum += GetCurrentPriceForPlaystation(playstationId, endTime)*(paidTime.Minutes)/60 +
//                                  (paidTime.Seconds/60/60) +
//                                  (paidTime.Milliseconds/1000/60/60);
                    double pstPrice = GetCurrentPriceForPlaystation(playstationId, endTime);
                    sum += paidTime.TotalSeconds*(pstPrice/60/60);
//                    MessageBox.Show(pstPrice/60 + " " + pstPrice%60);
                }
            }
            else
            {
                TimeSpan toAccurateTime = TimeSpan.FromMinutes(60 - endTime.Minute);
                if (toAccurateTime <= paidTime)
                {
//                    double sumToAdd = toAccurateTime.TotalSeconds * GetCurrentPriceForPlaystation(playstationId, endTime);
//                    sum += sumToAdd / 60 / 60 + sumToAdd % 60 % 60;
//                    paidTime = paidTime.Subtract(toAccurateTime);
//                    endTime = endTime.Add(toAccurateTime);
                    sum += toAccurateTime.TotalSeconds*GetCurrentPriceForPlaystation(playstationId, endTime)/60/60;
                    paidTime = paidTime.Subtract(toAccurateTime);
                    endTime = endTime.Add(toAccurateTime);
                }
                if (paidTime.TotalMinutes > 0)
                {
//                    double sumToAdd = toAccurateTime.TotalSeconds * GetCurrentPriceForPlaystation(playstationId, endTime);
//                    sum += sumToAdd / 60 / 60 + sumToAdd % 60 % 60;
                    sum += paidTime.TotalSeconds*GetCurrentPriceForPlaystation(playstationId, endTime)/60/60;
                }
            }
            return sum;
        }

        public double GetCurrentPriceForPlaystation(string playstationId, DateTime atTime)
        {
            double result = 0.0;
            string currentTimeZone = WhichTimeZoneIs(atTime);
            try
            {
                lock (DataBaseClass.Instancedb())
                {
                    double? price = DataBaseClass.Instancedb().GetPriceForPlaystation(playstationId, currentTimeZone);
                    if (price != null)
                    {
                        result = (double) price;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(22));
            }
            return result;
        }

        private double GetPriceForPlaystationForOneHourWithAllTimeZoneTransferring(string playstationId, DateTime curTime)//VERY IMPORTANT!!!! Should be used for only timeSpan lower than 1 hour!!!!!
        {
//            int nearestHour = curTime.Hour + 1;
//            if (nearestHour > 23)
//            {
//                nearestHour = 0;
//            }
            var nextHour = new DateTime(curTime.Year, curTime.Month, curTime.Day, curTime.Hour, 0, 0, 0).AddHours(1);
            var difference = nextHour - curTime;
            double price = 0;
            if (difference < TimeSpan.FromHours(1))
            {
                price = difference.TotalMinutes*GetCurrentPriceForPlaystation(playstationId, curTime)/60;
                price += (TimeSpan.FromHours(1).Subtract(difference).TotalMinutes)*
                         GetCurrentPriceForPlaystation(playstationId, nextHour)/60;
            }
            else
            {
                return GetCurrentPriceForPlaystation(playstationId, curTime);
            }
            return Math.Ceiling(price);
        }

        public TimeSpan GetTimeToPlay(double paidSum, string playstationId, DateTime fromTime)
        {
            var result = new TimeSpan(0, 0, 0, 0);
            DateTime currentTime = fromTime;//DateTime.Now;
            if ((paidSum - GetPriceForPlaystationForOneHourWithAllTimeZoneTransferring(playstationId, fromTime)) >= 1)
            {
                if (currentTime.Minute != 0)
                {
                    TimeSpan toAccurateTime = TimeSpan.FromMinutes(60 - currentTime.Minute) +
                                              TimeSpan.FromSeconds(60 - currentTime.Second) + 
                                              TimeSpan.FromMilliseconds(1000 - currentTime.Millisecond);
                    result = result.Add(toAccurateTime);
                    paidSum -= toAccurateTime.Minutes * GetCurrentPriceForPlaystation(playstationId, currentTime) / 60;
                    currentTime = currentTime.Add(toAccurateTime);

                    double toSubstract = GetCurrentPriceForPlaystation(playstationId, currentTime);
                    while (paidSum - toSubstract > 0)
                    {
                        paidSum -= toSubstract;
                        result = result.Add(TimeSpan.FromHours(1));

                        currentTime = currentTime.Add(TimeSpan.FromHours(1));
                        toSubstract = GetCurrentPriceForPlaystation(playstationId, currentTime);
                    }
                }
            }
            if (paidSum > 0)
            {
                var nextHour =
                    new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, 0, 0, 0)
                        .AddHours(1);
                var difference = nextHour - currentTime;
                double priceForDifference = GetSumToPay(playstationId, difference, currentTime);
                if (paidSum > priceForDifference)
                {
                    paidSum -= priceForDifference;
                    result = result.Add(difference);
                    result = result.Add(TimeSpan.FromMinutes((paidSum * 60) / GetCurrentPriceForPlaystation(playstationId, currentTime.Add(difference))));
                    return Options.OptionsInstance().RoundTimeSpan(result);
                }
                result =
                    Options.OptionsInstance()
                        .RoundTimeSpan(
                            result.Add(
                                TimeSpan.FromMinutes(paidSum*60/
                                                     GetCurrentPriceForPlaystation(playstationId, currentTime))));
                return result; //by cross formula
//
//            if (difference < TimeSpan.FromHours(1))
//            {
//                price = difference.TotalMinutes*GetCurrentPriceForPlaystation(playstationId, currentTime)/60;
//                price += (TimeSpan.FromHours(1).Subtract(difference).TotalMinutes)*
//                         GetCurrentPriceForPlaystation(playstationId, nextHour)/60;
            }
            return result;
        }
        public string WhichTimeZoneIs(DateTime timeToFind)
        {
            try
            {
                foreach (var tEndTime in DataBaseClass.Instancedb().GetAllTimeZones())
                {
                    if (IsInTimeZone(tEndTime.timezone_start, tEndTime.timezone_end, timeToFind))
                    {
                        return tEndTime.timezone_name;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return "";
        }
        public bool IsInTimeZone(TimeSpan begTime, TimeSpan endTime, DateTime date)
        {
            var beg = new DateTime(date.Year, date.Month, date.Day, begTime.Hours, begTime.Minutes, begTime.Seconds);
            var end = new DateTime(date.Year, date.Month, date.Day, endTime.Hours, endTime.Minutes, endTime.Seconds);
            if (beg > end)
            {
                end = end.AddDays(1);
            }
            bool res = (beg <= date && date < end) || (beg <= date.AddDays(1) && date.AddDays(1) < end);
            return res;
        }

        public bool IsRepeated(string cardId, string text)
        {
            if (text.Length <= 0)
            {
                return true;
            }
            List<string> splited = Regex.Split(text, "; ").ToList();
            var matchedResult = (from m in splited
                where m == cardId
                select m).SingleOrDefault();
            if (matchedResult != null)
            {
                return true;
            }
            return false;
        }
        public void AddNewDaySession(string playstationId, string clientId,double discountMoney, TimeSpan timeToPlay, double paidSum, DateTime curTime)
        {
            if (!String.IsNullOrWhiteSpace(playstationId) && !String.IsNullOrWhiteSpace(clientId))
            {
                global_session_t globalSession = DataBaseClass.Instancedb().GetOpenedGlobalSession();
                var lastClientNumInSession =
                    DataBaseClass.Instancedb().GetLastClientNumInSession(globalSession.daily_id);
                var daysSessionT = new days_sessions_t
                {
                    daily_id = globalSession.daily_id,
                    client_num = lastClientNumInSession + 1,
                    start_game = curTime,
                    end_game = curTime.Add(timeToPlay),
                    playstation_id = playstationId,
                    session_state = "opened",
                    payed_sum = paidSum,
                    played_money = 0,
                    session_discount = discountMoney//-----------------------------------------------------------------DISCOUNT ACCOUNTING
                };
                try
                {
                    DataBaseClass.Instancedb().InsertNewDaySession(daysSessionT);
                }
                catch (Exception)
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(18));
                }
                try
                {
//                     int dailyId = DataBaseClass.Instancedb().GetOpenedGlobalSession().daily_id;
                    DataBaseClass.Instancedb().AddMoneyToCash(daysSessionT.payed_sum, globalSession.daily_id);
                }
                catch (Exception)
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(19));
                }
                try
                {
                    DataBaseClass.Instancedb().UpdatePlaystationState(playstationId, "busy");
                }
                catch
                {
                    //delete successful insertions
                    DataBaseClass.Instancedb().DeleteDaySession();
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(20));
                }
                try
                {
                    if (clientId == Options.OptionsInstance().UsualClient)
                    {
                        DataBaseClass.Instancedb().InsertClientsPerTable(clientId);
                    }
                    else
                    {
                        DataBaseClass.Instancedb().InsertClientsPerTable(ClientId);
                    }
                }
                catch (Exception)
                {
                    //delete successful insertions
                    DataBaseClass.Instancedb().DeleteDaySession();
                    DataBaseClass.Instancedb().UpdatePlaystationState(playstationId, "free");
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(19));
                        //"Cannot insert clients in clients_per_session table!");
                }
            }
        }
    }
}
