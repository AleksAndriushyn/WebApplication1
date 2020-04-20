using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int id);
        IList<T> List();
        IList<T> List(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
