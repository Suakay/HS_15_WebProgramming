using _19_MVC_RepositorySchool.Models.Context;
using _19_MVC_RepositorySchool.Models;
using Microsoft.EntityFrameworkCore;
using _19_MVC_RepositorySchool.Repository.Abstruct;
using System.Linq.Expressions;

namespace _19_MVC_RepositorySchool.Repository.Concreate
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ProjectContext _projectContext;
        private DbSet<TEntity> _table;
        public BaseRepository(ProjectContext context)
        {
            _projectContext = context;
            _table = _projectContext.Set<TEntity>();
        }
        public bool Create(TEntity entity)
        {
            _table.Add(entity);
            return SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            _table.Remove(GetById(id));
            return SaveChanges() > 0;
        }

        public List<TEntity> GetAll()
        {
            return _table.ToList();
        }

        public TEntity GetById(int id)
        {

            return _table.Find(id);
        }

        public List<TEntity> GetDefault(Expression<Func<TEntity, bool>> exp)
        {
            return _table.Where(exp).ToList();
        }

        public int Save()
        {
            return _projectContext.SaveChanges();

        }

        public bool Update(TEntity entity)
        {
            _table.Update(entity);
            return SaveChanges() > 0;
        }
        private int SaveChanges()
        {
            return _projectContext.SaveChanges();

        }
    }









  
   
  
   
   
  

   


}