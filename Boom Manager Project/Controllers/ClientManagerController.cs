using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Controllers
{
    internal class ClientManagerController
    {
        public Point CREATEMode = new Point(537, 39);
        public Point EDITMode = new Point(169, 38);
        private static ClientManagerController _clientManagerController;

        public static ClientManagerController ClientManagerControllerInstance()
        {
            return _clientManagerController ?? (_clientManagerController = new ClientManagerController());
        }

        public List<string> GetAllClients()
        {
            var allClients = DataBaseClass.Instancedb().GetAllClients();
            return allClients.Select(c => c.client_id.ToString(CultureInfo.InvariantCulture)).ToList();
        }

        public client_info_t GetClientInfo(string clientId)
        {
            return DataBaseClass.Instancedb().GetClientInfoById(clientId);
        }

        private IEnumerable<steps_of_discount_upgrading> GetAllDiscountSteps()
        {
            return DataBaseClass.Instancedb().GetAllDiscountSteps();
        }

        public double GetPriceForDiscount(int discount)
        {
            var allDiscounts = GetAllDiscountSteps();
            if (allDiscounts != null)
            {
                return (from step in allDiscounts where Math.Abs(discount - (int)step.discount) == 0 select step.required_played_sum).FirstOrDefault();
            }
            return 0;
        }

        public List<double> GetListOfAvailableDiscounts()
        {
            var allDiscounts = DataBaseClass.Instancedb().GetAllDiscountSteps();
            return allDiscounts.Select(step => step.discount).ToList();
        }

        public account_savings_t GetClientSavings(string clientId)
        {
            return DataBaseClass.Instancedb().GetClientSavingsById(clientId);
        }

        public bool CheckClientIdOnRepeat(string clientId)
        {
            var matched = (from c in DataBaseClass.Instancedb().GetAllClients()
                where c.client_id == clientId
                select c).SingleOrDefault();
            if (matched == null)
            {
                return true;
            }
            return false;
        }

//        public string GetClientIdFromInt(string clientInt)
//        {
//            string result = clientInt.ToString(CultureInfo.InvariantCulture);
//            if (result.Length == 1)
//            {
//                result = "00" + result;
//            }
//            else if (result.Length == 2)
//            {
//                result = Options.OptionsInstance().UsualClient + result;
//            }
//            return result;
//        }

        public void CreateNewClient(string clientId, string name, string email, DateTime birthday, string phone,
            string activationdate, double personalDiscount, double playedSum)
        {
//            string clientID = GetClientIdFromInt(clientId);
            if (CheckClientIdOnRepeat(clientId))
            {
                var c = new client_info_t
                {
                    client_id = clientId,
                    activation_date = DateTime.Parse(activationdate), 
                    email = email,
                    birthday = birthday,
                    name = name,
                    pers_discount = personalDiscount,
                    phone = phone,
                    played_sum = playedSum
                };
                DataBaseClass.Instancedb().AddNewClient(c);
                MessageBox.Show(@"Succesfully created!");
            }
            else
            {
                MessageBox.Show(@"This id is already created, choose another one!");
            }
        }
    }
}
