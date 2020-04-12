using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Books : IBooks
    {
        [Key]
        public int id { get; set; }
        public int pages { get; set; }
        public string title { get; set; }
    }
}
