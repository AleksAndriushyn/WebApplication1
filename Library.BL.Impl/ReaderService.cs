using Library.DAL.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using Library.Bl.Abstract;

namespace Library.Bl.Impl
{
    public class ReaderService : ReaderRepository, IReaderService
    {
        public ReaderService(LibraryContext context) : base(context)
        {

        }

        
    }
}
