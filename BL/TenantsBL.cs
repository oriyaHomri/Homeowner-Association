using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
namespace BL
{
    public class TenantsBL
    {
        //הוספה
        public static void AddTenants(TenantsEntities t)
        {
            TenantsDAL.AddTenants(TenantsEntities.ConvertToDB(t));
        }
        //בדיקה האם קיים דייר לפי שם ותעודת זהות
        public static bool IsExist(string name, string id)
        {
            return TenantsDAL.GetTenants().Any(x => x.FirstName.CompareTo(name) == 0 && x.ID.CompareTo(id) == 0);
        }
    }
}
