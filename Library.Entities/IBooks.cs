using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    interface IBook
    {
        int Id { get; set; }
        int Pages { get; set; }
        string Title { get; set; }
    }
}
