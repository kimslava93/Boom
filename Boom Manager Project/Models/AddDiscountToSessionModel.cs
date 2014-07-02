using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Models
{
    class AddDiscountToSessionModel
    {
        private static  AddDiscountToSessionModel _addDiscountToSessionModel;

        public static AddDiscountToSessionModel AddDiscountToSessionModelInstance()
        {
            return _addDiscountToSessionModel ?? (_addDiscountToSessionModel = new AddDiscountToSessionModel());
        }

//        public List<object> GetDataAboutClient(string id)
//        {
//            var result = new List<object>();
//            if (!String.IsNullOrWhiteSpace(id))
//            {
//                result.Add(DataBaseClass.Instancedb().GetClientInfoById(id).name);
//                result.Add(DataBaseClass.Instancedb().GetClientSavingsById(id).savings);
//            }
//            return result;
//        }

        public string GetWarning(string type)
        {
            switch (type)
            {
                case "noClients":
                    return "Connection with database is corrupted ot there is no any clients in the database!";
                case "noClientInfo":
                    return "There is no such client or there is not savings for exact client! Check the input data!";
                case "noSuchCard":
                    return "Card with this ID does not exists in the database!";
                default:
                    return "";
            }
        }


       

        public List<client_info_t> GetClientList()
        {
            return DataBaseClass.Instancedb().GetAllClients();
        }

        public bool IsThereAnyClients()
        {
            if (GetClientList().Count > 1)
            {
                return true;
            }
            return false;
        }

        public List<string> GetClientInfo(string id)
        {
            var clientToFind = DataBaseClass.Instancedb().GetClientInfoById(id);
            var savingsToFind = DataBaseClass.Instancedb().GetClientSavingsById(id);
//            var adc = new AddDiscountCardToSession();
            var result = new List<string>();
            if (clientToFind != null)
            {
                if (clientToFind.client_id == Options.OptionsInstance().UsualClient)
                {
                    result.Add(clientToFind.client_id);
                    result.Add(clientToFind.name);
                    result.Add(Options.OptionsInstance().UsualClient);
                }
                else if (savingsToFind != null)
                {
                    result.Add(id);
                    result.Add(clientToFind.name);
                    result.Add(savingsToFind.savings.ToString(CultureInfo.InvariantCulture));

//                    adc.ClientID = id;
//                    adc.ClientName = clientToFind.name;
//                    adc.Счетчик = (decimal)savingsToFind.savings;
                }
                else
                {
                    MessageBox.Show(GetWarning("noClientInfo"));
                }
            }
            else
            {
                result.Add(Options.OptionsInstance().UsualClient);
                result.Add("Usual client");
                result.Add(Options.OptionsInstance().UsualClient);
                MessageBox.Show(GetWarning("noClientInfo"));
            }
            return result;
        }
    }
}
