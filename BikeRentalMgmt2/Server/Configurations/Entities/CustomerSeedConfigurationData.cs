using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeRentalMgmt2.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BikeRentalMgmt2.Server.Configurations.Entities
{
    public class CustomerSeedConfigurationData : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    FirstName = "Amoz",
                    LastName = "Tan",
                    CustEmail = "amozlow888@gmail.com",
                    CustContact = "91234567",
                    CustAddr = "Simei"
                },

                new Customer
                {
                    Id = 2,
                    FirstName = "Hou Sheng",
                    LastName = "Tan",
                    CustEmail = "Dead_Pixelz@gmail.com",
                    CustContact = "91234568",
                    CustAddr = "Sengkang"
                }
            );

        }

    }
}
