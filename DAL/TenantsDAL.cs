using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class TenantsDAL
    {
        static HomeownerAssociationEntities db = new HomeownerAssociationEntities();
        //שליפת דייר
        public static List<Tenants> GetTenants()
        {
            return db.Tenants.ToList();
        }
        //הוספת דייר
        public static void AddTenants(Tenants t)
        {
            db.Tenants.Add(t);
            db.SaveChanges();
        }
        //מחיקת דייר
        public static void RemoveTenants(string id)
        {
            db.Tenants.Remove(db.Tenants.FirstOrDefault(x => x.ID == id));
            db.SaveChanges();
        }
        //עדכון דייר
        public static void UpdateTenants(Tenants t)
        {
            db.Tenants.FirstOrDefault(x => x.ID == t.ID).FirstName = t.FirstName;
            db.Tenants.FirstOrDefault(x => x.ID == t.ID).LastName = t.LastName;
            db.Tenants.FirstOrDefault(x => x.ID == t.ID).Apartment = t.Apartment;
            db.Tenants.FirstOrDefault(x => x.ID == t.ID).FloorNum = t.FloorNum;
            db.Tenants.FirstOrDefault(x => x.ID == t.ID).ParkingNum = t.ParkingNum;
            db.Tenants.FirstOrDefault(x => x.ID == t.ID).Phone = t.Phone;
            db.Tenants.FirstOrDefault(x => x.ID == t.ID).AdditionalPhone = t.AdditionalPhone;
            db.Tenants.FirstOrDefault(x => x.ID == t.ID).Email = t.Email;
            db.Tenants.FirstOrDefault(x => x.ID == t.ID).MonthlyBill = t.MonthlyBill;
            db.Tenants.FirstOrDefault(x => x.ID == t.ID).HouseCommitteeMember = t.HouseCommitteeMember;
            db.Tenants.FirstOrDefault(x => x.ID == t.ID).Rent = t.Rent;

        }


    }
}
