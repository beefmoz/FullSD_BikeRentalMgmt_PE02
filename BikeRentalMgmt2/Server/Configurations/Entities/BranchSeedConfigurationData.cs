using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeRentalMgmt2.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BikeRentalMgmt2.Server.Configurations.Entities
{
    public class BranchSeedConfigurationData : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasData(
                new Branch
                {
                    Id = 1,
                    BranchAddr= "Changi Coastal",
                    BranchContact= "61234098",
                    ManagerID= null
                },
                new Branch
                {
                    Id = 2,
                    BranchAddr = "East Coast Park",
                    BranchContact = "61234098",
                    ManagerID = null
                }
            );
        }
    }
}
