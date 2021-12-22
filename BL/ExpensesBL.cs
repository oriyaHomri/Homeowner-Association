using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BL
{
    class ExpensesBL
    {
        //הוספה
        public static void AddExpenses(ExpensesEntities e)
        {
            ExpensesDAL.AddExpenses(ExpensesEntities.ConvertToDB(e));
        }
    }
}
