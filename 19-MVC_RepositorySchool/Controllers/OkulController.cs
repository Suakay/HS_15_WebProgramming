using _19_MVC_RepositorySchool.Models;
using _19_MVC_RepositorySchool.Repository.Abstruct;
using _19_MVC_RepositorySchool.VM;
using Microsoft.AspNetCore.Mvc;

namespace _19_MVC_RepositorySchool.Controllers
{
    public class OkulController : Controller
    {
        private readonly IOkulRepository _repository;
        public OkulController(IOkulRepository repository)
        {
            _repository = repository;

        }
        public IActionResult Index()
        {
         List<Okul> okullar = _repository.GetAll();
            return View(okullar);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]  
        public IActionResult Create(Okul okul)
        {
            if(_repository.Create(okul))
            
                return RedirectToAction("Index");
            return View();
        }
        public IActionResult Update(int id)
        {
            Okul okul = _repository.GetById(id);
            UpdateOkulVM updateOkulVM = new UpdateOkulVM()
            {
                OkulID = okul.OkulID,
                OkulAdi = okul.OkulAdi,
                OkulAdresi = okul.OkulAdresi,
                OkulEposta = okul.OkulEposta,
                OkulKuruluşTarihi = okul.OkulKuruluşTarihi,
                OkulTelefonu = okul.OkulTelefonu,
            };

            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateOkulVM okulVM)
        {
            if(ModelState.IsValid)
            {
                Okul okul = new Okul()
                {
                    ID=okulVM.OkulID,
                    OkulAdi=okulVM.OkulAdi,
                    OkulAdresi=okulVM.OkulAdresi,
                    OkulEposta=okulVM.OkulEposta,
                    OkulKuruluşTarihi=okulVM.OkulKuruluşTarihi,
                    OkulTelefonu=okulVM.OkulTelefonu,


                };
                if (_repository.Update(okul))

                    return RedirectToAction("Index");
            }
            return View();


        }
       
    }
}
