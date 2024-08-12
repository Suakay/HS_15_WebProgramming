using _13_MVC_ActıonReturnType.Models;
using Microsoft.AspNetCore.Mvc;

namespace _13_MVC_ActıonReturnType.Controllers
{
    public class HomeController : Controller
    {
        //Bir view döndrür.İslemciye yanıt olarak HTML döndürür.
        //MVC işlemiyürütülürken aynı ismiyle(actionın aynı ismiyle)bir view dosyası bulur.Eğer ilgli
        //controller adı ile oluşturulan veya shared klasörünün altında bu action adıyla bir view dosyası bulmazsa hata verir.
        public IActionResult Index()
        {
            ViewBag.Adi = "Bilge";
            ViewBag.Soyadi = "Adam";
            return View();
        }
        public IActionResult UserAction()
        {
            AppUser user = new AppUser()
            {
                ID = 1,
                FirstName = "Bilge",
                LastName = "Adam",
                Address = "İTÜ ARI 3 MASLAK",

            };
            return View(user);

        } 
        public JsonResult UserModel()
        {
            AppUser user = new AppUser()
            {
                ID = 1,
                FirstName = "Bilge",
                LastName = "Adama",
                Address="İTÜ ARI MASLAK"
            };
            return Json(user);  
        }
        
    }
}
