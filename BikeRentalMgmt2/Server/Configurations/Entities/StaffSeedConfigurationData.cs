using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeRentalMgmt2.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BikeRentalMgmt2.Server.Configurations.Entities
{
    public class StaffSeedConfigurationData : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
               new Staff
               {
                   Id = 1,
                   StaffName = "Lea",
                   StaffContact = "81234567",
                   StaffEmail = "Lea819@hotmail.com",
                   StaffAddr = "Simei",
                   StaffBranchID= null,
                   StaffPos = "Counter"
               },
               new Staff
               {
                   Id = 2,
                   StaffName = "Andrew",
                   StaffContact = "81234568",
                   StaffEmail = "andrews09@hotmail.com",
                   StaffAddr = "Simei",
                   StaffBranchID= null,
                   StaffPos = "Branch Manager"
               },
               new Staff
               {
                   Id = 3,
                   StaffName = "Benjamin",
                   StaffContact = "81235468",
                   StaffEmail = "benben09@hotmail.com",
                   StaffAddr = "Orchard",
                   StaffBranchID = null,
                   StaffPos = "Branch Manager"
               }
            );
        }
    }
}
