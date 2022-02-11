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
    public class RentOrdersController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public RentOrdersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Bikes
        [HttpGet]
        public async Task<IActionResult> GetRentOrders()
        {
            //return NotFound();
            var rentOrders =  await _unitOfWork.RentOrders.GetAll();
            return Ok(rentOrders);
        }

        // GET: api/Bikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RentOrder>> GetRentOrder(int id)
        {
            var rentOrder = await _unitOfWork.RentOrders.Get(q => q.Id == id); 

            if (rentOrder == null)
            {
                return NotFound();
            }

            return Ok(rentOrder);
        }

        // PUT: api/Bikes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRentOrder(int id, RentOrder rentOrder)
        {
            if (id != rentOrder.Id)
            {
                return BadRequest();
            }

            //_context.Entry(bike).State = EntityState.Modified;
            _unitOfWork.RentOrders.Update(rentOrder);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!BikeExists(id))
                if (!await RentOrderExists(id))
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
        public async Task<ActionResult<RentOrder>> PostRentOrder(RentOrder rentOrder)
        {
            //_context.Bikes.Add(bike);
            //await _context.SaveChangesAsync();

            await _unitOfWork.RentOrders.Insert(rentOrder);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRentOrder", new { id = rentOrder.Id }, rentOrder);
        }

        // DELETE: api/Bikes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRentOrder(int id)
        {
            //var bike = await _context.Bikes.FindAsync(id);
            var rentOrder = await _unitOfWork.RentOrders.Get(q => q.Id == id);
            if (rentOrder == null)
            {
                return NotFound();
            }

            //_context.Bikes.Remove(bike);
            //await _context.SaveChangesAsync();
            await _unitOfWork.RentOrders.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> RentOrderExists(int id)
        {
            var rentOrder = await _unitOfWork.RentOrders.Get(q => q.Id == id);
            return rentOrder != null;
            //return _context.Bikes.Any(e => e.Id == id);
        }
    }
}
