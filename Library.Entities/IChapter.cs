using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    interface IChapter
    {
        int id { get; set; }
        string title { get; set; }
    }
}
