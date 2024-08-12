
using _15_MVC_JqueryAjax.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _15_MVC_JqueryAjax.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Personel(PersonelVM personelVM)
        {
            return View(personelVM);
        }



    }
}
