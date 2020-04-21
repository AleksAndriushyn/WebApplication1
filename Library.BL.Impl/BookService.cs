using Library.DAL.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using Library.Bl.Abstract;

namespace Library.Bl.Impl
{
    public class BookService : BookRepository, IBookService
    {
        public BookService(LibraryContext context) : base(context)
        {

        }
    }
}
