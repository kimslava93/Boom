using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Controllers
{
    class AddMoneyOnDiscountCardController
    {
        private static AddMoneyOnDiscountCardController _addMoneyOnDiscountCardController;

        public static AddMoneyOnDiscountCardController AddMoneyOnCardControllerInstance()
        {
            return _addMoneyOnDiscountCardController ?? (_addMoneyOnDiscountCardController = new AddMoneyOnDiscountCardController());
        }

        public List<object> GetClientInfo(string clientId)
        {
            var clientToFind = DataBaseClass.Instancedb().GetClientInfoById(clientId);
            var savingsToFind = DataBaseClass.Instancedb().GetClientSavingsById(clientId);
            var result = new List<object>();
            if (clientToFind != null)
            {
                if (clientToFind.client_id == Options.OptionsInstance().UsualClient)
                {
                    result.Add(clientToFind.name);
                    result.Add(Options.OptionsInstance().UsualClient);
                }
                else if (savingsToFind != null && !string.IsNullOrWhiteSpace(clientToFind.name))
                {
                    result.Add(clientToFind.name);
                    result.Add(savingsToFind.savings.ToString(CultureInfo.InvariantCulture));
                }
//                else
//                {
////                    MessageBox.Show(GetWarning("noClientInfo"));
//                }
            }
            else
            {
//                result.Add(Options.OptionsInstance().UsualClient);
                result.Add("No client info");
                result.Add(Options.OptionsInstance().UsualClient);
//                MessageBox.Show(GetWarning("noClientInfo"));
            }
            return result;
        }

        public string AddMoneyOnCard(string moneyWas, double moneyToAdd)
        {
            double mWas = double.Parse(moneyWas.Replace(".", ","));
            mWas += moneyToAdd;
            return mWas.ToString(CultureInfo.InvariantCulture);
        }

        public void SubmitChanges(List<object> data, string clientId)
        {
            var t = GetClientInfo(clientId);
            if (t != data)
            {
                double moneyToAdd = double.Parse(data[1].ToString().Replace(".", ",")) -
                                    double.Parse(t[1].ToString().Replace(".", ","));
//                MessageBox.Show(moneyToAdd.ToString());
                DataBaseClass.Instancedb()
                    .ChangeSavingsValueOfClient(clientId, moneyToAdd);
            }
        }
    }
}
