using Microsoft.AspNetCore.Mvc;

namespace _17_MVC_StatedManagement_Session.Controllers
{
    public class CerezController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Response.Cookies.Append("Ad", "Bilge Adam");
            HttpContext.Response.Cookies.Append("personelYasi", "25");
            HttpContext.Response.Cookies.Append("personelMaili", "bilge@bilgeadam.com");
            HttpContext.Response.Cookies.Append("personelRolu", "kullanıcı");
           
            return View();
        }
        public IActionResult Cerez()
        {
            string ad = CerezGetir("Ad");
            string personelYasi = CerezGetir("personelYasi");
            string personelMaili = CerezGetir("personelMaili");
            string personelRolü = CerezGetir("personelRolü");

            ViewBag.prsAdi = ad;
            ViewBag.prsYasi = personelYasi;
            ViewBag.prs.Maili=personelMaili;
            ViewBag.prsRolu = personelRolü;

            return View();
        }
        private string CerezGetir(string key)
        {
             HttpContext.Request.Cookies.TryGetValue(key, out string value);
            return value;
        }
    }
}
