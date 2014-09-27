using System;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project.MyClasses
{
    public class ExpensesMyClass
    {
        public int ID_затрат { get; set; }
        public DateTime Время { get; set; }
        public double Денег_потрачено { get; set; }
        public string Описание { get; set; }

        public ExpensesMyClass ConvertDbTableToMyClass(expenses_t expense)
        {
            var e = new ExpensesMyClass
            {
                ID_затрат = expense.expense_id,
                Время = expense.expenses_time,
                Денег_потрачено = expense.cash_amount,
                Описание = expense.comments
            };
            return e;
        }
    }
 
}
