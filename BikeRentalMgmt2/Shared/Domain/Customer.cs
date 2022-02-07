using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalMgmt2.Shared.Domain
{
    public class Customer: BaseDomainModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustEmail { get; set; }
        public string CustContact { get; set; }
        public string CustAddr { get; set; }
        public virtual List<RentOrder> RentOrders { get; set; }
        
    }
}
