﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Library.DAL.Abstract;
namespace Library.DAL.Impl
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        DbContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<T> Get(Func<T, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public T FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Create(T item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetWithInclude(params Expression<Func<T, object>>[] includeProperties)
        {
            return Include(includeProperties).ToList();
        }

        public IEnumerable<T> GetWithInclude(Func<T, bool> predicate,
            params Expression<Func<T, object>>[] includeProperties)
        {
            var query = Include(includeProperties);
            return query.Where(predicate).ToList();
        }

        private IQueryable<T> Include(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbSet.AsNoTracking();
            return includeProperties
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }
    }
}
