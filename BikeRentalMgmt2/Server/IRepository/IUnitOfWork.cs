using BikeRentalMgmt2.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRentalMgmt2.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Bike> Bikes { get; }
        IGenericRepository<Staff> Staff { get; }
        IGenericRepository<Branch> Branches { get; }
        IGenericRepository<RentOrder> RentOrders { get; }
        IGenericRepository<Customer> Customers { get; }
    }
}