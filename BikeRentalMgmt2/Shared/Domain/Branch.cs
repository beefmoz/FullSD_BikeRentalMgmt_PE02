using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalMgmt2.Shared.Domain
{
    public class Branch: BaseDomainModel
    {
        public string BranchAddr { get; set; }
        public string BranchContact { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual List<Bike> Bikes { get; set; }

    }
}
