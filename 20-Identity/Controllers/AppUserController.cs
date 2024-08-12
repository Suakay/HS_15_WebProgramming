using _20_Identity.Models.Entities.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _20_Identity.Controllers
{
    [Authorize(Roles="admim")]
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager; 
        public AppUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View(_userManager.Users);
        }
    }
}
