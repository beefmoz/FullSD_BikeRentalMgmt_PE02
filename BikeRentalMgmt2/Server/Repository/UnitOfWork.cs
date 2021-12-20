using BikeRentalMgmt2.Server.Data;
using BikeRentalMgmt2.Server.IRepository;
using BikeRentalMgmt2.Server.Models;
using BikeRentalMgmt2.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BikeRentalMgmt2.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Bike> _bikes;
        private IGenericRepository<Staff> _staff;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Branch> _branches;
        private IGenericRepository<RentOrder> _rentorders;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Bike> Bikes
            => _bikes ??= new GenericRepository<Bike>(_context);
        public IGenericRepository<Staff> Staff
            => _staff ??= new GenericRepository<Staff>(_context);
        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Branch> Branches
            => _branches ??= new GenericRepository<Branch>(_context);

        public IGenericRepository<RentOrder> RentOrders
            => _rentorders ??= new GenericRepository<RentOrder>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {

            }

            await _context.SaveChangesAsync();
        }
    }
}