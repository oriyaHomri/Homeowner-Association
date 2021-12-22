using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BL
{
    public class CommitteePaymentsBL
    {
        //הוספה
        public static void AddCommitteePayments(CommitteePaymentsEntities c)
        {
            CommitteePaymentsDAL.AddCommitteePayments(CommitteePaymentsEntities.ConvertToDB(c));
        }
    }
}
