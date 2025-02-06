using System.Linq.Expressions;

namespace Patient_Care_Management_System.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        Task<List<T>> GetAll();
        Task<T> Get(Expression<Func<T, bool>> predicate);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
