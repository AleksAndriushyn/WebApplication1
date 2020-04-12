using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Reader : IReader
    {
        [Key]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
