using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class Readers_Card : IReaders_Card
    {
        [Key]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public string book_title { get; set; }
    }
}
