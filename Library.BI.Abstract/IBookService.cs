using Library.DAL.Abstract;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Bl.Abstract
{
    public interface IBookService : IBookRepository
    {
        public List<DTOBook> List();
        public IEnumerable<DTOBook> FindByTitle(string searchTitle);
    }
}
