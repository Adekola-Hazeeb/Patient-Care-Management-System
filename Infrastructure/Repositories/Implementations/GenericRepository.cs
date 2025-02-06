using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Patient_Care_Management_System.Application.Interfaces.Repositories;
using Patient_Care_Management_System.Infrastructure.Context;

namespace Patient_Care_Management_System.Infrastructure.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly PatientCareManagementSystemDb _context;
        private readonly DbSet<T> Entity;
        public GenericRepository(PatientCareManagementSystemDb context)
        {
            _context = context;
            Entity = context.Set<T>();
        }
        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public async Task<T?> Get(Expression<Func<T, bool>> predicate)
        {
            return await Entity.FirstOrDefaultAsync(predicate);
        }

        public async Task<List<T>> GetAll()
        {
            return await Entity.ToListAsync();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
