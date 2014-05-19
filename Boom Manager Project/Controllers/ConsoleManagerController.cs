using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using LINQ_test;

namespace Boom_Manager_Project
{
    class ConsoleManagerController
    {
//        private List<playstation_timezone> _playstationPrices; 
        private static ConsoleManagerController _consoleManagerController;

        public static ConsoleManagerController ConsoleManagerControllerInstance()
        {
            return _consoleManagerController ?? (_consoleManagerController = new ConsoleManagerController());
        }

        public List<MyString> GetConsolesList()
        {
            var listOfAllTables = DataBaseClass.Instancedb().GetAllTables();
            return (from t in listOfAllTables
                    orderby t.playstation_id.Length, t.playstation_id
                select new MyString(t.playstation_id)).ToList();
        }

        public string GetStateOfExactConsole(string consoleId)
        {
            var listOfAllTables = DataBaseClass.Instancedb().GetAllTables();
            return (from c in listOfAllTables
                where c.playstation_id == consoleId
                select c.playstation_state).SingleOrDefault();
        }
        public DateTime GetOrderTimeOfExactConsole(string consoleId)
        {
            var listOfAllTables = DataBaseClass.Instancedb().GetAllTables();
            var result = (from c in listOfAllTables
                    where c.playstation_id == consoleId
                    select c.order_time).SingleOrDefault();
            if (result != null) return (DateTime) result;
            return new DateTime();
        }

        public Color GetColorOfStateCb(string state)
        {
            if (state == "free")
            {
                return Color.Chartreuse;
            }
            return Color.Crimson;
        }
        public void UpdateConsolePriceListInfo(string consoleId)
        {
            var listOfAllTables = DataBaseClass.Instancedb().GetAllTimeZonePrices();
            if (!String.IsNullOrEmpty(consoleId))
            {
                var result = (from p in listOfAllTables
                    where p.playstation_id == consoleId
                    select new
                    {
                        p.timezone_name,
                        p.timezone_cost_per_hour
                    }).ToList();
            }
        }

        public void CallNewConsoleCreator()
        {
            var cnc = new CreateNewConsole();
            cnc.ShowDialog();
        }

        public void DeleteConsole(string consoleToDeleteName)
        {
            DataBaseClass.Instancedb().DeleteConsole(consoleToDeleteName);
        }
    }
}
