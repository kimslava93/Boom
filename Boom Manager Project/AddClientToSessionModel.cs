using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    class AddClientToSessionModel
    {
        public client_info_t GetDataAboutClient(string id)
        {
            
            client_info_t result = new client_info_t();
            if (String.IsNullOrWhiteSpace(id))
            {
                result = DataBaseClass.Instancedb().GetClientInfoById(id);
                if (result != null)
                {
                }
            }
            return result;
        }
    }
}
