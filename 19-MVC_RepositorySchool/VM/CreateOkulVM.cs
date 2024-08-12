using _19_MVC_RepositorySchool.Models;

namespace _19_MVC_RepositorySchool.VM
{
    public class CreateOkulVM
    {
        public int OkulID { get; set; }
        public string OkulAdi { get; set; }
        public string OkulAdresi { get; set; }
        public string OkulTelefonu { get; set; }
        public string? OkulEposta { get; set; }
        public DateTime? OkulKuruluşTarihi { get; set; }
        //Navigation
        public List<Ogrenci> OkulOgrencileri { get; set; }
       
    }
}
