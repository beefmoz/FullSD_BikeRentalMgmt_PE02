using BikeRentalMgmt2.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using BikeRentalMgmt2.Server.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
namespace BikeRentalMgmt2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        UserManager<ApplicationUser> _userManager;
        public AccountsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            var appUserList = await _context.ApplicationUsers.ToListAsync();
            List<ClientApplicationUser> clientAppUserList = new List<ClientApplicationUser>();
            foreach (var appUser in appUserList)
            {
                ClientApplicationUser clientAppUser = new ClientApplicationUser(appUser);
                clientAppUserList.Add(clientAppUser);
            }
            return Ok(clientAppUserList);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRole(string id)
        {
            var appUserList = await _context.ApplicationUsers.ToListAsync();
            foreach (var appUser in appUserList)
            {
                if (appUser.Id == id)
                {
                    var UserResult = await _userManager.IsInRoleAsync(appUser, "Administrator");
                    if (UserResult)
                    {
                        return Ok("Administrator");
                    }
                    UserResult = await _userManager.IsInRoleAsync(appUser, "Staff");
                    if (UserResult)
                    {
                        return Ok("Staff");
                    }
                    UserResult = await _userManager.IsInRoleAsync(appUser, "Customer");
                    if (UserResult)
                    {
                        return Ok("Customer");
                    }
                }
            }
            return NotFound();
        }
    }
}
//End of Code