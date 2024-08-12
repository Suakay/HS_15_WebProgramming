using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Linq.Expressions;

namespace _19_MVC_RepositorySchool.Repository.Abstruct
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        public List<TEntity> GetAll();
        public TEntity GetById(int id);
        public bool Update(TEntity entity);
        public bool Create(TEntity entity);
        public bool Delete(int id);
        public int Save();
        //Sorgulama
        public List<TEntity> GetDefault(Expression<Func<TEntity, bool>> exp);


    }
}
