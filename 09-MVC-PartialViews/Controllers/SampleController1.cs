using Microsoft.AspNetCore.Mvc;

namespace _09_MVC_PartialViews.Controllers
{
    public class SampleController1 : Controller
    {
        public PartialViewResult Sample()
        {
            return PartialView("_SampleView");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
