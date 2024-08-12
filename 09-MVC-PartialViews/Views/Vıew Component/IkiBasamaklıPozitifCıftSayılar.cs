using Microsoft.AspNetCore.Mvc;

namespace _09_MVC_PartialViews.Views.Vıew_Component
{
    public class IkiBasamaklıPozitifCıftSayılar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<int> liste =new List<int>();
            for(int i = 0; i < 100; i+=2)
            {
               liste.Add(i);
            }
            return View(liste);
        }
    }
}
