using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeRentalMgmt2.Server.Configurations.Entities;
using BikeRentalMgmt2.Server.Models;
using BikeRentalMgmt2.Shared.Domain;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BikeRentalMgmt2.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Staff> Staff { get; set; }

        public DbSet<Bike> Bikes { get; set; }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<RentOrder> RentOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new BranchSeedConfigurationFK());
            builder.ApplyConfiguration(new StaffSeedConfigurationFK());
            builder.ApplyConfiguration(new CustomerSeedConfigurationFK());
            builder.ApplyConfiguration(new BikeSeedConfigurationFK());

            builder.ApplyConfiguration(new BranchSeedConfigurationData());
            builder.ApplyConfiguration(new StaffSeedConfigurationData());
            builder.ApplyConfiguration(new CustomerSeedConfigurationData());
            builder.ApplyConfiguration(new BikeSeedConfigurationData());
        }
    }

}
