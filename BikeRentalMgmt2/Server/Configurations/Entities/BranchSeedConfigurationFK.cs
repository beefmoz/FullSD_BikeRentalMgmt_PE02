using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeRentalMgmt2.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BikeRentalMgmt2.Server.Configurations.Entities
{
    public class BranchSeedConfigurationFK : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasOne(a => a.Staff)
            .WithOne(a => a.Branch)
            .HasForeignKey<Staff>(c => c.StaffBranchID);

            builder.HasOne(a => a.Bike)
            .WithOne(a => a.Branch)
            .HasForeignKey<Bike>(c => c.BikeBranchID);

            builder.HasOne(a => a.RentOrder)
            .WithOne(a => a.Branch)
            .HasForeignKey<RentOrder>(r => r.RentBranchID);

        }
    }
}
