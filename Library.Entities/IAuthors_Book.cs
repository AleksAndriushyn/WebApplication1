using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    interface IAuthors_Book
    {
        int id { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        string book_title { get; set; }
    }
}
