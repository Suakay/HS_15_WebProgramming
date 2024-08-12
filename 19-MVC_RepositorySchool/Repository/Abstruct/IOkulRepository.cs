using _19_MVC_RepositorySchool.Models;

namespace _19_MVC_RepositorySchool.Repository.Abstruct
{
    public interface IOkulRepository:IBaseRepository<Okul>
    {
        public void OkulYanginTatbkati();
    }
}
