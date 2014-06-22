using System;
using System.Collections.Generic;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    class WithdrawMoneyController
    {
        private static WithdrawMoneyController _withdrawMoneyController;

        public static WithdrawMoneyController WithdrawMoneyControllerInstance()
        {
            return _withdrawMoneyController ?? (_withdrawMoneyController = new WithdrawMoneyController());
        }

        public List<string> GetAllManagersList()
        {
            return DataBaseClass.Instancedb().GetAllStaffNamesByPositionList("MANAGER");
        }

        public void InsertNewRecordWithdrawMoney(double money, string managerName, DateTime withdrawTime)
        {
            DataBaseClass.Instancedb().InsertWithdrawRecord(money, managerName, withdrawTime);
            DataBaseClass.Instancedb().AddMoneyToCash(money*(-1));
        }
    }
}
