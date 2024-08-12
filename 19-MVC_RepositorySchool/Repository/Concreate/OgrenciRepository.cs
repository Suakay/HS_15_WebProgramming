using _19_MVC_RepositorySchool.Models;
using _19_MVC_RepositorySchool.Models.Context;
using _19_MVC_RepositorySchool.Repository.Abstruct;

namespace _19_MVC_RepositorySchool.Repository.Concreate
{
    public class OgrenciRepository:BaseRepository<Ogrenci>,IOgrenciRepository
    {
        public OgrenciRepository(ProjectContext context) :base(context) { }

        public void SinavaGir()
        {
            throw new NotImplementedException();
        }


        #region eski
        /*
            private readonly ProjectContext _projectContext;
            public OgrenciRepository(ProjectContext context)
            {
                _projectContext = context;
            }
            public List<Ogrenci> GetAllOgrenci()
            {
                return _projectContext.Ogrenciler.ToList();
            }
            public Ogrenci GetOgrenciById(int id)
            {
                return _projectContext.Ogrenciler.Find(id);
            }
            public bool CreateOgrenci(Ogrenci ogrenci)
            {
                _projectContext.Ogrenciler.Add(ogrenci);
                return _projectContext.SaveChanges() > 0;
            }
            public bool UpdateOgrenci(Ogrenci ogrenci)
            {
                _projectContext.Ogrenciler.Update(ogrenci);
                return _projectContext.SaveChanges() > 0;
            }
            public bool Delete(int id)
            {
                _projectContext.Ogrenciler.Remove(GetOgrenciById(id));
                return _projectContext.SaveChanges() > 0;
            }

        */
    }
    #endregion
}