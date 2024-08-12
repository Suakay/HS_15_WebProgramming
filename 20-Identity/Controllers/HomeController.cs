using _20_Identity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Diagnostics;

namespace _20_Identity.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()=>View();
    }
}
