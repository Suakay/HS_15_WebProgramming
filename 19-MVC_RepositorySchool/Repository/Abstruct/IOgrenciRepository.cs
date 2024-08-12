using _19_MVC_RepositorySchool.Models;

namespace _19_MVC_RepositorySchool.Repository.Abstruct
{
    public interface IOgrenciRepository:IBaseRepository<Ogrenci> 
    {
        public void SinavaGir();

    }
}
