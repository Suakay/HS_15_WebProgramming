using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace _08_Core_PassingDataToView.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Tarih =
            DateTime.Now.ToLongDateString();
            return View();
            ViewBag.Koleksiyon = new string[] { "Bilge", "Ayşe", "Ali", "Veli" };
            ViewBag["Saat"] =
                DateTime.Now.ToLongDateString();
            TempData["Gun"] = DateTime.Now.Day;
            return View();




        }
        public IActionResult Index2()
        {
            TempData["Ay"]= DateTime.Now.Month;
            return RedirectToAction("Index3");
        }
        public IActionResult Index3()
        {
            return View();
        }
    }
}
