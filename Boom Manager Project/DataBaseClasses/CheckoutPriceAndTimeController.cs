using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boom_Manager_Project.DataBaseClasses
{
    public class CheckoutPriceAndTimeController
    {
        private static CheckoutPriceAndTimeController _checkoutPriceAndTimeController;

        public static CheckoutPriceAndTimeController CheckoutPriceAndTimeControllerInstance()
        {
            return _checkoutPriceAndTimeController ??
                   (_checkoutPriceAndTimeController = new CheckoutPriceAndTimeController());
        }

//        public double GetPriceForTime(TimeSpan timeToPlay, DateTime fromTime)
//        {
//
//        }
    }
}
