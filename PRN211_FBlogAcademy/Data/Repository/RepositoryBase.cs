using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{

    public class RepositoryBase<T> where T : class
    {
        FBlogAcademyContext _context;
        DbSet<T> _dbSet;

        public RepositoryBase()
        {
            _context = new FBlogAcademyContext();
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public void DeleteEntity(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public void UpdateEntity(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
