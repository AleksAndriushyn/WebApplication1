using System;
using System.Collections.Generic;
using System.Text;
using Library.Entities;
using Library.DAL.Abstract;
using System.Linq;

namespace Library.DAL.Impl
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(LibraryContext context) : base(context)
        {

        }
       
        public IEnumerable<Book> FindByTitle(string searchTitle)
        {
            //var authors = _context.Set<Author>().ToList
            var books = this.List();
            books = books.Where(s => s.Title.Contains(searchTitle)).ToList();
            return books;
        }
    }
}
