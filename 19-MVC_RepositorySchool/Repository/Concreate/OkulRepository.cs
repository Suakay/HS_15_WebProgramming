using _19_MVC_RepositorySchool.Models.Context;
using _19_MVC_RepositorySchool.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using _19_MVC_RepositorySchool.Repository.Abstruct;

namespace _19_MVC_RepositorySchool.Repository.Concreate
{
    public class OkulRepository:BaseRepository<Okul>,IOkulRepository
    {
        public OkulRepository(ProjectContext context) : base(context) { }

        public void OkulYanginTatbkati()
        {
            throw new NotImplementedException();
        }
    }
}
