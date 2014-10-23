using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.HardwareConnectionDriver;
using Boom_Manager_Project.MyClasses;

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

        public personal_info_t GetUserInfoByPersonId(string personId)
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
                var r = (from gs in db.GetTable<global_session_t>()
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
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        var globalSession = (from gs in db.GetTable<global_session_t>()
                            where gs.end_session == gs.start_session
                            select gs).SingleOrDefault();
                        if (globalSession != null)
                        {
                            globalSession.end_session = DateTime.Now;
                            db.SubmitChanges();
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        if (i <= 0)
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance()
                                .GetErrorWithLine(1, 88));
                        }
                    }
                }
            }
        }

        public void LoginOperatorToLastOpenedSession(string login)
        {
            var db = new dbDataContext();
            lock (db)
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        var operatorInfo = GetUserInfoByLogin(login);
//                        var prevOperatorInfo = GetUserInfoByLogin(GetOpenedGlobalSession().operator_id);
                        var lastGlobalSession = (from gs in db.GetTable<global_session_t>()
                            where gs.end_session == gs.start_session
                            select gs).SingleOrDefault();
                        if (lastGlobalSession != null)
                        {
                            string lastOperatorId = "null";
                            if (lastGlobalSession.operator_id != null)
                            {
                                lastOperatorId = GetUserInfoByPersonId(lastGlobalSession.operator_id).name;
                            }
                            lastGlobalSession.operator_id = operatorInfo.person_id;
                            try
                            {
                                db.SubmitChanges();
                                TextFileWriter.TextFileWriterInstance()
                                    .RecordLoginTime(operatorInfo.name, lastOperatorId, Options.StaffTypeOperator);
                                MakeLogInRecord(DateTime.Now, operatorInfo.name, operatorInfo.position, lastOperatorId);
                                break;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(31));
                            }

                        }
                    }
                    catch (Exception)
                    {
                        if (i <= 0)
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance()
                                .GetErrorWithLine(1, 88));
                        }
                    }
                }

            }
        }

        public void MakeLogInRecord(DateTime shiftDate, string name, string position, string prevStaffName)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var logIntTable = db.GetTable<shifts_log_in>();
                var shiftLogin = new shifts_log_in
                {
                    log_in_datetime = shiftDate,
                    person_name = name,
                    person_position = position,
                    comments = "Принял(а) смену у " + prevStaffName
                };
                logIntTable.InsertOnSubmit(shiftLogin);
                db.SubmitChanges();
            }
        }

        public List<ShiftsMyClass> GetAllGlobalSessions(int numberOfLastSessons)
        {
            var db = new dbDataContext();
            lock (db)
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        if (numberOfLastSessons > 0)
                        {
                            return (from a in db.GetTable<global_session_t>()
                                orderby a.daily_id descending
                                select new ShiftsMyClass
                                {
                                    DailyId = a.daily_id,
                                    AdministratorID = a.administrator_id,
                                    OperatorId = a.operator_id,
                                    StartTime = a.start_session,
                                    EndTime = a.end_session
                                }).Take(numberOfLastSessons).ToList();
                        }
                    }
                    catch (Exception)
                    {
                        if (i <= 0)
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance()
                                .GetErrorWithLine(1, 88));
                        }
                    }
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

        public days_sessions_t GetDaySessionBySessionId(int sessionId) //, int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from s in db.GetTable<days_sessions_t>()
                    where s.session_id == sessionId
