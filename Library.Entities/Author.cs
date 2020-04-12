﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class Author : IAuthor
    {
        [Key]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; }
        public int books_amount { get; set; }
    }
}
