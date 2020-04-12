using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    interface IReaders_Card
    {
        int id { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        DateTime date { get; set; }
        string book_title { get; set; }
    }
}
