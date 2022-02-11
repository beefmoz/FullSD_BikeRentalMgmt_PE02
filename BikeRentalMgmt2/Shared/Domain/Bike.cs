using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public virtual List<RentOrder> RentOrders { get; set; }
    }
}
