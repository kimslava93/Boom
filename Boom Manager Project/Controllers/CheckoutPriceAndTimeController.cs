namespace Boom_Manager_Project.Controllers
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
