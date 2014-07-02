using System;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.Controllers
{
    class ExpensesController
    {
        private static ExpensesController _expences;

        public static ExpensesController ExpensesInstance()
        {
            return _expences ?? (_expences = new ExpensesController());
        }
        public void InsertNewRecordExpensesMoney(double money, string comments, DateTime withdrawTime)
        {
            DataBaseClass.Instancedb().InsertExpensesRecord(money, comments, withdrawTime);
            int dailyId = DataBaseClass.Instancedb().GetOpenedGlobalSession().daily_id;
            DataBaseClass.Instancedb().AddMoneyToCash(money * (-1),dailyId);
        }
    }
}
