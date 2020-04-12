using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    interface IReader
    {
        int id { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
    }
}
