using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    class ModelPersonalInfo
    {
        public personal_info_t GetUserInfo(string login)
        {
            var db = new DataBaseClass();
            personal_info_t userInfo = db.GetUserInfoByLogin(login);
            if (userInfo != null)
            {
                return db.GetUserInfoByLogin(login);
            }
            return null;
        }

        public void CreateNewUser(personal_info_t newUserInfo)
        {
            var db = new DataBaseClass();
            db.AddNewUser(newUserInfo);
        }
    }
}
