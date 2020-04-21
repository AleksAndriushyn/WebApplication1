using Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Bl.Abstract
{
    public interface ILibraryService 
    {
        IEnumerable<Author> FindByAmountOfBooks(int AmountOfBooks);
    }
}
