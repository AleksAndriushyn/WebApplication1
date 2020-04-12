using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    interface IBooks
    {
        int id { get; set; }
        int pages { get; set; }
        string title { get; set; }
    }
}
