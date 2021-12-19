using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeRentalMgmt2.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BikeRentalMgmt2.Server.Configurations.Entities
{
    public class BikeSeedConfigurationFK : IEntityTypeConfiguration<Bike>
    {
        public void Configure(EntityTypeBuilder<Bike> builder)
        {
            builder.HasOne(a => a.RentOrder)
            .WithOne(a => a.Bike)
            .HasForeignKey<RentOrder>(c => c.RentBikeID);

        }
    }
}
