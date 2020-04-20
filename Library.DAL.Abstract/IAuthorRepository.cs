using Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DAL.Abstract
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        IEnumerable<Author> FindByFirstName(string stringSearch);
        IEnumerable<Author> FindByDate(DateTime searchDate);
    }
}
