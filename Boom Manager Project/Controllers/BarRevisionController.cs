using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    class BarRevisionController
    {
        private static BarRevisionController _barRevisionController;

        public static BarRevisionController BarRevisionControllerInstance()
        {
            return _barRevisionController ?? (_barRevisionController = new BarRevisionController());
        }

        public void InsertOrUpdateAllItemsInBar()
        {
            var allItems = DataBaseClass.Instancedb().GetAllItems();
            var dailyId = DataBaseClass.Instancedb().GetOpenedGlobalSession().daily_id;

            foreach (AllItemsMyClass item in allItems)
            {
                int numberSold = AccountHowManyWasSoldByItemId(item.ItemId, dailyId);
                int numberBought = 0;
                DataBaseClass.Instancedb()
                    .AddNewOrUpdateBarRevisionRecord(dailyId, item.ItemId, numberSold, numberBought, item.NumberLeft, item.Num);
            }
        }

        public int AccountHowManyWasSoldByItemId(string itemId, int dailyId)
        {
            var listOfSoldItems = DataBaseClass.Instancedb().GetListOfSoldItemId(itemId, dailyId);
            int count = 0;
            for (int i = 0; i < listOfSoldItems.Count; i++)
            {
                var amountSold = listOfSoldItems[i].amount_sold;
                if (amountSold != null) count += (int)amountSold;
            }
            return count;
        }
    }
}
