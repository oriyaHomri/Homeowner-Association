using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace Entities
{
    public class ExpensesEntities
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Professional { get; set; }
        public int SumExpenses { get; set; }
        public Nullable<System.DateTime> DataExpenses { get; set; }
        public string PaymentMethods { get; set; }
        //המרה מאובייקט מסוג מסד התונים לאובייקט מסוג אנטיטיז
        public static ExpensesEntities ConvertToEntities(Expenses e)
        {
            return new ExpensesEntities()
            {
                ID = e.ID,
                Category = e.Category,
                Professional = e.Professional,
                SumExpenses = e.SumExpenses,
                DataExpenses = e.DataExpenses,
                PaymentMethods = e.PaymentMethods,

            };
        }
        //המרה מסוג אנטיטיז לסוג מסד נתונים
        public static Expenses ConvertToDB(ExpensesEntities e)
        {
            return new Expenses()
            {
                ID = e.ID,
                Category = e.Category,
                Professional = e.Professional,
                SumExpenses = e.SumExpenses,
                DataExpenses = e.DataExpenses,
                PaymentMethods = e.PaymentMethods,
            };
        }
        //המרה מסוג רשימת מסד נתונים לרשימת אנטיטיז
        public static List<ExpensesEntities> ConvertToListEntities(List<Expenses> listE)
        {
            List<ExpensesEntities> le = new List<ExpensesEntities>();
            foreach (var item in listE)
            {
                le.Add(ConvertToEntities(item));
            }
            return le;
        }
        //המרה מסוג רשימת אנטיטיז לרשימת מסד נתונים
        public static List<Expenses> ConvaertToListDB(List<ExpensesEntities> listE)
        {
            List<Expenses> le = new List<Expenses>();
            foreach (var item in listE)
            {
                le.Add(ConvertToDB(item));
            }
            return le;
        }

    }
}
