using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Boom_Manager_Project.MyClasses;
using LINQ_test.Driver;

namespace Boom_Manager_Project.DataBaseClasses
{
    public class DataBaseClass
    {
        private static DataBaseClass _dbClass;
        public static DataBaseClass Instancedb()
        {
            return _dbClass ?? (_dbClass = new DataBaseClass());
        }

        public personal_info_t GetUserInfoByLogin(string login)
        {
            var db = new dbDataContext();
            lock (db)
            {
                personal_info_t userInfo = (from a in db.GetTable<personal_info_t>()
                    where a.staff_login == login
                    select a).SingleOrDefault();
                return userInfo;
            }
        }
        public personal_info_t GetUserInfoByName(string name)
        {
            var db = new dbDataContext();
            lock (db)
            {
                personal_info_t userInfo = (from a in db.GetTable<personal_info_t>()
                                            where a.name == name
                                            select a).SingleOrDefault();
                return userInfo;
            }
        }
        public personal_info_t GetUserInfoByPersonID(string personId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                personal_info_t userInfo = (from a in db.GetTable<personal_info_t>()
                                            where a.person_id == personId
                                            select a).SingleOrDefault();
                return userInfo;
            }
        }

        public global_session_t GetOpenedGlobalSession()
        {
            var db = new dbDataContext();
            lock (db)
            {
                var r =  (from gs in db.GetTable<global_session_t>()
                    where gs.end_session == gs.start_session
                    select gs).SingleOrDefault();
                return r;
            }
        }
        public void CloseLastOpenedGlobalSession()
        {
            var db = new dbDataContext();
            lock (db)
            {
                var globalSession = (from gs in db.GetTable<global_session_t>()
                         where gs.end_session == gs.start_session
                         select gs).SingleOrDefault();
                if (globalSession != null)
                {
                    globalSession.end_session = DateTime.Now;
                    db.SubmitChanges();
                }
            }
        }

        public List<ShiftsMyClass> GetAllGlobalSessions(int numberOfLastSessons)
        {
            var db = new dbDataContext();
            lock (db)
            {
                if (numberOfLastSessons > 0)
                {
                    return (from a in db.GetTable<global_session_t>()
                        orderby a.daily_id ascending
                        select new ShiftsMyClass
                        {
                            DailyId = a.daily_id,
                            AdministratorID = a.administrator_id,
                            OperatorId = a.operator_id,
                            StartTime = a.start_session,
                            EndTime = a.end_session
                        }).Take(numberOfLastSessons).ToList();
                }
                return new List<ShiftsMyClass>();
            }
        }
        public List<clients_per_session_t> GetListOfAllClientsPerSessionT()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from c in db.GetTable<clients_per_session_t>()
                    select c).ToList();
            }
        }

        public List<clients_per_session_t> GetListOfClientsPerExactSession(int sessionId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from c in db.GetTable<clients_per_session_t>()
                    where c.session_id == sessionId
                    select c).ToList();
            }
        }

        public days_sessions_t GetDaySessionBySessionId(int sessionId, int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from s in db.GetTable<days_sessions_t>()
                    where s.session_id == sessionId
                    where s.daily_id == dailyId
                    select s).SingleOrDefault();
            }
        }

        public List<tables_t> GetAllTables()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from t in db.GetTable<tables_t>()
                    select t).ToList();
            }
        }

        public List<playstation_timezone> GetAllTimeZonePrices()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from p in db.GetTable<playstation_timezone>()
                    orderby p.playstation_id.Length ascending, p.playstation_id ascending
                    select p).ToList();
