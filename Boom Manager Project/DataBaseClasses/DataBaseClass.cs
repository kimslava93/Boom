using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.DataBaseClasses
{
    public class DataBaseClass
    {
        private static DataBaseClass _dbClass;
//        private dbDataContext _db;
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

        public global_session_t GetOpenedSession()
        {
            var db = new dbDataContext();
            lock (db)
            {
                var openedSession = (from cs in db.GetTable<global_session_t>()
                    where cs.end_session == cs.start_session
                    select cs).SingleOrDefault();

                return openedSession;
            }
        }

        public List<clients_per_session_t> GetListOfClientsPerSessionT()
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from c in db.GetTable<clients_per_session_t>()
                    select c).ToList();
            }
        }

        public List<DaySessionClass> GetDaySession(int dailyId, List<clients_per_session_t> clientsList)
        {
            var db = new dbDataContext();
            lock (db)
            {
                return (from days in db.GetTable<days_sessions_t>()
                    where days.daily_id == dailyId
                    where days.session_state == "opened"
                    orderby days.money_left ascending
                    let startGame = days.start_game
                    where startGame != null
                    let endGame = days.end_game
                    where endGame != null
                    let sessionDiscount = days.session_discount
                    where sessionDiscount != null
                    select new DaySessionClass
                    {
                        SessionId = days.session_id,
                        PlaystationId = days.playstation_id,
                        StartGame = (DateTime) startGame,
                        EndGame = (DateTime) endGame,
                        TimeLeft = GetTimeLeft((DateTime) endGame),
                        //----------------------------------------------------------
                        ClientId = ListToString(days.session_id, clientsList),
                        //to show all clients in one line and column instead of one as string
                        MoneyLeft = days.money_left,
                        SessionDiscount = (double) sessionDiscount,
                        PayedSum = days.payed_sum
                    }).ToList<DaySessionClass>();
            }
        }

        private TimeSpan GetTimeLeft(DateTime end)
        {
            TimeSpan result = end.Subtract( DateTime.Now);
            return new TimeSpan(result.Days, result.Hours, result.Minutes, result.Seconds);
        }


        private string ListToString(int sessionId, IEnumerable<clients_per_session_t> clientsList)
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

        public void AddNewUser(personal_info_t userInfo)
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

        public void AddNewGlobalSession(string adminID, string operatorID, DateTime date)
        {
            var db = new dbDataContext();
            lock (db)
            {
                Table<global_session_t> gst = db.GetTable<global_session_t>();
                var globSess = new global_session_t
                {
                    administrator_id = adminID,
                    operator_id = operatorID,
                    start_session = date,
                    end_session = date
                };

                gst.InsertOnSubmit(globSess);
                db.SubmitChanges();
            }
        }
        public List<tables_t> GetAllFreeTables()
        {
            var db = new dbDataContext();
            return (from tb in db.GetTable<tables_t>()
                orderby tb.playstation_id.Length ascending, tb.playstation_id ascending
                where tb.playstation_state == "free"
                select tb).ToList();
        }

        public double? GetPriceForPlaystation(string playstationId, string currentTimeZone)
        {
            var db = new dbDataContext();
            double? price = (from p in db.GetTable<playstation_timezone>()
                             where p.timezone_name == currentTimeZone
                             where p.playstation_id == playstationId
                             select p.timezone_cost_per_hour).SingleOrDefault();
            return price;
        }
        public List<timezones_t> GetTimeZones()
        {
            var db = new dbDataContext();
            return (from t in db.GetTable<timezones_t>()
                select t).ToList();
        }

        public client_info_t GetClientInfoById(string id)
        {
            var db = new dbDataContext();
            return (from c in db.GetTable<client_info_t>()
                where c.client_id == id
                select c).SingleOrDefault();
        }
    }
}
