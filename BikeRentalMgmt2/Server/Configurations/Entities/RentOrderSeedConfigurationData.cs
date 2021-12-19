using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeRentalMgmt2.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BikeRentalMgmt2.Server.Configurations.Entities
{
    public class RentOrderSeedConfigurationData : IEntityTypeConfiguration<RentOrder>
    {
        public void Configure(EntityTypeBuilder<RentOrder> builder)
        {

        }
    }
}
