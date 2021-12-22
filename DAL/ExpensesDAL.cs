using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExpensesDAL
    {
        static HomeownerAssociationEntities db = new HomeownerAssociationEntities();
        //שליפת הוצאה
        public static List<Expenses> GetExpenses()
        {
            return db.Expenses.ToList();
        }
        //הוספת הוצאה
        public static void AddExpenses(Expenses e)
        {
            db.Expenses.Add(e);
            db.SaveChanges();
        }
        //מחיקת הוצאה
        public static void RemoveExpenses(int id)
        {
            db.Expenses.Remove(db.Expenses.FirstOrDefault(x => x.ID == id));
            db.SaveChanges();
        }
        //עדכון הוצאה
        public static void UpdateExpenses(Expenses e)
        {
            db.Expenses.FirstOrDefault(x => x.ID == e.ID).Category = e.Category;
            db.Expenses.FirstOrDefault(x => x.ID == e.ID).Professional = e.Professional;
            db.Expenses.FirstOrDefault(x => x.ID == e.ID).SumExpenses = e.SumExpenses;
            db.Expenses.FirstOrDefault(x => x.ID == e.ID).DataExpenses = e.DataExpenses;
            db.Expenses.FirstOrDefault(x => x.ID == e.ID).PaymentMethods = e.PaymentMethods;


        }


    }
}

