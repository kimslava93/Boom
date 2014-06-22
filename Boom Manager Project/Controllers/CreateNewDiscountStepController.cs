using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    class CreateNewDiscountStepController
    {
        private static CreateNewDiscountStepController _createNewDiscountStepController;

        public static CreateNewDiscountStepController CreateNewDiscountControllerInstance()
        {
            return _createNewDiscountStepController ?? (_createNewDiscountStepController = new CreateNewDiscountStepController());
        }

        public bool DoAllFieldsAreFulfilled(string name, string requirements, double discount)
        {
            double res;
            if (!double.TryParse(requirements, out res))
            {
                return false;
            }
            if (string.IsNullOrEmpty(name) || res < 10 || discount > 100 || discount < 1)
            {
                return false;
            }
            return true;
        }

        public void CreateNewDiscountStep(string name, string requirements, double discount)
        {
            if (DoAllFieldsAreFulfilled(name, requirements, discount))
            {
                double req = double.Parse(requirements);
                DataBaseClass.Instancedb().AddNewDiscountStep(name, req, discount);
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(26));
            }
        }
    }
}
