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
    public class AuthorService : AuthorRepository, IAuthorService
    {
        public AuthorService(LibraryContext context) : base(context)
        {

        }
        public List<DTOAuthor> List()
        {
            return this.EntityList().Select(obj => AuthorMapper.Map(obj)).ToList();
        }
        public IEnumerable<DTOAuthor> FindByFirstName(string searchString)
        {
            var authors = this.List();
            authors = authors.Where(s => s.FirstName.Contains(searchString)).ToList();
            return authors;
        }
        public IEnumerable<DTOAuthor> FindByDate(DateTime searchDate)
        {
            var authors = this.List();
            authors = authors.Where(s => s.DateOfBirth == searchDate).ToList();
            return authors;
        }
    }
}