//                    select new
//                    {
//                        p.playstation_id,
//                        p.timezone_cost_per_hour
//                    }).ToList();
            }
        }

        public List<device_endpoints_t> GetAllEndPoints()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from ep in db.GetTable<device_endpoints_t>()
                    select ep).ToList();
            }
        }

        public void UpdatePricesForTimeZone(List<string> playstationsToChange, string timeZoneName, int newPrice)
        {
            var db = new dbDataContext();
            lock (db)
            {
                foreach (string t in playstationsToChange)
                {
                    var matchedRecord = (from price in db.GetTable<playstation_timezone>()
                        where price.playstation_id == t
                        where price.timezone_name == timeZoneName
                        select price).SingleOrDefault();
                    if (matchedRecord == null) continue;
                    try
                    {
                        matchedRecord.timezone_cost_per_hour = newPrice;
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        public void UpdateClientInfo(client_info_t cInfo)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var matchedRecord = (from c in db.GetTable<client_info_t>()
                    where c.client_id == cInfo.client_id
                    select c).SingleOrDefault();
                if (matchedRecord != null)
                {
                    matchedRecord.name = cInfo.name;
                    matchedRecord.birthday = cInfo.birthday;
                    matchedRecord.email = cInfo.email;
                    matchedRecord.phone = cInfo.phone;
                }
                db.SubmitChanges();
            }
        }
        public List<string> GetAllStaffNamesByPositionList(string position)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var allStaff = (from s in db.GetTable<personal_info_t>()
                    where s.position == position
                    select s.name).ToList();
                return allStaff;
            }
        }

//        public List<string> GetAllTimeZones()
//        {
//            var db = new dbDataContext();
//            lock (db)
//            {
//                return (from t in db.GetTable<timezones_t>()
//                    orderby t.timezone_start
//                    select new
//                    {
//                        t.timezone_name.ToString()
//                    }).ToList();
//            }
//        }

        public List<DaySessionClass> GetOpenedDaySessions(int dailyId, List<clients_per_session_t> clientsList)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from days in db.GetTable<days_sessions_t>()
                    where days.daily_id == dailyId
                    where days.session_state == "opened"
                    orderby days.end_game ascending
                    let startGame = days.start_game
                    where startGame != null
                    let endGame = days.end_game
                    where endGame != null
                    let sessionDiscount = days.session_discount
                    where sessionDiscount != null
                    select new DaySessionClass
                    {
                        Сессия = days.session_id,
                        Приставка = days.playstation_id,
                        Начало = (DateTime) startGame,
                        Конец = (DateTime) endGame,
                        Оставшееся_время = GetTimeLeft((DateTime) endGame),
                        //----------------------------------------------------------
                        Клиент = ListToString(days.session_id, clientsList),
                        //to show all clients in one line and column instead of one as string
                        Остаток_денег = days.money_left,
                        Скидка_сессии = (double) sessionDiscount,
                        Оплаченная_сумма = days.payed_sum
                    }).ToList<DaySessionClass>();
            }
        }

        public void TransferOpenedSessionToNextGlobalSession(int sessionId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var sessionToTransfer = (from s in db.GetTable<days_sessions_t>()
                    where s.session_id == sessionId
                    select s).SingleOrDefault();
//                sessionToTransfer.daily_id = sessionToTransfer.daily_id + 1;

                var lastOpenedGlobalSession = GetOpenedGlobalSession();

                if (sessionToTransfer != null)
                {
                    sessionToTransfer.daily_id = lastOpenedGlobalSession.daily_id;
                    db.SubmitChanges();
                }
            }
        }

//        private DateTime CheckTheDate(DateTime toCheck)
//        {
//            DateTime curTime = DateTime.Now;
//            if (toCheck.Year == curTime.Year && toCheck.Month == curTime.Month && toCheck.Day == curTime.Day)
//            {
//                return 
//            }
//        }

        private static TimeSpan GetTimeLeft(DateTime end)
        {
            TimeSpan result = end.Subtract(DateTime.Now);
            return new TimeSpan(result.Days, result.Hours, result.Minutes, result.Seconds);
        }


        private static string ListToString(int sessionId, IEnumerable<clients_per_session_t> clientsList)
        {
            string result = "";
            var clientsInSession = (from c in clientsList
                where c.session_id == sessionId
                select c.client_id).ToList();
            if (clientsInSession.Count > 0)
            {
                result = clientsInSession.Aggregate(result, (current, s) => current + (s + "; "));
                result = result.Remove(result.Length - 2);
            }
            return result;
        }

        public List<DaySessionClass> GetAllDaySessionsInShift(int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                 var clientsList = (from c in db.GetTable<clients_per_session_t>()
                                  select c).ToList();
                var daySessionsReport = (from d in db.GetTable<days_sessions_t>()
                                     from c in db.GetTable<clients_per_session_t>()
                                     orderby d.start_game, d.end_game
                                     where d.daily_id == dailyId
                                     where c.session_id == d.session_id
                                     let startGame = d.start_game
                                     where startGame != null
                                     let endGame = d.end_game
                                     where endGame != null
                                     select new DaySessionClass
                                     {
                                         Сессия = d.client_num,//to see manager num of clients
                                         Приставка = d.playstation_id,
                                         Начало = (DateTime)startGame,
                                         Конец = (DateTime)endGame,
                                         Оставшееся_время = GetTimeLeft((DateTime)endGame),//----------------------------------------------------------
                                         Клиент = ListToString(d.session_id, clientsList), //to show all clients in one line and column instead of one
                                         Остаток_денег = d.money_left,
                                         Скидка_сессии = (double)d.session_discount,
                                         Оплаченная_сумма = d.payed_sum
                                     }).ToList<DaySessionClass>();
                return daySessionsReport;
            }
        }

