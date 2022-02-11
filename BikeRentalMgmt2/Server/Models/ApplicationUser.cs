using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BikeRentalMgmt2.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TypeOfUser { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
    }
}
