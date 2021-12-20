using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BikeRentalMgmt2.Server.Data;
using BikeRentalMgmt2.Shared.Domain;
using BikeRentalMgmt2.Server.IRepository;

namespace BikeRentalMgmt2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public CustomersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Bikes
        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customers =  await _unitOfWork.Customers.GetAll();
            return Ok(customers);
        }

        // GET: api/Bikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _unitOfWork.Customers.GetAll(q => q.Id == id); 

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // PUT: api/Bikes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.Id)
            {
                return BadRequest();
            }

            //_context.Entry(bike).State = EntityState.Modified;
            _unitOfWork.Customers.Update(customer);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!BikeExists(id))
                if (!await CustomerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Bikes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            //_context.Bikes.Add(bike);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Customers.Insert(customer);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCustomer", new { id = customer.Id }, customer);
        }

        // DELETE: api/Bikes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            //var bike = await _context.Bikes.FindAsync(id);
            var customer = await _unitOfWork.Customers.Get(q => q.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            //_context.Bikes.Remove(bike);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Customers.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> CustomerExists(int id)
        {
            var customer = await _unitOfWork.Customers.Get(q => q.Id == id);
            return customer != null;
            //return _context.Bikes.Any(e => e.Id == id);
        }
    }
}
