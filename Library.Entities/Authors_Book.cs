using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Authors_Book : IAuthors_Book
    {
        [Key]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string book_title { get; set; }
    }
}
