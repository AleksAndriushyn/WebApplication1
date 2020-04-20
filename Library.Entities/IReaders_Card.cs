using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    interface IReaders_Card
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime Date { get; set; }
        int BookId { get; set; }
        int ReaderId { get; set; }
    }
}
