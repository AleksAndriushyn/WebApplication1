using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Library.DAL.Abstract;
namespace Library.DAL.Impl
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly LibraryContext _context;

        public GenericRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public IList<T> List()
        {
            return _context.Set<T>().ToList();
        }

        public IList<T> List(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).ToList();
        }

        public void Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
