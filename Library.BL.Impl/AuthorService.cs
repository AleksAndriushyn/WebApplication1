using Library.DAL.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using Library.Bl.Abstract;

namespace Library.Bl.Impl
{
    public class AuthorService : AuthorRepository, IAuthorService
    {
        public AuthorService(LibraryContext context) : base(context)
        {

        }
    }
}
