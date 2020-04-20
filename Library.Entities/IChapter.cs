using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    interface IChapter
    {
        int Id { get; set; }
        string Title { get; set; }
        int BookId { get; set; }
    }
}
