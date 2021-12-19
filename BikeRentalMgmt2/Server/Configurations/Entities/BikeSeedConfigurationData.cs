using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeRentalMgmt2.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BikeRentalMgmt2.Server.Configurations.Entities
{
    public class BikeSeedConfigurationData : IEntityTypeConfiguration<Bike>
    {
        public void Configure(EntityTypeBuilder<Bike> builder)
        {
            builder.HasData(
                new Bike
                {
                    Id = 1,
                    BikeModel= "BMW",
                    BikeType = "Mountain",
                    BikeSize = "Small",
                    BikeBranchID= 1
                },

                new Bike
                {
                    Id = 2,
                    BikeModel= "NeoRiderz",
                    BikeType = "Mountain",
                    BikeSize = "Medium",
                    BikeBranchID = 2
                }
            );
        }
    }
}