//        public List<timezones_t> GetAllTimezones()
//        {
//            var db = new dbDataContext();
//            lock (db)
//            {
//                var timeZoneTable = (from q in db.GetTable<timezones_t>()
//                    orderby q.timezone_start
//                    select q).ToList();
//                return timeZoneTable;
//            }
//            
//        }
        public void AddNewDevice(int deviceId, string ipAddress)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<devices_t> devicesTable = db.GetTable<devices_t>();
                var device = new devices_t
                {
                    device_id = deviceId, 
                    ip_address = ipAddress
                };
                devicesTable.InsertOnSubmit(device); 
                db.SubmitChanges();
//                List<string> allConsoles = GetAllTables().Select(t => t.playstation_id).ToList();

                for(int i = 1;i<=16;i++)
                {
                    InsertNewEndPoint(deviceId, i);
                }
               
            }
        }

        public void InsertNewEndPoint(int deviceId, int index)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<device_endpoints_t> deviceEndpointsTs = db.GetTable<device_endpoints_t>();
                var endpoint = new device_endpoints_t
                {
                    device_id = deviceId,
                    endpoint_index = index
//                    playstation_id = playstationId
                };
                deviceEndpointsTs.InsertOnSubmit(endpoint);
                db.SubmitChanges();
            }
        }

        public void ChangeEndPointConsoleId(int endpointId, string changePlaystation, int deviceId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var matched = (from ep in db.GetTable<device_endpoints_t>()
                    where ep.endpoint_index == endpointId
                    where ep.device_id == deviceId
                    select ep).SingleOrDefault();
                if (matched != null)
                {
                    matched.playstation_id = changePlaystation;
                    
                    db.SubmitChanges();
                }
            }
        }
        public void AddNewStaffUser(personal_info_t userInfo)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<personal_info_t> personalInfoTable = db.GetTable<personal_info_t>();
                personal_info_t user = userInfo;

                personalInfoTable.InsertOnSubmit(user);
                db.SubmitChanges();
            }
        }

        public void AddNewClient(client_info_t clientInfo)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<client_info_t> personalInfoTable = db.GetTable<client_info_t>();
                client_info_t user = clientInfo;

                personalInfoTable.InsertOnSubmit(user);
                db.SubmitChanges();
                AddNewSaVingsForClient(user.client_id);
            }
        }

        private void AddNewSaVingsForClient(string clientId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<account_savings_t> personalInfoTable = db.GetTable<account_savings_t>();
                var savings = new account_savings_t
                {
                    client_id = clientId,
                    savings = 0
                };

                personalInfoTable.InsertOnSubmit(savings);
                db.SubmitChanges();
            }
        }

        public void AddNewGlobalSession(string adminID, string operatorID, DateTime date)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<global_session_t> gst = db.GetTable<global_session_t>();
                var globSess = new global_session_t
                {
                    administrator_id = adminID,
                    start_session = date,
                    end_session = date
                };

                if (operatorID != "no operator")
                {
                    globSess.operator_id = operatorID;
                }

                gst.InsertOnSubmit(globSess);
                db.SubmitChanges();
            }
        }
        public List<tables_t> GetAllFreeTables()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from tb in db.GetTable<tables_t>()
                    orderby tb.playstation_id.Length ascending, tb.playstation_id ascending
                    where tb.playstation_state == "free"
                    select tb).ToList();
            }
        }

        public double? GetPriceForPlaystation(string playstationId, string currentTimeZone)
        {
            var db = new dbDataContext();
            lock (db)
            {
                double? price = (from p in db.GetTable<playstation_timezone>()
                    where p.timezone_name == currentTimeZone
                    where p.playstation_id == playstationId
                    select p.timezone_cost_per_hour).SingleOrDefault();
                return price;
            }
        }
        public List<playstation_timezone> GetAllPricesForPlaystation()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from p in db.GetTable<playstation_timezone>()
                    select p).ToList();
            }
        }
        public List<timezones_t> GetAllTimeZones()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from t in db.GetTable<timezones_t>()
                    select t).ToList();
            }
        }

        public client_info_t GetClientInfoById(string id)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from c in db.GetTable<client_info_t>()
                    where c.client_id == id
                    select c).SingleOrDefault();
            }
        }

        public account_savings_t GetClientSavingsById(string id)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from c in db.GetTable<account_savings_t>()
                    where c.client_id == id
                    select c).SingleOrDefault();
            }
        }

        public List<client_info_t> GetAllClients()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from lc in db.GetTable<client_info_t>()
                    select lc).ToList();
            }
        }

        

        public int GetLastOpenedGlobalSessionDailyId()//used to get last dailyID
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from gsession in db.GetTable<global_session_t>()
                    where gsession.start_session == gsession.end_session
                    orderby gsession.daily_id descending
                    select gsession.daily_id).FirstOrDefault();
            }
        }
        public global_session_t GetGlobalSessionByDailyId(int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from gsession in db.GetTable<global_session_t>()
                        where gsession.daily_id == dailyId
                        select gsession).SingleOrDefault();
            }
        }
        public int GetLastClientNumInSession(int dailyId)//for getting number for next client
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from days in db.GetTable<days_sessions_t>()
                    where days.daily_id == dailyId
                    orderby days.client_num descending
                    select days.client_num).FirstOrDefault();
            }
        }

        public tables_t GetTableInfo(string playstationId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from t in db.GetTable<tables_t>()
                    where t.playstation_id == playstationId
                    select t).SingleOrDefault();
            }
        }

        public void InsertNewDaySession(days_sessions_t daySession)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<days_sessions_t> daysT = db.GetTable<days_sessions_t>();
                var daysSessionT = new days_sessions_t
                {
                    daily_id = daySession.daily_id,
                    client_num = daySession.client_num,
                    start_game = daySession.start_game,
                    end_game = daySession.end_game,
                    playstation_id = daySession.playstation_id,
                    session_state = "opened",
                    payed_sum = daySession.payed_sum,
                    money_left = daySession.money_left,
                    session_discount = daySession.session_discount
                };
                daysT.InsertOnSubmit(daysSessionT);
                db.SubmitChanges();
            }
        }

        public void DeleteDaySession()
        {
            var db = new dbDataContext();
            lock (db)
            {
                var lastInsertedDaySession = (from ls in db.GetTable<days_sessions_t>()
                    orderby ls.session_id descending
                    select ls).FirstOrDefault();

                var sessionToDelete = (from d in db.GetTable<days_sessions_t>()
                    where d.session_id == lastInsertedDaySession.session_id
                    select d).SingleOrDefault();
                if (sessionToDelete == null) return;
                Table<days_sessions_t> deleteFromT = db.GetTable<days_sessions_t>();
                deleteFromT.DeleteOnSubmit(sessionToDelete);
                db.SubmitChanges();
            }
        }

        public void SwitchOnConsole(string consoleId,List<Endpoint> endpoints)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var allTablesList = (from i in db.GetTable<tables_t>()
                                     orderby i.playstation_id.Length ascending, i.playstation_id ascending
                                     select i.playstation_id).ToList();

                int index = allTablesList.IndexOf(consoleId);
                if (!endpoints[index].On())
                {
                    /*throw new Exception*/
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(1));//no connection with device

                }//Sending singnal to board
            }
        }

        public List<devices_t> GetAllDevices()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from d in db.GetTable<devices_t>()
                    select d).ToList();
            }
        }

        public void DeleteDevice(int deviceId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var matchedResult = (from d in db.GetTable<devices_t>()
                    where d.device_id == deviceId
                    select d).SingleOrDefault();
                if (matchedResult != null)
                {
                    Table<devices_t> devicesTable = db.GetTable<devices_t>();
                    devicesTable.DeleteOnSubmit(matchedResult);
                    DeleteAllEndPointsOfDevice(deviceId);
                    db.SubmitChanges();
                    
                }
            }
        }
        public void DeleteAllEndPointsOfDevice(int deviceId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var matchedResult = (from d in db.GetTable<device_endpoints_t>()
                    where d.device_id == deviceId
                    select d);
                {
                    Table<device_endpoints_t> devicesTable = db.GetTable<device_endpoints_t>();
                    devicesTable.DeleteAllOnSubmit(matchedResult);
                    db.SubmitChanges();
                }
            }
        }
        public List<DevicesEndPointsMyClass> GetAllEndPointsIndexes(int deviceId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from i in db.GetTable<device_endpoints_t>()
                    where i.device_id == deviceId
                    orderby i.endpoint_id ascending
                    select new DevicesEndPointsMyClass
                    {
                        EndPointIndex = i.endpoint_index,
                        PlayStationId = i.playstation_id
                    }).ToList();
            }
        }

        public void DeleteTimeZoneWithData(string timeZoneNameToDelete)
        {
            var db = new dbDataContext();
            lock (db)
            {
                DialogResult deleteDialog =
                    MessageBox.Show(timeZoneNameToDelete + ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(1),
                        ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetCaption(1), MessageBoxButtons.OKCancel);
                if (deleteDialog == DialogResult.OK)
                {
                    var playstationCostsToDelete = (from pc in db.GetTable<playstation_timezone>()
                        where pc.timezone_name == timeZoneNameToDelete
                        select pc).ToList();

                    for (int i = 0; i < playstationCostsToDelete.Count(); i++)
                    {
                        if (playstationCostsToDelete.Count > 0)
                        {
                            foreach (var plst in playstationCostsToDelete)
                            {
                                try
                                {
                                    db.playstation_timezones.DeleteOnSubmit(plst);
                                    db.SubmitChanges();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(2) + timeZoneNameToDelete);//cannot delete playstation cost
                                }
                            }
//                            MessageBox.Show(playstationCostsToDelete + " was deleted!");
                        }
                    }
                    var rowToDelete = (from q in db.GetTable<timezones_t>()
                        where q.timezone_name == timeZoneNameToDelete
                        select q).SingleOrDefault();

                    try
                    {
                        if (rowToDelete != null)
                            db.timezones_ts.DeleteOnSubmit(rowToDelete);
                        db.SubmitChanges();
//                        RefreshTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
//                    for (int i = 0; i < ComboBoxTimeZOne.Items.Count; i++)
//                    {
//                        if (ComboBoxTimeZOne.Items[i].ToString() == nameToDelete)
//                        {
//                            ComboBoxTimeZOne.SelectedIndex = 0;
//                            ComboBoxTimeZOne.Items.RemoveAt(i);
//                        }
//                    }
                }
            }
        }

        public void UpdatePlaystationState(string playstationId, string state)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var table = (from t in db.GetTable<tables_t>()
                    where t.playstation_id == playstationId
                    select t).SingleOrDefault();
                if (table != null && table.playstation_id != null)
                {
                    table.playstation_state = state;
                    db.SubmitChanges();
                }
            }
        }

        public void DeleteConsole(string consoleId)
        {
            var db = new dbDataContext();
            lock (db)
            {
//                    string selectedTable = (string)dataGridViewConsolesList.CurrentRow.Cells[0].Value;
                var consoleToDelete = (from t in db.GetTable<tables_t>()
                    where t.playstation_id.Equals(consoleId)
                    select t).SingleOrDefault();
                var deleteTimezonePrices = (from tp in db.GetTable<playstation_timezone>()
                    where tp.playstation_id.Equals(consoleId)
                    select tp);
                var deleteEndPoints = (from ep in db.GetTable<device_endpoints_t>()
                    where ep.playstation_id == consoleId
                    select ep);
                var sessionsToDelete = (from s in db.GetTable<days_sessions_t>()
                    where s.playstation_id == consoleId
                    select s);
                
                Table<clients_per_session_t> cps = db.GetTable<clients_per_session_t>();
                foreach (var daysSessionsT in sessionsToDelete)
                {
                    days_sessions_t t = daysSessionsT;
                    var clientsPerSessionToDelete = (from cp in db.GetTable<clients_per_session_t>()
                        where cp.session_id == t.session_id
                        select cp).SingleOrDefault();
                    if (clientsPerSessionToDelete != null) cps.DeleteOnSubmit(clientsPerSessionToDelete);
                    db.SubmitChanges();
                }
                if (consoleToDelete != null)
                {
                    Table<days_sessions_t> daysSessionsTs = db.GetTable<days_sessions_t>();
                    Table<device_endpoints_t> deviceEndpointsTs = db.GetTable<device_endpoints_t>();
                    Table<tables_t> tablesTs = db.GetTable<tables_t>();

                    foreach (var deleteTimezonePrice in deleteTimezonePrices)
                    {
                        db.playstation_timezones.DeleteOnSubmit(deleteTimezonePrice);
                    }
                    daysSessionsTs.DeleteAllOnSubmit(sessionsToDelete);
                    db.SubmitChanges();
                    deviceEndpointsTs.DeleteAllOnSubmit(deleteEndPoints);
                    db.SubmitChanges();
                   
                    tablesTs.DeleteOnSubmit(consoleToDelete);
                    db.SubmitChanges();
                }
            }
        }

        public void InsertNewConsole(string consoleName)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<tables_t> consolesT = db.GetTable<tables_t>();
                var console = new tables_t
                {
                    playstation_id = consoleName,
                    playstation_state = "free",
                    order_time = new DateTime(2000, 1, 1, 0, 0, 0)
                };
                consolesT.InsertOnSubmit(console);
                var timeZoneList = GetAllTimeZones();
                foreach (timezones_t t in timeZoneList)
                {
                    Table<playstation_timezone> playstationPricesT = db.GetTable<playstation_timezone>();
                    var timezonePrice = new playstation_timezone
                    {
                        playstation_id = consoleName,
                        timezone_cost_per_hour = 0,
                        timezone_name = t.timezone_name
                    };
                    playstationPricesT.InsertOnSubmit(timezonePrice);
                }
                db.SubmitChanges();
            }
        }

        public void InsertClientsPerTable(string clientId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var lastInsertedDaySession = (from ls in db.GetTable<days_sessions_t>()
                    orderby ls.session_id descending
                    select ls).FirstOrDefault(); //get last added session 

                var clientsPersessionTable = db.GetTable<clients_per_session_t>();
                var clientsPerSessionT = new clients_per_session_t();

                if (lastInsertedDaySession != null)
                {
                    if (clientId == "0")
                    {
                        clientsPerSessionT.session_id = lastInsertedDaySession.session_id;
                        clientsPerSessionT.client_id = "0";
                        clientsPerSessionT.payed_sum = 0;
                        clientsPersessionTable.InsertOnSubmit(clientsPerSessionT);
                        db.SubmitChanges();
                    }
                    else if (clientId != null && (!string.IsNullOrEmpty(clientId) && clientId.Length > 2))
                    {
                        IEnumerable<string> discountsArePlaying = DiscountSplitter(clientId);

                        foreach (string d in discountsArePlaying)
                        {
                            clientsPerSessionT = new clients_per_session_t
                            {
                                session_id = lastInsertedDaySession.session_id,
                                client_id = d,
                                payed_sum = 0.0//---------------------------------------------------------------------------------DIVIDE BEFORE !!!!!!!!
                            };
                            clientsPersessionTable.InsertOnSubmit(clientsPerSessionT);
                            db.SubmitChanges();
                        }
                    }
                }
            }
        }

        private IEnumerable<string> DiscountSplitter(string textToSplitBySemiColumn)
        {
            List<string> result = Regex.Split(textToSplitBySemiColumn, "; ").ToList();
            return result;
        }

        public void CloseSessionWithUsualClient(DaySessionClass dsc, string comments, DateTime endTime)
        {
            var db = new dbDataContext();
            lock (db)
            {
                int dayId = GetOpenedGlobalSession().daily_id;
                var sessionIdtoDelete = (from s in db.GetTable<days_sessions_t>()
                                            where s.daily_id == dayId
                                            where s.session_id == dsc.Сессия
                                            select s).SingleOrDefault();
                if (sessionIdtoDelete == null) return;

                sessionIdtoDelete.end_game = endTime;
                sessionIdtoDelete.session_state = "closed";

//                if (endTime - dsc.Начало < TimeSpan.FromHours(1))
//                {
//                    dsc.Остаток_денег = dsc.Оплаченная_сумма - dsc.Остаток_денег;
//                }
                sessionIdtoDelete.money_left = dsc.Остаток_денег;
                if (String.IsNullOrWhiteSpace(sessionIdtoDelete.comments))
                {
                    sessionIdtoDelete.comments = comments;
                }
                else
                {
                    sessionIdtoDelete.comments += "\n" + comments;
                }
                UpdatePlaystationState(dsc.Приставка, "free");
                while (true)
                {
                    try
                    {
                        db.SubmitChanges();
                        break;
                    }
                    catch
                    {
                        MessageBox.Show(
                            ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(3));
                    }
                }
            }
        }
        public void CloseSessionWithCard(DaySessionClass dsc, string comments, DateTime endTime)
        {
            var db = new dbDataContext();
            lock (db)
            {
                int dayId = GetOpenedGlobalSession().daily_id;
                var sessionIdtoDelete = (from s in db.GetTable<days_sessions_t>()
                                         where s.daily_id == dayId
                                         where s.session_id == dsc.Сессия
                                         select s).SingleOrDefault();
                if (sessionIdtoDelete == null) return;
                sessionIdtoDelete.end_game = endTime;
                sessionIdtoDelete.session_state = "closed";
                sessionIdtoDelete.money_left = dsc.Остаток_денег;
                List<clients_per_session_t> clientsOnSession = GetListOfClientsPerExactSession(dsc.Сессия);
                double playedMoney = dsc.Оплаченная_сумма - dsc.Остаток_денег;//sessionIdtoDelete.payed_sum - sessionIdtoDelete.money_left;
                double eachPlayerShouldPay = playedMoney/clientsOnSession.Count;
                double nextShouldpayAdditional = 0;
                do
                {
                    foreach (var client in clientsOnSession)
                    {
                        var moneyOnClientCard = GetClientSavingsById(client.client_id);
                        if (moneyOnClientCard != null)
                        {
                            if (moneyOnClientCard.savings >= (eachPlayerShouldPay + nextShouldpayAdditional))
                            {
                                playedMoney = playedMoney - (eachPlayerShouldPay + nextShouldpayAdditional);
//                                moneyOnClientCard.savings = moneyOnClientCard.savings - (eachPlayerShouldPay + nextShouldpayAdditional);
                                ChangeSavingsValueOfClient(moneyOnClientCard.client_id,
                                    (moneyOnClientCard.savings - (eachPlayerShouldPay + nextShouldpayAdditional))*-1);
                                nextShouldpayAdditional = 0;
                            }
                            else
                            {
                                nextShouldpayAdditional = eachPlayerShouldPay - moneyOnClientCard.savings;
                                playedMoney = playedMoney - moneyOnClientCard.savings;
//                                moneyOnClientCard.savings = 0;
                                ChangeSavingsValueOfClient(moneyOnClientCard.client_id, 0);
                            }
                        }
//                        try
//                        {
//                            db.SubmitChanges();
//                        }
//                        catch (Exception)
//                        {
//                            MessageBox.Show("Error during closing clients occured!");
//                        }
                    }
                } while (nextShouldpayAdditional > 0 && playedMoney > 0);


                if (String.IsNullOrWhiteSpace(sessionIdtoDelete.comments))
                {
                    sessionIdtoDelete.comments = comments;
                }
                else
                {
                    sessionIdtoDelete.comments += "\n" + comments;
                }
                UpdatePlaystationState(dsc.Приставка, "free");
                while (true)
                {
                    try
                    {
                        db.SubmitChanges();
                        break;
                    }
                    catch
                    {
                        MessageBox.Show(
                            ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(3));
                    }
                }
            }
        }

        public void ChangeSavingsValueOfClient(string clientID, double sumToAdd)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var clientIdToChangeSavings = (from c in db.GetTable<account_savings_t>()
                    where c.client_id == clientID
                    select c).SingleOrDefault();
