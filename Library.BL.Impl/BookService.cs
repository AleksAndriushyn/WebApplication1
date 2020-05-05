using Library.DAL.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using Library.Bl.Abstract;
using Library.Models;
using System.Linq;
using Library.DAL.Impl.Mappers;

namespace Library.Bl.Impl
{
    public class BookService : BookRepository, IBookService
    {
        public BookService(LibraryContext context) : base(context)
        {

        }
        public List<DTOBook> List()
        {
            return this.EntityList().Select(obj => BookMapper.Map(obj)).ToList();
        }
        public IEnumerable<DTOBook> FindByTitle(string searchTitle)
        {
            var books = this.EntityList();
            books = books.Where(s => s.Title.Contains(searchTitle)).ToList();
            return books.Select(obj => BookMapper.Map(obj)).ToList();
        }
    }
}
