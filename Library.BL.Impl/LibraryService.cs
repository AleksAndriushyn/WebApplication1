using Library.Bl.Abstract;
using Library.DAL.Abstract;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Bl.Impl
{
    public class LibraryService : ILibraryService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IAuthors_BookRepository _authorsBookRepository;
        public LibraryService(IAuthorRepository authorRepository, IAuthors_BookRepository authorsBookRepository)
        {
            _authorRepository = authorRepository;
            _authorsBookRepository = authorsBookRepository;
        }
        public IEnumerable<Author> FindByAmountOfBooks(int AmountOfBooks)
        {
            List<Author> authors = new List<Author>();
            foreach (var a in _authorRepository.List())
            {
                if(_authorsBookRepository.List(obj => obj.AuthorId == a.Id).Count() == AmountOfBooks)
                {
                    authors.Add(a);
                }
            }
            return authors;
        }
    }
}
