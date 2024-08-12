using _13_MVC_ActionResultType.Models;
using Microsoft.AspNetCore.Mvc;

namespace _13_MVC_ActionResultType.Controllers
{
    public class HomeController1 : Controller
    {
        //Bir View döndürür.İstemciye yanıt olarak HTML döndürür.
        //MVC işlemi yürütürken aynı isimle (actionu aynı smiyle) bir view dosyası bulur.Eğer ilgili
        //controller adı ile oluşturulan veya sharead klasörünün altında bu action adıyla bir view dosyası bulamazssa hata veriri.

        public IActionResult Index()
        {
            ViewBag.Adi = "Bilge";
            ViewData["Soyadi"] = "Adam";
            return View();
        }
        public IActionResult UserAction()
        {
            AppUser user = new AppUser();
            {
              
                
              
                
               
                
            };
            return View(user);  
            //Views'ın altında Home isimli klasörü bulunur.Bu klasörün altında veya Sharead ın altında UserAction isimli .cshtml uzantılı bir dosya arar.Ve o dosyaya burada beirtilen modeli gönderir.
        }
    }
}
