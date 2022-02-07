﻿using System;
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
    public class BikesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public BikesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Bikes
        [HttpGet]
        public async Task<IActionResult> GetBikes()
        {
            var bikes=  await _unitOfWork.Bikes.GetAll(includes: q => q.Include(x => x.Branch));
            return Ok(bikes);
        }

        // GET: api/Bikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bike>> GetBike(int id)
        {
            var bike = await _unitOfWork.Bikes.Get(q => q.Id == id); 

            if (bike == null)
            {
                return NotFound();
            }

            return Ok(bike);
        }

        // PUT: api/Bikes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBike(int id, Bike bike)
        {
            if (id != bike.Id)
            {
                return BadRequest();
            }

            //_context.Entry(bike).State = EntityState.Modified;
            _unitOfWork.Bikes.Update(bike);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!BikeExists(id))
                if (!await BikeExists(id))
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
        public async Task<ActionResult<Bike>> PostBike(Bike bike)
        {
            //_context.Bikes.Add(bike);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Bikes.Insert(bike);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBike", new { id = bike.Id }, bike);
        }

        // DELETE: api/Bikes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBike(int id)
        {
            //var bike = await _context.Bikes.FindAsync(id);
            var bike = await _unitOfWork.Bikes.Get(q => q.Id == id);
            if (bike == null)
            {
                return NotFound();
            }

            //_context.Bikes.Remove(bike);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Bikes.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> BikeExists(int id)
        {
            var bike = await _unitOfWork.Bikes.Get(q => q.Id == id);
            return bike != null;
            //return _context.Bikes.Any(e => e.Id == id);
        }
    }
}
