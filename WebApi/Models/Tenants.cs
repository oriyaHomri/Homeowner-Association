﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Tenants
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
    }
}