//                    where s.daily_id == dailyId
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

        public List<string> GetAllTablesNames()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from t in db.GetTable<tables_t>()
                    orderby t.playstation_id.Length, t.playstation_id
                    select t.playstation_id).ToList();
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

        public List<Device> GetDevicesList()
        {
            var db = new dbDataContext();
            lock (db)
            {
                var devicesT = (from d in db.GetTable<devices_t>()
                    select d).ToList();
                List<Device> result = devicesT.Select(d => new Device(IPAddress.Parse(d.ip_address))).ToList();
                return result;
            }
        }

        public void UpdatePricesForTimeZone(List<string> playstationsToChange, string timeZoneName, int newPrice)
        {
            var db = new dbDataContext();
            lock (db)
            {
//                for (int i = 0; i < 5; i++)
//                {
                    try
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
//                                break;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                    catch (Exception)
                    {
//                        if (i <= 0)
//                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance()
                                .GetErrorWithLine(1, 88));
//                        }
                    }
//                }
            }
        }

        public void UpdateClientInfo(client_info_t cInfo)
        {
            var db = new dbDataContext();
            lock (db)
            {
                for (int i = 0; i < 5; i++)
                {
                    try
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
                        break;
                    }
                    catch (Exception)
                    {
                        if (i <= 0)
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance()
                                .GetErrorWithLine(1, 88));
                        }
                    }
                }
            }
        }

        public void AddToSessionDiscountSum(int sessionId, double discountToAdd)
        {
            var db = new dbDataContext();
            lock (db)
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        var matchedRecord = (from c in db.GetTable<days_sessions_t>()
                            where c.session_id == sessionId
                            select c).SingleOrDefault();
                        if (matchedRecord != null)
                        {
                            if (matchedRecord.session_discount == 0 || matchedRecord.session_discount == null)
                                matchedRecord.session_discount = discountToAdd;
                            else
                                matchedRecord.session_discount += discountToAdd;
                        }
                        db.SubmitChanges();
                        break;
                    }
                    catch (Exception)
                    {
                        if (i <= 0)
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance()
                                .GetErrorWithLine(1, 88));
                        }
                    }
                }
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
                        Счетчик = days.played_money,
                        Скидка_сессии = (double) sessionDiscount,
                        Оплачено = days.payed_sum
                    }).ToList<DaySessionClass>();
            }
        }

        public DaySessionClass GetDaySessionMyClassBySessionId(int sessionId, List<clients_per_session_t> clientsList)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from days in db.GetTable<days_sessions_t>()
                    orderby days.end_game ascending
                    where days.session_id == sessionId
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
                        Счетчик = days.played_money,
                        Скидка_сессии = (double) sessionDiscount,
                        Оплачено = days.payed_sum
                    }).SingleOrDefault();
            }
        }

        public List<MyString> GetOpenedConsolesWithSessionIds( /*int dailyId, List<clients_per_session_t> clientsList*/)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from days in db.GetTable<days_sessions_t>()
                    where days.daily_id == GetOpenedGlobalSession().daily_id
                    where days.session_state == "opened"
                    orderby days.end_game ascending
                    let startGame = days.start_game
                    where startGame != null
                    let endGame = days.end_game
                    where endGame != null
                    let sessionDiscount = days.session_discount
                    where sessionDiscount != null
                    select new MyString(days.playstation_id)).ToList<MyString>();
            }
        }

        public void EditDevice(int deviceId, string ipAddress)
        {
            var db = new dbDataContext();
            lock (db)
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        var device = (from d in db.GetTable<devices_t>()
                            where d.device_id == deviceId
                            select d).SingleOrDefault();
                        if (device != null)
                        {
                            device.ip_address = ipAddress;
                        }
                        db.SubmitChanges();
                        break;
                    }
                    catch (Exception)
                    {
                        if (i <= 0)
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance()
                                .GetErrorWithLine(1, 88));
                        }
                    }
                }
            }
        }

        public void TransferOpenedSessionToNextGlobalSession(int sessionId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        var sessionToTransfer = (from s in db.GetTable<days_sessions_t>()
                            where s.session_id == sessionId
                            select s).SingleOrDefault();
//                sessionToTransfer.daily_id = sessionToTransfer.daily_id + 1;
                        var lastOpenedGlobalSession = GetOpenedGlobalSession();
                        int dailyId = GetOpenedGlobalSession().daily_id;
                        if (sessionToTransfer != null)
                        {
                            sessionToTransfer.daily_id = lastOpenedGlobalSession.daily_id;
                            AddMoneyToCash(sessionToTransfer.payed_sum, dailyId);
                            db.SubmitChanges();
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        if (i <= 0)
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance()
                                .GetErrorWithLine(1, 88));
                        }
                    }
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
            var clientsInfo = Instancedb().GetAllClients();
            var clientsInSession = (from c in clientsList
                from allclients in clientsInfo
                where c.session_id == sessionId
                where allclients.client_id == c.client_id
                select allclients.name).ToList();

            if (clientsInSession.Count > 0)
            {
                result = clientsInSession.Aggregate(result, (current, s) => current + (s + "; "));
                result = result.Remove(result.Length - 2);
            }
            return result;
        }

        public List<DaySessionForShiftReport> GetAllDaySessionsInShift(int dailyId)
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
                    where d.session_state != "opened"
                    select new DaySessionForShiftReport
                    {
                        Сессия = d.client_num, //to see manager num of clients
                        Приставка = d.playstation_id,
                        Начало = (DateTime) startGame,
                        Конец = (DateTime) endGame,
                        Оставшееся_время = GetTimeLeft((DateTime) endGame),
                        //----------------------------------------------------------
                        Клиент = ListToString(d.session_id, clientsList),
                        //to show all clients in one line and column instead of one
                        Комментарии = d.comments,
                        Счетчик = d.played_money,
                        Скидка_сессии = (double) d.session_discount,
                        Оплачено = d.payed_sum
                    }).ToList<DaySessionForShiftReport>();
                return daySessionsReport;
            }
        }

        public List<DaySessionsForLastSessions> GetLastDaySessions(int numOfLastSessions)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var clientsList = (from c in db.GetTable<clients_per_session_t>()
                    select c).ToList();
                var daySessionsReport = (from d in db.GetTable<days_sessions_t>()
                    from c in db.GetTable<clients_per_session_t>()
                    orderby d.end_game descending
                    where d.daily_id == GetOpenedGlobalSession().daily_id
                    where c.session_id == d.session_id
                    let startGame = d.start_game
                    where startGame != null
                    let endGame = d.end_game
                    where endGame != null
                    select new DaySessionsForLastSessions
                    {
                        Сессия = d.session_id, //to see manager num of clients
                        Приставка = d.playstation_id,
                        Начало = (DateTime) startGame,
                        Конец = (DateTime) endGame,
                        Клиент = ListToString(d.session_id, clientsList),
                        Счетчик = d.played_money,
                        Скидка_сессии = (double) d.session_discount,
                        Оплачено = d.payed_sum
                    }).ToList();
                return daySessionsReport;
            }
        }

        public void ChangePlaystation(DaySessionClass ds, string newPlaystation, string comments)
        {
            var db = new dbDataContext();
            lock (db)
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        var matchDs = (from os in db.GetTable<days_sessions_t>()
                            where os.session_id == ds.Сессия
                            select os).SingleOrDefault();
                        if (matchDs != null)
                        {
                            UpdatePlaystationState(matchDs.playstation_id, "free");
                            db.SubmitChanges();
                            matchDs.playstation_id = newPlaystation;
                            TimeSpan paidTime =
                                AddNewSessionController.AddNewSessionControllerInstance()
                                    .UpdateTimeLeft((decimal) matchDs.payed_sum, newPlaystation, 0, 18900, DateTime.Now);
                            if (matchDs.start_game != null) matchDs.end_game = matchDs.start_game.Value.Add(paidTime);
                            if (String.IsNullOrWhiteSpace(matchDs.comments))
                            {
                                matchDs.comments = "Пересел с " + ds.Приставка + " на " + newPlaystation + " " +
                                                   comments;
                            }
                            else
                            {
                                matchDs.comments += "\n" + "Пересел с " + ds.Приставка + " на " + newPlaystation + " " +
                                                    comments;
                            }
                            UpdatePlaystationState(newPlaystation, "busy");
                            //                    matchDs.session_discount += 5;// Discount because of replacing
                            //                    matchDs.end_game
                            db.SubmitChanges();
                            break;
                        }
                        MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(39));
                    }
                    catch (Exception)
                    {
                        if (i <= 0)
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance()
                                .GetErrorWithLine(1, 88));
                        }
                    }
                }

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
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        Table<devices_t> devicesTable = db.GetTable<devices_t>();
                        var device = new devices_t
                        {
                            device_id = deviceId,
                            ip_address = ipAddress
                        };
                        devicesTable.InsertOnSubmit(device);
                        db.SubmitChanges();
