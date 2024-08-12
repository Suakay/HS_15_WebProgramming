using System.ComponentModel.DataAnnotations.Schema;

namespace _19_MVC_RepositorySchool.Models
{
    public class Ogrenci:BaseEntity
    {
        public int OgrenciID { get; set; }  
        public string OgrenciAdı { get; set; }  
        public string OgrenciSoyadi {  get; set; }
        public string OgrenciNo {  get; set; }  
        public DateTime OgrenciDogumTarihi { get; set; }    
        public byte OgrenciSinifi {  get; set; }    
        public string OgrenciAdresi { get; set; }   
        public string OgrenciVeliTel { get; set; }
        [ForeignKey("OgrencininOkulu")]
        public int OgrenciOkulu {get; set; }
        public Okul OgrencininOkulu { get; set; }   

    }
}
