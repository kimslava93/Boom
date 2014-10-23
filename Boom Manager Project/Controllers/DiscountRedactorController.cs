using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Boom_Manager_Project.Controllers
{
    public class DiscountRedactorController
    {
        private static DiscountRedactorController _discountRedactorController;
        public static DiscountRedactorController InstanceDiscountRedactorController()
        {
            return _discountRedactorController ?? (_discountRedactorController = new DiscountRedactorController());
        }

        public void CreateNewRequirement(TimeSpan? hours, string itemsId, int? numOfItem, double? moneySum)
        {
            if (hours == new TimeSpan())
            {
                hours = null;
            }
            if (string.IsNullOrEmpty(itemsId))
            {
                itemsId = null;
            }
            if (numOfItem == 0)
            {
                numOfItem = null;
            }
            if (moneySum == 0)
            {
                moneySum = null;
            }
            DataBaseClasses.DataBaseClass.Instancedb()
                .InsertNewDiscountRequirements(hours, itemsId, numOfItem, moneySum);
        }
        public void CreateNewBonus(TimeSpan? hours, string itemsId, int? numOfItem, double? moneySum, double? sumDiscount)
        {
            if (hours == new TimeSpan())
            {
                hours = null;
            }
            if (string.IsNullOrEmpty(itemsId))
            {
                itemsId = null;
            }
            if (numOfItem == 0)
            {
                numOfItem = null;
            }
            if (moneySum == 0)
            {
                moneySum = null;
            }
            if (sumDiscount == 0)
            {
                sumDiscount = null;
            }
            DataBaseClasses.DataBaseClass.Instancedb()
                .InsertNewDiscountBonus(hours, itemsId, numOfItem, moneySum, sumDiscount);
        }

        public void CreateNewDiscount(string description, DateTime? start, DateTime? end, string state, string timezones,
            string playstations, string auditory)
        {
            if (!string.IsNullOrEmpty(description) && start != null && end != null && !string.IsNullOrEmpty(state) &&
                !string.IsNullOrEmpty(timezones) && !string.IsNullOrEmpty(playstations) &&
                !string.IsNullOrEmpty(auditory))
            {
                DataBaseClasses.DataBaseClass.Instancedb().InsertNewDiscount(description, start, end, state, timezones, playstations, auditory);
            }
        }

        public string OpenAddItemRequirements()
        {
            List<string> allItems = DataBaseClasses.DataBaseClass.Instancedb().GetAllItemsNames();
            var madts = new MultipleAddingDataToString(allItems);
            madts.ShowDialog();
            return madts.Result;
        }
        public string OpenAddBonusItem()
        {
            List<string> allItems = DataBaseClasses.DataBaseClass.Instancedb().GetAllItemsNames();
            var madts = new MultipleAddingDataToString(allItems);
            madts.ShowDialog();
            return madts.Result;
        }
        public string OpenAddAvailableTimezones()
        {
            List<string> allItems = DataBaseClasses.DataBaseClass.Instancedb().GetAllTimeZoneNames();
            var madts = new MultipleAddingDataToString(allItems);
            madts.ShowDialog();
            return madts.Result;
        }
        public string OpenAddAvailablePlaystations()
        {
            List<string> allItems = DataBaseClasses.DataBaseClass.Instancedb().GetAllTablesNames();
            var madts = new MultipleAddingDataToString(allItems);
            madts.ShowDialog();
            return madts.Result;
        }   
        public string OpenAddExchageableItems()
        {
            List<string> allItems = DataBaseClasses.DataBaseClass.Instancedb().GetAllItemsNames();
            var madts = new MultipleAddingDataToString(allItems);
            madts.ShowDialog();
            return madts.Result;
        }
    }
}
