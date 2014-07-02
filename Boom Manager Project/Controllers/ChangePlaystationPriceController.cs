using System.Collections.Generic;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Controllers
{
    class ChangePlaystationPriceController
    {
        private static ChangePlaystationPriceController _changePlaystationPriceController;

        public static ChangePlaystationPriceController ChangePlaystationPriceControllerInstance()
        {
            return _changePlaystationPriceController ??
                   (_changePlaystationPriceController = new ChangePlaystationPriceController());
        }

        public string GetWarningText(List<string> tablesToChange)//help to put enter when text is going to go further than borders
        {
            string result = "\n";
            int lengthCounter = 0;
            for (int i = tablesToChange.Count - 1; i >= 0; i--)
            {
                result += tablesToChange[i];
                if (i > 0)
                {
                    result += ", ";
                }
                lengthCounter += (tablesToChange[i] + ", ").Length;
                if (lengthCounter / 50 > 0)
                {
                    result += "\n";
                    lengthCounter = 0;
                }
            }
            return result;
        }

        public void ApplyNewPrices(List<string> playstationsToChange, string timeZoneName, int price)
        {
            DataBaseClass.Instancedb().UpdatePricesForTimeZone(playstationsToChange, timeZoneName, price);
        }
    }
}
