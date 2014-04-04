﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boom_Manager_Project.MyClasses;

namespace Boom_Manager_Project.Controllers
{
    class Controller
    {
        public personal_info_t GetPersonInfoByLogin(string login)
        {
            var model= new ModelPersonalInfo();
            return model.GetUserInfo(login);
        }

     

        public void AddNewGlobalSession(string adminID, string operatorID, DateTime date)
        {
            var model = new ModelGlobalSession();
            model.AddNewGlobalSession(adminID, operatorID, date);
        }

        public void AddNewUser(personal_info_t newUserInfo)
        {
            var model = new ModelPersonalInfo();
            model.CreateNewUser(newUserInfo);
        }

        public string SessionIsOpened(int dailyId)
        {
            return "Session #" + dailyId + " was NOT FINISHED! Please close all sessions before starting new one.";
        }

//        public void MessageHandler()
//        {
//        }
    }
}
