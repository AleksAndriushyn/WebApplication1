using Library.DAL.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using Library.Bl.Abstract;

namespace Library.Bl.Impl
{
    public class Readers_CardService : Readers_CardRepository, IReaders_CardService
    {
        public Readers_CardService(LibraryContext context) : base(context)
        {

        }
    }
}
