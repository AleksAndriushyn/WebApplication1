﻿using System;
using System.Collections.Generic;
using System.Text;
using Library.Entities;
using Library.DAL.Abstract;

namespace Library.DAL.Impl
{
    public class ReaderRepository : GenericRepository<Reader>, IReaderRepository
    {
        public ReaderRepository(LibraryContext context) : base(context)
        {

        }
    }
}
