using _16_MVC_Validation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace _16_MVC_Validation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Index(SystemUser systemUser)
        {
            if(ModelState.IsValid)
            
                if(ModelState.IsValid)
                    return RedirectToAction("Abaut");
                return View();
            
           
            
        }
        public IActionResult Abaout()
        {
            return View();
        }
    }
}
