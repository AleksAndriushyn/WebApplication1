using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        void Create(T item);
        T FindById(int id);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Func<T, bool> predicate);
        void Remove(T item);
        void Update(T item);
    }
}