//                var paymentTable = (from p in db.GetTable<payments_t>()
//                                        where )
                if (clientIdToChangeSavings != null)
                {
                    clientIdToChangeSavings.savings += sumToAdd;
                    try
                    {
                        db.SubmitChanges();
                        InsertNewPaymentToClientHistory(clientID, sumToAdd);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(4) + clientIdToChangeSavings.client_id);
                    }
                }
            }
        }

        public void InsertWithdrawRecord(double money, string managerName, DateTime withdrawTime)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<withdrow_money_t> withdrawMoneyTable = db.GetTable<withdrow_money_t>();
                var withdrawMoney = new withdrow_money_t
                {
                    daily_id = GetLastOpenedGlobalSessionDailyId(),
                    manager = GetUserInfoByName(managerName).person_id,
                    cash_amount = money,
                    transaction_time = withdrawTime
                };
                withdrawMoneyTable.InsertOnSubmit(withdrawMoney);
                db.SubmitChanges();
            }
        }

        public List<double?> GetAllWithdrawnMoneyOnDailyId(int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var allMoney = (from m in db.GetTable<withdrow_money_t>()
                    where m.daily_id == dailyId
                    select m.cash_amount).ToList();
                return allMoney;
            }
        }

        private void InsertNewPaymentToClientHistory(string clientId, double cash)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var paymentsTable = db.GetTable<payments_t>();
                var payments = new payments_t
                {
                    client_id = clientId,
                    date_of_transaction = DateTime.Now,
                    put_cash = cash
                };

                paymentsTable.InsertOnSubmit(payments);
                db.SubmitChanges();
            }
        }

        public void ExtendGameTimeWithUsualClient(DaySessionClass sessionToExtend, TimeSpan timeToExtend, double moneyToExtend)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var session = (from d in db.GetTable<days_sessions_t>()
                    where d.session_id == sessionToExtend.Сессия
                    select d).SingleOrDefault();
                if (session != null)
                {
                    session.end_game += timeToExtend;
                    session.payed_sum += moneyToExtend;
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(5));
                    }
                }
            }
        }
        public void ExtendGameTimeWithClientWithDiscountCard(DaySessionClass sessionToExtend, TimeSpan timeOfgame, double moneyOnCard)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var session = (from d in db.GetTable<days_sessions_t>()
                               where d.session_id == sessionToExtend.Сессия
                               select d).SingleOrDefault();
                if (session != null)
                {
                    session.end_game = session.start_game + timeOfgame;
                    session.payed_sum = moneyOnCard;
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(5));
                    }
                }
            }
        }

        public void InsertNewTimeZone(string timeZoneName, TimeSpan startTime, TimeSpan endTime)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<timezones_t> timeZonesT = db.GetTable<timezones_t>();
                var timezones = new timezones_t
                {
                    timezone_name = timeZoneName,
                    timezone_start = startTime,
                    timezone_end = endTime
                };
                try
                {
                    timeZonesT.InsertOnSubmit(timezones);
                    db.SubmitChanges();
//                    RefreshTable();
                }
                catch (Exception)
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(5));
                }
                try
                {
                    var playstations = GetAllTables();
                    foreach (tables_t t in playstations)
                    {
                        Table<playstation_timezone> timeZoneTable = db.GetTable<playstation_timezone>();
                        var playstationTimezone = new playstation_timezone
                        {
                            playstation_id = t.playstation_id,
                            timezone_name = timeZoneName,
                            timezone_cost_per_hour = 0
                        };
                        timeZoneTable.InsertOnSubmit(playstationTimezone);
                        db.SubmitChanges();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(7));
                }
            }
        }
    }
}
