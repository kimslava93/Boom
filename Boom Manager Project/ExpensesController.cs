using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
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
            DataBaseClass.Instancedb().AddMoneyToCash(money * (-1));
        }
    }
}
