using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalMgmt2.Shared.Domain
{
    public class RentOrder: BaseDomainModel
    {
        public DateTime RentDate { get; set; }
        public int RentStartHour { get; set; }

        public int RentEndHour { get; set; }
        public int RentCustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public int RentBikeID { get; set; }
        public virtual Bike Bike { get; set; }
        public int RentBranchID { get; set; }
        public virtual Branch Branch { get; set; }
        public string RentDuration { get; set; }
        public decimal RentCost { get; set; }
    }

}
