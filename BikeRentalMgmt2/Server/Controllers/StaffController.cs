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
    public class StaffController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public StaffController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Bikes
        [HttpGet]
        public async Task<IActionResult> GetStaff()
        {
            var staff =  await _unitOfWork.Staff.GetAll();
            return Ok(staff);
        }

        // GET: api/Bikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Staff>> GetStaff(int id)
        {
            var staff = await _unitOfWork.Staff.GetAll(q => q.Id == id); 

            if (staff == null)
            {
                return NotFound();
            }

            return Ok(staff);
        }

        // PUT: api/Bikes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff staff)
        {
            if (id != staff.Id)
            {
                return BadRequest();
            }

            //_context.Entry(bike).State = EntityState.Modified;
            _unitOfWork.Staff.Update(staff);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!BikeExists(id))
                if (!await StaffExists(id))
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
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {
            //_context.Bikes.Add(bike);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Staff.Insert(staff);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStaff", new { id = staff.Id }, staff);
        }

        // DELETE: api/Bikes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            //var bike = await _context.Bikes.FindAsync(id);
            var staff = await _unitOfWork.Staff.Get(q => q.Id == id);
            if (staff == null)
            {
                return NotFound();
            }

            //_context.Bikes.Remove(bike);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Staff.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> StaffExists(int id)
        {
            var staff = await _unitOfWork.Staff.Get(q => q.Id == id);
            return staff != null;
            //return _context.Bikes.Any(e => e.Id == id);
        }
    }
}
