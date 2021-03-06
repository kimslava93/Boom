﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Controllers
{
    class TimeZoneManagerController
    {
        private static TimeZoneManagerController _timeZoneManagerController;

        public static TimeZoneManagerController TimeZoneManagerControllerInstance()
        {
            return _timeZoneManagerController ?? (_timeZoneManagerController = new TimeZoneManagerController());
        }

        public List<timezones_t> GetAlTimeZonesData()
        {
            return DataBaseClass.Instancedb().GetAllTimeZones();
        }

        public bool CheckAllInputDataToInsertTimeZone(string name, int startHour, int endHour)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 4)
            {
                MessageBox.Show(
                    ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(44));
                return false;
            }
            if (endHour == startHour)
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(45));
                return false;
            }
            return true;
        }

        public void CreateTimeZoneWithGivenData(string timeZoneName, int startHour, int endHour)
        {
            TimeSpan startTime = TimeSpan.Parse(startHour + ":00");
            TimeSpan endTime = TimeSpan.Parse(endHour + ":00");
            DataBaseClass.Instancedb().InsertNewTimeZone(timeZoneName, startTime, endTime);
        }

        public List<playstation_timezone> GetTimeZonePrices()
        {
           return DataBaseClass.Instancedb().GetAllTimeZonePrices();
        }

        public bool CheckOnNullPrices()
        {
            List<playstation_timezone> allPrices = DataBaseClass.Instancedb().GetAllTimeZonePrices();
            List<string> nullPrices = (from p in allPrices
                where p.timezone_cost_per_hour == 0
                select p.playstation_id).ToList();
            if (nullPrices.Count > 0)
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(46));
                return false;
            }
            return true;
        }

    }
}
