using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalMgmt2.Shared.Domain
{
    public class Staff: BaseDomainModel
    {
        public string StaffName { get; set; }
        public string StaffContact { get; set; }
        public string StaffEmail { get; set; }
        public string StaffAddr { get; set; }
        public Nullable<int> StaffBranchID { get; set; }
        public virtual Branch Branch { get; set; }
        public string StaffPos { get; set; }
    }
}
