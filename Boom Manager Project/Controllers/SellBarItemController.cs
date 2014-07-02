using System;
using System.Data.Linq.Mapping;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Controllers
{
    class SellBarItemController
    {
        private static SellBarItemController _sellBarItemController;

        public static SellBarItemController SellBarItemControllerInstance()
        {
            return _sellBarItemController ?? (_sellBarItemController = new SellBarItemController());
        }

        public void SellItem(string itemId, int number,double sum)
        {
            if (!string.IsNullOrEmpty(itemId) && number > 0 && sum > 1)
            {
                DataBaseClass.Instancedb().SellItem(itemId,number,DateTime.Now, sum);
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(9));
            }
        }

        public double GetSumOfItems(string itemId, int number)
        {
            if (!string.IsNullOrEmpty(itemId) && number > 0)
            {
                var item = DataBaseClass.Instancedb().GetItemDataById(itemId);
                if (item != null)
                {
                    return item.Цена*number;
                }
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(48));
                return 0;
            }
            MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(9));
            return 0;
        }
    }
}
