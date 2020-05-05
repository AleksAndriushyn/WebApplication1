using Library.DAL.Abstract;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Bl.Abstract
{
    public interface IReaders_CardService : IReaders_CardRepository
    {
        public List<DTOReaders_Card> List();
        public void Insert(DTOReaders_Card readers_Card);
        public DTOReaders_Card Get(int id);
        public void Update(DTOReaders_Card model);
    }
}