//                        break;
//                List<string> allConsoles = GetAllTables().Select(t => t.playstation_id).ToList();

                        for (int j = 1; j <= 16; j++)
                        {
                            InsertNewEndPoint(deviceId, j);
                        }
                    }
                    catch (Exception)
                    {
                        if (i <= 0)
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance()
                                .GetErrorWithLine(1, 88));
                        }
                        else
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(39));
                        }
                    }
                }
            }
        }


        public void AddNewDiscountStep(string name, double requrements, double discount)
        {
            var db = new dbDataContext();
            lock (db)
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        var match = (from m in db.GetTable<steps_of_discount_upgrading>()
                            where m.name == name
                            select m).SingleOrDefault();
                        if (match == null)
                        {
                            Table<steps_of_discount_upgrading> stepsOfDiscountUpgradingsTable =
                                db.GetTable<steps_of_discount_upgrading>();
                            var steps = new steps_of_discount_upgrading
                            {
                                name = name,
                                discount = discount,
                                required_played_sum = requrements
                            };
                            stepsOfDiscountUpgradingsTable.InsertOnSubmit(steps);
                            db.SubmitChanges();
                            break;
                        }
                        MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(27));
                    }
                    catch (Exception)
                    {
                        if (i <= 0)
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance()
                                .GetErrorWithLine(1, 88));
                        }
                        else
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(39));
                        }
                    }
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

        public void DeleteClient(string clientId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<client_info_t> personalInfoTable = db.GetTable<client_info_t>();
                var client = (from c in db.GetTable<client_info_t>()
                    where c.client_id == clientId
                    select c).SingleOrDefault();
                if (client != null)
                {
                    personalInfoTable.DeleteOnSubmit(client);
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(52));
                }
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

        public void AddNewItem(string itemId, string categoryName, double cost, string description)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var match = (from i in db.GetTable<items_table>()
                    where i.item_id == itemId
                    select i).SingleOrDefault();
                if (match == null)
                {
                    Table<items_table> itemsTable = db.GetTable<items_table>();
                    var item = new items_table
                    {
                        item_id = itemId,
                        item_num = db.GetTable<items_table>().Count(),
                        number_left = 300,
                        category_name = categoryName,
                        cost = cost,
                        item_description = description
                    };

                    itemsTable.InsertOnSubmit(item);
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(42));
                }
            }
        }

        public void RemoveItem(string itemId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var match = (from i in db.GetTable<items_table>()
                    where i.item_id == itemId
                    select i).SingleOrDefault();
                if (match != null)
                {
                    Table<items_table> itemsTable = db.GetTable<items_table>();
                    itemsTable.DeleteOnSubmit(match);
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(42));
                }
            }
        }

        public List<SoldItemMyClass> GetListOfSoldItems(int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from i in db.GetTable<sold_bar_history_table>()
                    where i.daily_id == dailyId
                    orderby i.sale_time
                    select new SoldItemMyClass
                    {
                        Id = i.sale_id,
                        Время = (DateTime) i.sale_time,
                        Наименование = i.item_id,
                        Количество = (int) i.amount_sold
                    }).ToList();
            }
        }

        public void ChangeItemAmount(string itemId, int newNumber)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var match = (from i in db.GetTable<items_table>()
                    where i.item_id == itemId
                    select i).SingleOrDefault();
                if (match != null)
                {
                    match.number_left = newNumber;
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(42));
                }
            }
        }

        public void ChangeItemNumber(string itemId, int newNumber)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var match = (from i in db.GetTable<items_table>()
                    where i.item_id == itemId
                    select i).SingleOrDefault();
                if (match != null)
                {
                    match.item_num = newNumber;
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(42));
                }
            }
        }

        public List<sold_bar_history_table> GetListOfSoldItemId(string itemId, int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from i in db.GetTable<sold_bar_history_table>()
                    where i.item_id == itemId
                    where i.daily_id == dailyId
                    select i).ToList();
            }
        }

        public List<AllItemsMyClass> GetAllItems()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from i in db.GetTable<items_table>()
                    orderby i.item_num
                    select new AllItemsMyClass
                    {
                        Num = (int) i.item_num,
                        ItemId = i.item_id,
                        CategoryName = i.category_name,
                        Cost = (double) i.cost,
                        Description = i.item_description,
                        NumberLeft = (int) i.number_left
                    }).ToList<AllItemsMyClass>();
            }
        }

        public List<string> GetAllItemsNames()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from i in db.GetTable<items_table>()
                    orderby i.item_num
                    select i.item_description).ToList<string>();
            }
        }

        public List<BarRevisionMyClass> GetAllBarRevisionItems(int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from i in db.GetTable<bar_revision_t>()
                    where i.daily_id == dailyId
                    orderby i.bar_item_num
                    select new BarRevisionMyClass
                    {
//                            Номер = (int)i.bar_item_num,
                        Наименование = i.item_id,
                        Продано = (int) i.amount_sold,
                        Куплено = (int) i.amount_bought,
                        Осталось = (int) i.left_num
                    }).ToList<BarRevisionMyClass>();
            }
        }

        public List<ListOfItemsWithPrice> GetListOfItemsWithPrice()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from i in db.GetTable<items_table>()
                    orderby i.item_num
                    select new ListOfItemsWithPrice
                    {
                        Категория = i.category_name,
                        Наименование = i.item_id,
                        Цена = (double) i.cost,
//                            Осталось = (int)i.number_left
                    }).ToList<ListOfItemsWithPrice>();
            }
        }

        public ListOfItemsWithPrice GetItemDataById(string itemId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from i in db.GetTable<items_table>()
                    where i.item_id == itemId
                    select new ListOfItemsWithPrice
                    {
                        Категория = i.category_name,
                        Наименование = i.item_id,
                        Цена = (double) i.cost
                    }).SingleOrDefault();
            }
        }     
        public items_table GetItemDataByName(string itemName)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from i in db.GetTable<items_table>()
                    where i.item_description == itemName
                    select i).SingleOrDefault();
            }
        }

        public void SellItem(string itemId, int number, DateTime timeOfSelling, double sum)
        {
            var db = new dbDataContext();
            lock (db)
            {
                int dailyId = GetLastOpenedGlobalSessionDailyId();
                Table<sold_bar_history_table> soldBarTable = db.GetTable<sold_bar_history_table>();
                var soldItem = new sold_bar_history_table
                {
                    daily_id = dailyId,
                    amount_sold = number,
                    item_id = itemId,
                    sale_time = timeOfSelling,
                    comments = " "
                };
                soldBarTable.InsertOnSubmit(soldItem);
                db.SubmitChanges();
                AddMoneyToCash(sum, dailyId);
                AddItemToRevision(itemId, number*(-1));
            }
        }

        public void DeleteSoldItem(int saleId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                int dailyId = GetLastOpenedGlobalSessionDailyId();
                var item = (from i in db.GetTable<sold_bar_history_table>()
                    where i.sale_id == saleId
                    select i).SingleOrDefault();
                if (item != null)
                {
                    AddMoneyToCash((double) (GetItemDataById(item.item_id).Цена*item.amount_sold), dailyId);
                    Table<sold_bar_history_table> soldItemsTable = db.GetTable<sold_bar_history_table>();
                    soldItemsTable.DeleteOnSubmit(item);
                    db.SubmitChanges();
                }
            }
        }

        public void AddItemToRevision(string itemId, int newNumber)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var match = (from i in db.GetTable<items_table>()
                    where i.item_id == itemId
                    select i).SingleOrDefault();
                if (match != null)
                {
                    match.number_left += newNumber;
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(42));
                }
            }
        }

