using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalMgmt2.Shared.Domain
{
    public class Bike : BaseDomainModel
    {
        public string BikeModel { get; set; }
        public string BikeType { get; set; }
        public string BikeSize { get; set; }
        public int BikeBranchID { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual RentOrder RentOrder {get; set;}
    }
}
