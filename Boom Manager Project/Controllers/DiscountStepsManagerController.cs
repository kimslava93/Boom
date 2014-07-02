using System.Collections.Generic;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Controllers
{
    class DiscountStepsManagerController
    {
        private static DiscountStepsManagerController _discountStepsManagerController;

        public string FirstColumn = "Название";
        public string SecondColumn = "Требование";
        public string ThirdColumn = "Размер скидки";


        public static DiscountStepsManagerController DiscountStepsManagerControllerInstance()
        {
            return _discountStepsManagerController ??
                   (_discountStepsManagerController = new DiscountStepsManagerController());
        }

        public List<steps_of_discount_upgrading> GetAllDiscountSteps()
        {
            return DataBaseClass.Instancedb().GetAllDiscountSteps();
        }

        public void DeleteDiscountStep(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                DataBaseClass.Instancedb().DeleteDiscountStep(name);
            }
            else
            {
                ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(29);
            }
        }
    }
}
