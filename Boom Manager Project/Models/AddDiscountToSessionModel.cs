using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    class AddDiscountToSessionModel
    {
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

        public List<string> GetClientInfo(string id)
        {
            var clientToFind = DataBaseClass.Instancedb().GetClientInfoById(id);
            var savingsToFind = DataBaseClass.Instancedb().GetClientSavingsById(id);
//            var adc = new AddDiscountCardToSession();
            var result = new List<string>();
            if (clientToFind != null)
            {
                if (clientToFind.client_id == "0")
                {
                    result.Add(clientToFind.client_id);
                    result.Add(clientToFind.name);
                    result.Add("0");
                }
                else if (savingsToFind != null)
                {
                    result.Add(id);
                    result.Add(clientToFind.name);
                    result.Add(savingsToFind.savings.ToString(CultureInfo.InvariantCulture));

//                    adc.ClientID = id;
//                    adc.ClientName = clientToFind.name;
//                    adc.Остаток_денег = (decimal)savingsToFind.savings;
                }
                else
                {
                    MessageBox.Show(GetWarning("noClientInfo"));
                }
            }
            else
            {
                result.Add("0");
                result.Add("Usual client");
                result.Add("0");
                MessageBox.Show(GetWarning("noClientInfo"));
            }
            return result;
        }
    }
}
