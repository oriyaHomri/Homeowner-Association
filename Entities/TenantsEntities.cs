using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Entities
{
    public class TenantsEntities
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Apartment { get; set; }
        public Nullable<int> FloorNum { get; set; }
        public Nullable<int> ParkingNum { get; set; }
        public string Phone { get; set; }
        public string AdditionalPhone { get; set; }
        public string Email { get; set; }
        public Nullable<double> MonthlyBill { get; set; }
        public Nullable<byte> HouseCommitteeMember { get; set; }
        public Nullable<byte> Rent { get; set; }

        //המרה מאובייקט מסוג מסד התונים לאובייקט מסוג אנטיטיז
        public static TenantsEntities ConvertToEntities(Tenants t)
        {
            return new TenantsEntities() {
                ID = t.ID, 
                FirstName = t.FirstName, 
                LastName = t.LastName, 
                Apartment = t.Apartment,
                FloorNum = t.FloorNum,
                ParkingNum = t.ParkingNum,
                Phone = t.Phone,
                AdditionalPhone = t.AdditionalPhone,
                Email = t.Email,
                MonthlyBill = t.MonthlyBill,
                HouseCommitteeMember = t.HouseCommitteeMember,
                Rent = t.Rent,
            };
        }
        //המרה מסוג אנטיטיז לסוג מסד נתונים
        public static Tenants ConvertToDB(TenantsEntities t)
        {
            return new Tenants()
            {
                ID = t.ID,
                FirstName = t.FirstName,
                LastName = t.LastName,
                Apartment = t.Apartment,
                FloorNum = t.FloorNum,
                ParkingNum = t.ParkingNum,
                Phone = t.Phone,
                AdditionalPhone = t.AdditionalPhone,
                Email = t.Email,
                MonthlyBill = t.MonthlyBill,
                HouseCommitteeMember = t.HouseCommitteeMember,
                Rent = t.Rent,
            };
        }
        //המרה מסוג רשימת מסד נתונים לרשימת אנטיטיז
        public static List<TenantsEntities> ConvertToListEntities(List<Tenants> listT)
        {
            List<TenantsEntities> lt = new List<TenantsEntities>();
            foreach (var item in listT)
            {
                lt.Add(ConvertToEntities(item));
            }
            return lt;
        }
        //המרה מסוג רשימת אנטיטיז לרשימת מסד נתונים
        public static List<Tenants> ConvaertToListDB(List<TenantsEntities> listT)
        {
            List<Tenants> lt = new List<Tenants>();
            foreach (var item in listT)
            {
                lt.Add(ConvertToDB(item));
            }
            return lt;
        }

    }
}
