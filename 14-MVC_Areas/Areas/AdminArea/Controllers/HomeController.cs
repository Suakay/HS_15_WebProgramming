using Microsoft.AspNetCore.Mvc;

namespace _14_MVC_Areas.Areas.AdminArea.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
