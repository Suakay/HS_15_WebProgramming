using Microsoft.AspNetCore.Mvc;

namespace _08_Core_PassingDataToView.Controllers
{
    public class UrunSatController : Controller
    {
        public IActionResult UrunSat()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UrunSat(IFormCollection koleksiyon)
        {
            TempData["SatilanUrunId"] = Convert.ToInt32(koleksiyon["urunID"]);
            TempData["SatilanUrunAdi"] = koleksiyon["UrunAdi"].ToString();
            TempData["SatilanUrunFiyati"] = koleksiyon["urununFiyatİ"].ToString();
            return RedirectToAction("StokAzalt", "Urun");
        }
    }
}
