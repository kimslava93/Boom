using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Controllers
{
    class AddNewSessionModel
    {
       
        public DateTime CurrentDateTime;
        private readonly DataBaseClass _dbClass;

        private static AddNewSessionModel _addNewSessionModel;
        public static AddNewSessionModel InstanceAddNewSessionModel()
        {
            if (_addNewSessionModel == null)
            {
                _addNewSessionModel = new AddNewSessionModel();
            }
            return _addNewSessionModel;
        }

        public AddNewSessionModel ()
        {
            _dbClass = DataBaseClass.Instancedb();
            CurrentDateTime = DateTime.Now;
//            CheckClientWithCardOtNot();
//            paid_price_numeric_up_down.Minimum = paid_price_numeric_up_down.Value;
        }
        public List<tables_t> GetAllFreeTables()
        {
            return _dbClass.GetAllFreeTables();
        }
        public double GetSumToPay(string playstationId, TimeSpan paidTime, DateTime startTime)
        {
            double sum = 0.0;
            DateTime endTime = startTime;
            if (paidTime.TotalMinutes >= 60)
            {
                if (endTime.Minute != 0)
                {
//                    TimeSpan toAccurateTime = TimeSpan.FromMinutes(60 - endTime.Minute) +
//                                              TimeSpan.FromSeconds(60 - endTime.Second);
                    TimeSpan toAccurateTime2 = new TimeSpan(0,0, 60 - endTime.Minute, 60 - endTime.Second,
                        1000 - endTime.Millisecond);
                    
//                    double sumToAdd = toAccurateTime2.TotalSeconds * GetCurrentPriceForPlaystation(playstationId, endTime);
                    sum += toAccurateTime2.TotalSeconds * GetCurrentPriceForPlaystation(playstationId, endTime) / 60 / 60;
                    endTime = endTime.AddSeconds(toAccurateTime2.TotalSeconds);
                    paidTime = paidTime.Subtract(toAccurateTime2);
                }
                for (int i = 0; i < (int)paidTime.TotalHours; i++)
                {
                    sum += GetCurrentPriceForPlaystation(playstationId, endTime);
                    endTime = endTime.AddHours(1);
                }
                if (paidTime.Minutes != 0)
                {
//                    double sumToAdd = GetCurrentPriceForPlaystation(playstationId, endTime)*(paidTime.Minutes*60 +
//                                      paidTime.Seconds + paidTime.Milliseconds/1000);
                    sum += GetCurrentPriceForPlaystation(playstationId, endTime)*(paidTime.Minutes*60 +
                                                                                  paidTime.Seconds +
                                                                                  paidTime.Milliseconds/1000)/60/60;
                }
            }
            else
            {
                TimeSpan toAccurateTime = TimeSpan.FromMinutes(60 - endTime.Minute);
                if (toAccurateTime <= paidTime)
                {
                    double sumToAdd = toAccurateTime.TotalSeconds * GetCurrentPriceForPlaystation(playstationId, endTime);
                    sum += sumToAdd / 60 / 60 + sumToAdd % 60 % 60;
//                    sum += toAccurateTime.TotalMinutes * GetCurrentPriceForPlaystation(playstationId, endTime) / 60;
                    paidTime = paidTime.Subtract(toAccurateTime);
                    endTime = endTime.Add(toAccurateTime);
                }
                if (paidTime.TotalMinutes > 0)
                {
                    double sumToAdd = toAccurateTime.TotalSeconds * GetCurrentPriceForPlaystation(playstationId, endTime);
                    sum += sumToAdd / 60 / 60 + sumToAdd % 60 % 60;
//                    sum += paidTime.TotalMinutes * GetCurrentPriceForPlaystation(playstationId, endTime) / 60;
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
                lock (_dbClass)
                {
                    double? price = _dbClass.GetPriceForPlaystation(playstationId, currentTimeZone);
                    if (price != null)
                    {
                        result = (double) price;
                    }
                }
            }
            catch (Exception)
            {
            }
            return result;
        }
        public TimeSpan GetTimeToPlay(double paidSum, string playstationId)
        {
            var result = new TimeSpan(0, 0, 0, 0);
            DateTime currentTime = DateTime.Now;
            if (paidSum >= GetCurrentPriceForPlaystation(playstationId, currentTime))
            {
                if (currentTime.Minute != 0)
                {
                    TimeSpan toAccurateTime = TimeSpan.FromMinutes(60 - currentTime.Minute);
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
                result =
                    result.Add(TimeSpan.FromMinutes(paidSum * 60 / GetCurrentPriceForPlaystation(playstationId, currentTime)));
            }
            return result;
        }
        private string WhichTimeZoneIs(DateTime timeToFind)
        {
            try
            {
                foreach (var tEndTime in _dbClass.GetTimeZones())
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
        public void AddNewDaySession(string playstationId, string clientId, TimeSpan timeToPlay, double paidSum)
        {
            if (!String.IsNullOrWhiteSpace(playstationId))
            {
                global_session_t globalSession = DataBaseClass.Instancedb().GetOpenedGlobalSession();
                var lastClientNumInSession =
                    DataBaseClass.Instancedb().GetLastClientNumInSession(globalSession.daily_id);
                var daysSessionT = new days_sessions_t
                {
                    daily_id = globalSession.daily_id,
                    client_num = lastClientNumInSession + 1,
                    start_game = DateTime.Now,
                    end_game = DateTime.Now.Add(timeToPlay),
                    playstation_id = playstationId,
                    session_state = "opened",
                    payed_sum = paidSum,
                    money_left = paidSum,
                    session_discount = 0
                    //-----------------------------------------------------------------DISCOUNT ACCOUNTING
                };
                try
                {
                    DataBaseClass.Instancedb().InsertNewDaySession(daysSessionT);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot insert DaySession!");
                }
                try
                {
                    DataBaseClass.Instancedb().UpdatePlaystationState(playstationId, "busy");
                }
                catch (Exception ex)
                {
                    //delete successful insertions 
                    MessageBox.Show("Cannot update playstation state!");
                }
                try
                {
                    DataBaseClass.Instancedb().InsertClientsPerTable(clientId);
                }
                catch (Exception)
                {
                    //delete successful insertions
                    MessageBox.Show("Cannot insert clients in clients_per_session table!");
                }

                //                            var allTablesList = (from i in _db.GetTable<tables_t>()
                //                                                 orderby i.playstation_id.Length ascending, i.playstation_id ascending
                //                                                 select i.playstation_id).ToList();
                //
                //                            int index = allTablesList.IndexOf(table_numComboBox.Text);
                //                            if (!_endpoints[index].ON())
                //                            {
                //                                throw new Exception("NO CONNECTION!!");
                //                            }//Sending singnal to board
            }
        }
    }
}