//        public void AddItemsToRevision(string itemId, int amountsold)
//        {
//            var db = new dbDataContext();
//            lock (db)
//            {
//
//            }
//        }

        public void AddNewOrUpdateBarRevisionRecord(int dailyId, string itemId, int amountSold, int amountBought,
            int left, int num)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var match = (from i in db.GetTable<bar_revision_t>()
                    where i.item_id == itemId
                    where i.daily_id == dailyId
                    select i).SingleOrDefault();
                if (match == null)
                {
                    Table<bar_revision_t> soldBarTable = db.GetTable<bar_revision_t>();
                    var revisionItem = new bar_revision_t
                    {
                        bar_item_num = num,
                        daily_id = dailyId,
                        item_id = itemId,
                        amount_sold = amountSold,
                        amount_bought = amountBought,
                        left_num = left
                    };
                    soldBarTable.InsertOnSubmit(revisionItem);
                    db.SubmitChanges();
                }
                else
                {
                    match.bar_item_num = num;
                    match.amount_sold = amountSold;
                    match.amount_bought = amountBought;
                    match.left_num = left;
                    db.SubmitChanges();
                }
            }
        }

        public void AddNewGlobalSession(string adminId, string operatorId, DateTime date)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var lastAdmin =
                    GetUserInfoByPersonId(
                        GetGlobalSessionByDailyId(GetLastOpenedGlobalSessionDailyId()).administrator_id).name;
                Table<global_session_t> gst = db.GetTable<global_session_t>();
                var globSess = new global_session_t
                {
                    administrator_id = adminId,
                    start_session = date,
                    end_session = date
                };

                if (operatorId != "no operator")
                {
                    globSess.operator_id = operatorId;
                }
                MakeLogInRecord(DateTime.Now, GetUserInfoByPersonId(globSess.administrator_id).name, GetUserInfoByPersonId(globSess.administrator_id).position, lastAdmin);
                gst.InsertOnSubmit(globSess);
                db.SubmitChanges();
            }

        }

        public void AddMoneyToCash(double cash, int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
//                int dId = GetOpenedGlobalSession().daily_id;
                var getCashFromCurrentSession = (from c in db.GetTable<cash_t>()
                    where c.daily_id == dailyId
                    select c).SingleOrDefault();
                if (getCashFromCurrentSession != null)
                {
                    getCashFromCurrentSession.cash_amount = getCashFromCurrentSession.cash_amount + cash;
                    db.SubmitChanges();
                }
                else
                {
                    var cashTable = db.GetTable<cash_t>();
                    var cashT = new cash_t {cash_amount = cash, daily_id = dailyId};
                    cashTable.InsertOnSubmit(cashT);
                    db.SubmitChanges();
                }
            }
        }

        public void AssignNewValueToCash(double newCashValue, int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                //                int dId = GetOpenedGlobalSession().daily_id;
                var getCashFromCurrentSession = (from c in db.GetTable<cash_t>()
                    where c.daily_id == dailyId
                    select c).SingleOrDefault();
                if (getCashFromCurrentSession != null)
                {
                    getCashFromCurrentSession.cash_amount = newCashValue;
                    db.SubmitChanges();
                }
                else
                {
                    var cashTable = db.GetTable<cash_t>();
                    var cashT = new cash_t {cash_amount = newCashValue, daily_id = dailyId};
                    cashTable.InsertOnSubmit(cashT);
                    db.SubmitChanges();
                }
            }
        }

        public double? GetCashFromDailyId(int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from tb in db.GetTable<cash_t>()
                    where tb.daily_id == dailyId
                    select tb.cash_amount).SingleOrDefault();
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

        public List<steps_of_discount_upgrading> GetAllDiscountSteps()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from sd in db.GetTable<steps_of_discount_upgrading>()
                    orderby sd.required_played_sum
                    select sd).ToList();
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

        public double GetNightTimePriceForPlaystation(string playstationId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                double? price = (from p in db.GetTable<playstation_timezone>()
                    where p.timezone_name == "NightTime"
                    where p.playstation_id == playstationId
                    select p.timezone_cost_per_hour).SingleOrDefault();
                return (price ?? 0);
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
                    orderby t.timezone_start ascending
                    select t).ToList();
            }
        }

        public List<string> GetAllTimeZoneNames()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from t in db.GetTable<timezones_t>()
                    orderby t.timezone_start ascending
                    select t.timezone_name).ToList();
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

