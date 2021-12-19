using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalMgmt2.Shared.Domain
{
    public class Customer: BaseDomainModel
    {
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public string CustContact { get; set; }
        public string CustAddr { get; set; }

        public virtual RentOrder RentOrder { get; set; }
    }
}
