using Library.DAL.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using Library.Bl.Abstract;

namespace Library.Bl.Impl
{
    public class Authors_BookService : Authors_BookRepository, IAuthors_BookService
    {
        public Authors_BookService(LibraryContext context) : base(context)
        {

        }
    }
}
