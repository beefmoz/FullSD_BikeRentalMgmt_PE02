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
    public class BranchesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        public BranchesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Branches
        [HttpGet]
        public async Task<IActionResult> GetBranches()
        {
            var branches=  await _unitOfWork.Branches.GetAll();
            return Ok(branches);
        }

        // GET: api/Bikes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Branch>> GetBranch(int id)
        {
            var branch = await _unitOfWork.Branches.GetAll(q => q.Id == id); 

            if (branch == null)
            {
                return NotFound();
            }

            return Ok(branch);
        }

        // PUT: api/Bikes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBranch(int id, Branch branch)
        {
            if (id != branch.Id)
            {
                return BadRequest();
            }

            //_context.Entry(bike).State = EntityState.Modified;
            _unitOfWork.Branches.Update(branch);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!BikeExists(id))
                if (!await BranchExists(id))
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
        public async Task<ActionResult<Branch>> PostBranch(Branch branch)
        {
            //_context.Bikes.Add(bike);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Branches.Insert(branch);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBranch", new { id = branch.Id }, branch);
        }

        // DELETE: api/Bikes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranch(int id)
        {
            //var bike = await _context.Bikes.FindAsync(id);
            var branch = await _unitOfWork.Branches.Get(q => q.Id == id);
            if (branch == null)
            {
                return NotFound();
            }

            //_context.Bikes.Remove(bike);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Branches.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> BranchExists(int id)
        {
            var branch = await _unitOfWork.Branches.Get(q => q.Id == id);
            return branch != null;
            //return _context.Bikes.Any(e => e.Id == id);
        }
    }
}
