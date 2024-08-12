using Microsoft.AspNetCore.Mvc;

namespace _08_Core_PassingDataToView.Controllers
{
    public class UrunController1 : Controller
    {
        public IActionResult StokAzalt()
        {
            int id = Convert.ToInt32(TempData["SatilanUrunId"]);
            string adi = TempData["SatilanUrunAdi"].ToString();
            string fiyat = TempData["SatilanUrunFiyat"].ToString();
            ViewBag.id = id;    
            ViewBag.adi = adi;
            ViewBag.fiyat = fiyat;
            return View();


        }
    }
}
