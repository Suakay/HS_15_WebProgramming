using Microsoft.AspNetCore.Mvc;

//www.abc.com/Employee/Home/Index
namespace _14_MVC_Areas.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