//        public client_info_t GetClientInfoByName(string name,string id)
//        {
//            var db = new dbDataContext();
//            lock (db)
//            {
//                return (from c in db.GetTable<client_info_t>()
//                        where c.name == name
//                        select c).SingleOrDefault();
//            }
//        }
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

        public List<ClientMyClass> GetAllClientsForEditing()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from lc in db.GetTable<client_info_t>()
                    select new ClientMyClass
                    {
                        ID_Клиента = lc.client_id,
                        Имя = lc.name,
                        Email = lc.email,
                        День_рождение = (DateTime) lc.birthday,
                        Дата_активации = lc.activation_date,
                        Наигранная_сумма = lc.played_sum,
                        Персональная_скидка = (double) lc.pers_discount,
                        Телефон = lc.phone
                    }).ToList();

            }
        }


        public int GetLastOpenedGlobalSessionDailyId() //used to get last dailyID
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

        public int GetLastClientNumInSession(int dailyId) //for getting number for next client
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
                    played_money = daySession.played_money,
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

        public void DeleteDiscountStep(string name)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var match = (from m in db.GetTable<steps_of_discount_upgrading>()
                    where m.name == name
                    select m).SingleOrDefault();
                if (match != null)
                {
                    Table<steps_of_discount_upgrading> stepsOfDiscountUpgradingsTable =
                        db.GetTable<steps_of_discount_upgrading>();
                    stepsOfDiscountUpgradingsTable.DeleteOnSubmit(match);
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(28));
                }
            }
        }

        public void SwitchOnConsole(string consoleId, List<Endpoint> endpoints)
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
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(1));
                        //no connection with device

                } //Sending singnal to board
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
                    MessageBox.Show(
                        timeZoneNameToDelete + ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(1),
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
                                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(2) +
                                                    timeZoneNameToDelete); //cannot delete playstation cost
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
                    if (clientId == Options.OptionsInstance().UsualClient)
                    {
                        clientsPerSessionT.session_id = lastInsertedDaySession.session_id;
                        clientsPerSessionT.client_id = Options.OptionsInstance().UsualClient;
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
                                payed_sum = 0.0
                                //---------------------------------------------------------------------------------DIVIDE BEFORE !!!!!!!!
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
//                    dsc.Счетчик = dsc.Оплачено - dsc.Счетчик;
//                }
                sessionIdtoDelete.payed_sum = dsc.Оплачено;
                sessionIdtoDelete.played_money = dsc.Счетчик;
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

        public DaySessionClass AccountDiscountMoney(DaySessionClass dsc)
        {
            List<clients_per_session_t> clientsOnSession = GetListOfClientsPerExactSession(dsc.Сессия);
//-----------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------------Since client stoped play before timer, algorithm--------------------------------------------------- 
//--------------------------------------------find the highest discount size and substract from end sum,----------------------------------------- 
//--------------------------------------------in order client do not get discount as change money------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
            if (clientsOnSession.Count >= 1)
            {
                double realDiscount = 0; //applied discount
                foreach (clients_per_session_t c in clientsOnSession)
                {
                    var clientDiscount = GetClientInfoById(c.client_id).pers_discount;
                    if (clientDiscount > realDiscount)
                    {
                        realDiscount = (double) clientDiscount;
                    }
                }
                double bonusMoney = ((dsc.Оплачено*realDiscount)/(100 + realDiscount));
                dsc.Оплачено = dsc.Оплачено - bonusMoney;
                if ((dsc.Счетчик) > (dsc.Оплачено - bonusMoney)) //if played less than was real paid money
                {
                    dsc.Скидка_сессии = dsc.Счетчик - dsc.Оплачено - bonusMoney;
                }
                else if (dsc.Счетчик <= (dsc.Оплачено - bonusMoney))
                {
                    dsc.Скидка_сессии = 0;
                }
            }
            return dsc;
//-----------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
        }

        public void AddPlayedMoneyToClientAndChangeHisDiscount(string clientId, double moneyToAdd)
        {
            if (moneyToAdd > 0)
            {
                var db = new dbDataContext();
                lock (db)
                {
                    var clientInfo = (from c in db.GetTable<client_info_t>()
                        where c.client_id == clientId
                        select c).SingleOrDefault();
                    if (clientInfo != null)
                    {
                        clientInfo.played_sum += moneyToAdd;
                        var allDicountLevels = GetAllDiscountSteps();
                        var maxDiscount = allDicountLevels[0].discount;
                        foreach (var step in allDicountLevels)
                        {
                            if (clientInfo.played_sum >= step.required_played_sum)
                            {
                                maxDiscount = step.discount;
//                                clientInfo.pers_discount = step.discount;
                            }
                        }
//                        if (maxDiscount > clientInfo.pers_discount)
//                        {
                        clientInfo.pers_discount = maxDiscount;

                        db.SubmitChanges();
//                        }
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
                var clients = GetListOfClientsPerExactSession(dsc.Сессия);

                var clientInfo = (from c in db.GetTable<client_info_t>()
                    where c.name == dsc.Клиент
                    where c.client_id == clients[0].client_id
                    select c).SingleOrDefault();

                if (sessionIdtoDelete == null) return;

                sessionIdtoDelete.end_game = endTime;
                sessionIdtoDelete.session_state = "closed";
                sessionIdtoDelete.payed_sum = dsc.Оплачено;
                if (clientInfo != null)
                {
                    clientInfo.played_sum += dsc.Счетчик;
                }
                //                if (endTime - dsc.Начало < TimeSpan.FromHours(1))
                //                {
                //                    dsc.Счетчик = dsc.Оплачено - dsc.Счетчик;
                //                }
                sessionIdtoDelete.played_money = dsc.Счетчик;

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
                AddPlayedMoneyToClientAndChangeHisDiscount(clients[0].client_id, dsc.Счетчик);
            }
        }

//-----------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
//--------------------------------------When client will be able to store money on the card------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------This algorithm help to acount how much money should be paid by each client(if more than 1)--------------
//---------------------------------------Account that each player will pay equal sum of money, but if one of the cards do not have enough money--
//----------------------------------------another will pay for him!------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
//        public void CloseSessionWithCard(DaySessionClass dsc, string comments, DateTime endTime)
//        {
//            var db = new dbDataContext();
//            lock (db)
//            {
//                int dayId = GetOpenedGlobalSession().daily_id;
//                var sessionIdtoDelete = (from s in db.GetTable<days_sessions_t>()
//                                         where s.daily_id == dayId
//                                         where s.session_id == dsc.Сессия
//                                         select s).SingleOrDefault();
//                if (sessionIdtoDelete == null) return;
//                sessionIdtoDelete.end_game = endTime;
//                sessionIdtoDelete.session_state = "closed";
//                sessionIdtoDelete.money_left = dsc.Счетчик;
//                List<clients_per_session_t> clientsOnSession = GetListOfClientsPerExactSession(dsc.Сессия);
//                double playedMoney = dsc.Оплачено - dsc.Счетчик;//sessionIdtoDelete.payed_sum - sessionIdtoDelete.money_left;
//                double eachPlayerShouldPay = playedMoney/clientsOnSession.Count;
//                double nextShouldpayAdditional = 0;
//                do
//                {
//                    foreach (var client in clientsOnSession)
//                    {
//                        var moneyOnClientCard = GetClientSavingsById(client.client_id);
//                        if (moneyOnClientCard != null)
//                        {
//                            if (moneyOnClientCard.savings >= (eachPlayerShouldPay + nextShouldpayAdditional))
//                            {
//                                playedMoney = playedMoney - (eachPlayerShouldPay + nextShouldpayAdditional);
////                                moneyOnClientCard.savings = moneyOnClientCard.savings - (eachPlayerShouldPay + nextShouldpayAdditional);
//                                ChangeSavingsValueOfClient(moneyOnClientCard.client_id,
//                                    (moneyOnClientCard.savings - (eachPlayerShouldPay + nextShouldpayAdditional))*-1);
//                                nextShouldpayAdditional = 0;
//                            }
//                            else
//                            {
//                                nextShouldpayAdditional = eachPlayerShouldPay - moneyOnClientCard.savings;
//                                playedMoney = playedMoney - moneyOnClientCard.savings;
////                                moneyOnClientCard.savings = 0;
//                                ChangeSavingsValueOfClient(moneyOnClientCard.client_id, 0);
//                            }
//                        }
////                        try
////                        {
////                            db.SubmitChanges();
////                        }
////                        catch (Exception)
////                        {
////                            MessageBox.Show("Error during closing clients occured!");
////                        }
//                    }
//                } while (nextShouldpayAdditional > 0 && playedMoney > 0);
//
//
//                if (String.IsNullOrWhiteSpace(sessionIdtoDelete.comments))
//                {
//                    sessionIdtoDelete.comments = comments;
//                }
//                else
//                {
//                    sessionIdtoDelete.comments += "\n" + comments;
//                }
//                UpdatePlaystationState(dsc.Приставка, "free");
//                while (true)
//                {
//                    try
//                    {
//                        db.SubmitChanges();
//                        break;
//                    }
//                    catch
//                    {
//                        MessageBox.Show(
//                            ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(3));
//                    }
//                }
//            }
//        }
//-----------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------------------------
        public void ChangeSavingsValueOfClient(string clientId, double sumToAdd)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var clientIdToChangeSavings = (from c in db.GetTable<account_savings_t>()
                    where c.client_id == clientId
                    select c).SingleOrDefault();
//                var paymentTable = (from p in db.GetTable<payments_t>()
//                                        where )
                if (clientIdToChangeSavings != null)
                {
                    clientIdToChangeSavings.savings += sumToAdd;
                    try
                    {
                        db.SubmitChanges();
                        InsertNewPaymentToClientHistory(clientId, sumToAdd);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(4) +
                                        clientIdToChangeSavings.client_id);
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

        public void InsertExpensesRecord(double money, string comments, DateTime expensesTime)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<expenses_t> expensesTable = db.GetTable<expenses_t>();
                var expenses = new expenses_t
                {

                    daily_id = GetLastOpenedGlobalSessionDailyId(),
                    comments = comments,
                    cash_amount = money,
                    expenses_time = expensesTime
                };
                expensesTable.InsertOnSubmit(expenses);
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

        public List<withdrow_money_t> GetAllWithdrawnDataOnDailyId(int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var allMoney = (from m in db.GetTable<withdrow_money_t>()
                    where m.daily_id == dailyId
                    select m).ToList();
                return allMoney;
            }
        }

        public List<expenses_t> GetAllExpensesOnDailyId(int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from m in db.GetTable<expenses_t>()
                    where m.daily_id == dailyId
                    select m).ToList();
            }
        }

        public void DeleteExpense(int expensesId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                var item = (from i in db.GetTable<expenses_t>()
                    where i.expense_id == expensesId
                    select i).SingleOrDefault();
                if (item != null)
                {
                    Table<expenses_t> expensesTable = db.GetTable<expenses_t>();
                    expensesTable.DeleteOnSubmit(item);
                    db.SubmitChanges();
                }
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

        public void ExtendGameTimeWithUsualClient(DaySessionClass sessionToExtend, TimeSpan timeToExtend,
            double moneyToExtend)
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
                    if (String.IsNullOrWhiteSpace(session.comments))
                    {
                        session.comments = "Доплачено на" + timeToExtend + " и " + moneyToExtend + " сом.";
                    }
                    else
                    {
                        session.comments += "\n" + "Доплачено на" + timeToExtend + " " + moneyToExtend + " сом.";
                    }
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

        public void ExtendGameTimeWithClientWithDiscountCard(DaySessionClass sessionToExtend, TimeSpan timeOfgame,
            double moneyOnCard)
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

        public void InsertNewDiscountRequirements(TimeSpan? hours, string itemsId, int? numOfItem, double? moneySum)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<promo_requirement> discountRequirementsTable = db.GetTable<promo_requirement>();
                var discountRequirement = new promo_requirement
                {
                    promo_requirements_hours = hours,
                    promo_requirements_item_to_buy = itemsId,
                    promo_requirements_money_sum = moneySum,
                    promo_requirements_num_of_item = numOfItem
                };
                try
                {
                    discountRequirementsTable.InsertOnSubmit(discountRequirement);
                    db.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(54));
                }
            }
        }

        public void InsertNewDiscountBonus(TimeSpan? hours, string itemsId, int? numOfItem, double? moneySum,
            double? sumDiscount)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<promo_bonus> discountBonusesTable = db.GetTable<promo_bonus>();
                var promoBonus = new promo_bonus
                {
                    promo_bonus_hours = hours,
                    promo_bonus_item_to_buy = itemsId,
                    promo_bonus_money_sum = moneySum,
                    promo_bonus_num_of_item = numOfItem,
                    promo_bonus_sum_discount = sumDiscount
                };
                try
                {
                    discountBonusesTable.InsertOnSubmit(promoBonus);
                    db.SubmitChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(54));
                }
            }
        }

        public void InsertNewDiscount(string description, DateTime? start, DateTime? end, string state, string timezones,
            string playstations, string auditory)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<promos_t> discountTable = db.GetTable<promos_t>();
                if (start != null)
                {
                    if (end != null)
                    {
                        var discount = new promos_t
                        {
                            promo_description = description,
                            promo_auditory = auditory,
                            promo_start = (DateTime) start,
                            promo_end = (DateTime) end,
                            promo_playstations = playstations,
                            promo_state = state,
                            promo_timezones = timezones,
                            discount_bonus_id = GetLastInsertedRecordIntodiscountBonus().promo_bonus_id,
                            promo_requirements_id =
                                GetLastInsertedRecordIntoDiscountRequirement().promo_requirement_id
                        };
                        try
                        {
                            discountTable.InsertOnSubmit(discount);
                            db.SubmitChanges();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(54));
                        }
                    }
                }
            }
        }

        private promo_bonus GetLastInsertedRecordIntodiscountBonus()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from i in db.GetTable<promo_bonus>()
                        orderby i.promo_bonus_id descending
                    select i).FirstOrDefault();
            }
        }

        private promo_requirement GetLastInsertedRecordIntoDiscountRequirement()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from i in db.GetTable<promo_requirement>()
                        orderby i.promo_requirement_id descending
                    select i).FirstOrDefault();
            }
        }

        public List<promos_t> GetAllDiscounts()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from d in db.GetTable<promos_t>()
                        orderby d.promo_end ascending
                    select d).ToList();
            }
        }

        public promo_requirement GetRequirementById(int reqId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from d in db.GetTable<promo_requirement>()
                        where d.promo_requirement_id == reqId
                    select d).SingleOrDefault();
            }
        }
        public BonusesMyClass GetBonusById(int bonusId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from d in db.GetTable<promo_bonus>()
                        where d.promo_bonus_id == bonusId
                    select new BonusesMyClass
                    {
                        BonusId = d.promo_bonus_id,
                        BonusDiscountSum = d.promo_bonus_sum_discount,
                        BonusHours = d.promo_bonus_hours,
                        BonusItemToBuy = d.promo_bonus_item_to_buy,
                        BonusMoneySum = d.promo_bonus_money_sum,
                        BonusNumOfItems = d.promo_bonus_num_of_item
                    }).SingleOrDefault();
            }
        }

        public void AddNewPromoUsage(int sessionid, string comment, double sum)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<promo_usage_history> usageHistoryTable = db.GetTable<promo_usage_history>();
                var usageHistory = new promo_usage_history
                {
                    daily_id = GetLastOpenedGlobalSessionDailyId(),
                    promo_bonus_comment = comment,
                    promo_discount_sum = sum,
                    session_id = sessionid
                };
                usageHistoryTable.InsertOnSubmit(usageHistory);
                db.SubmitChanges();
            }
        }

        public List<promo_usage_history> GetAllPromoUsageHistoryByDayilyId(int dailyId)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from u in db.GetTable<promo_usage_history>()
                    where u.daily_id == dailyId
                    select u).ToList();
            }
        }

//        public List<shifts_log_in> GetAllLogInsInTheDate(DateTime lastGlobalSessionStartDate)
//        {
//            var startDate = new DateTime();
//            var endDate = new DateTime();
//            if (lastGlobalSessionStartDate.Hour > 12)
//            {
//
//            }
//        }

    }
}
