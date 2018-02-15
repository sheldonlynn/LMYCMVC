﻿using LmycWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmycDataLib.Models.Users
{
    class Users: ApplicationDbContext
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string MobileNumber { get; set; }
        public string SailingExperience { get; set; }

        public string Role { get; set; }
    }
}
