using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace Entities
{
    public class CommitteePaymentsEntities
    {
        public int ID { get; set; }
        public int Apartment { get; set; }
        public string PaymentFor { get; set; }
        public int SumPayment { get; set; }
        public Nullable<int> NumberOfPayments { get; set; }
        //המרה מאובייקט מסוג מסד התונים לאובייקט מסוג אנטיטיז
        public static CommitteePaymentsEntities ConvertToEntities(CommitteePayments c)
        {
            return new CommitteePaymentsEntities()
            {
                ID = c.ID,
                Apartment = c.Apartment,
                PaymentFor = c.PaymentFor,
                SumPayment = c.SumPayment,
                NumberOfPayments = c.NumberOfPayments,

            };
        }
        //המרה מסוג אנטיטיז לסוג מסד נתונים
        public static CommitteePayments ConvertToDB(CommitteePaymentsEntities c)
        {
            return new CommitteePayments()
            {
                ID = c.ID,
                Apartment = c.Apartment,
                PaymentFor = c.PaymentFor,
                SumPayment = c.SumPayment,
                NumberOfPayments = c.NumberOfPayments,
            };
        }
        //המרה מסוג רשימת מסד נתונים לרשימת אנטיטיז
        public static List<CommitteePaymentsEntities> ConvertToListEntities(List<CommitteePayments> listC)
        {
            List<CommitteePaymentsEntities> lc = new List<CommitteePaymentsEntities>();
            foreach (var item in listC)
            {
                lc.Add(ConvertToEntities(item));
            }
            return lc;
        }
        //המרה מסוג רשימת אנטיטיז לרשימת מסד נתונים
        public static List<CommitteePayments> ConvaertToListDB(List<CommitteePaymentsEntities> listC)
        {
            List<CommitteePayments> lc = new List<CommitteePayments>();
            foreach (var item in listC)
            {
                lc.Add(ConvertToDB(item));
            }
            return lc;

        }
}
