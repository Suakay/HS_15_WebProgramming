using Microsoft.AspNetCore.Mvc;

namespace _17_MVC_StatedManagement_Session.Controllers
{
    public class OturumController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("ad", "Bilge Adam");
            HttpContext.Session.SetInt32("personelYasi", 18);
            HttpContext.Session.SetString("personelMaili", "bilge@bilgeadam.com");
            HttpContext.Session.SetString("personelRolu", "kullanici");

            return View();
        }
        public IActionResult Oturum()
        {
            ViewBag.prsAdi = HttpContext.Session.GetString("AD");
            ViewBag.prsAdi = HttpContext.Session.GetString("personelYasi");
            ViewBag.prsAdi = HttpContext.Session.GetString("personelMaili");
            ViewBag.prsAdi = HttpContext.Session.GetString("personelRolü");
            return View();
        }
    }
}
