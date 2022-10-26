using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repass_e.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<TEntity, TContext>
        where TEntity : class
        where TContext:DbContext
    {
        protected readonly TContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(TContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }
        public IQueryable<TEntity> GetAllReadOnly()
        {
            return _dbSet.AsNoTracking();
        }
        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        public virtual void MassDelete(List<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
            _context.SaveChanges();
        }
        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void Edit(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void MassAdd(List<TEntity> entities)
        {
            _dbSet.AddRange(entities);
            _context.SaveChanges();
        }
    }
}
