using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CommitteePaymentsDAL
    {
        static HomeownerAssociationEntities db = new HomeownerAssociationEntities();
        //שליפת הכנסה 
        public static List<CommitteePayments> GetCommitteePayments()
        {
            return db.CommitteePayments.ToList();
        }
        //הוספת הכנסה
        public static void AddCommitteePayments(CommitteePayments c)
        {
            db.CommitteePayments.Add(c);
            db.SaveChanges();
        }
        //מחיקת הוצאה
        public static void RemoveCommitteePayments(int id)
        {
            db.CommitteePayments.Remove(db.CommitteePayments.FirstOrDefault(x => x.ID == id));
            db.SaveChanges();
        }
        //עדכון הכנסה
        public static void UpdateCommitteePayments(CommitteePayments c)
        {
            db.CommitteePayments.FirstOrDefault(x => x.ID == c.ID).Apartment = c.Apartment;
            db.CommitteePayments.FirstOrDefault(x => x.ID == c.ID).PaymentFor = c.PaymentFor;
            db.CommitteePayments.FirstOrDefault(x => x.ID == c.ID).SumPayment = c.SumPayment;
            db.CommitteePayments.FirstOrDefault(x => x.ID == c.ID).NumberOfPayments = c.NumberOfPayments;



        }
    }
}
