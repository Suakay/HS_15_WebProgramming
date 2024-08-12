using Microsoft.AspNetCore.Mvc;

namespace _04_MVCAPP_Sample.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()//Index action methodu
        {
            return View();
        }
    }
}
