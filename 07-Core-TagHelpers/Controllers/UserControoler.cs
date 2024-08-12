using _07_Core_TagHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07_Core_TagHelpers.Controllers
{
    public class UserControoler : Controller
    {
        /* public IActionResult TagHelpers()
          {
              return View();
          }*/
        //localhost:port/Controller/Action
        //localhost:port/User/TagHelpers
        public IActionResult TagHelpers() => View();//Bu action metot geriye user klasorinin altındaki TagHelpers.cshtml uzantılı view'ı döndürür.
        [HttpPost]//HTTP Post isteklerine cevap verecek action metodum.(TagHelpers action name'ine gelen post istekleri)
        public IActionResult TagHelpers(User user)
        {
            return RedirectToAction("HtmlHelpers");
        }
        public IActionResult HtmlHelpers() => View();   

    }
}
