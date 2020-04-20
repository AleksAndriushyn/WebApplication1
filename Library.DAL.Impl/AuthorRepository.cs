using System;
using System.Collections.Generic;
using System.Text;
using Library.Entities;
using Library.DAL.Abstract;
using System.Linq;

namespace Library.DAL.Impl
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(LibraryContext context) : base(context)
        {
            
        }
        public IEnumerable<Author> FindByFirstName(string searchString)
        {
            //var authors = _context.Set<Author>().ToList
            var authors = this.List();
            authors = authors.Where(s => s.FirstName.Contains(searchString)).ToList();
            return authors;
        }
        public IEnumerable<Author> FindByDate(DateTime searchDate)
        {
            //var authors = _context.Set<Author>().ToList
            var authors = this.List();
            authors = authors.Where(s => s.DateOfBirth == searchDate).ToList();
            return authors;
        }
        //public IEnumerable<Author> FindByAmount()
        //{

        //}
    }
}
