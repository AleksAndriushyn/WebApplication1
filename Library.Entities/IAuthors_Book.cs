﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    interface IAuthors_Book
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int AuthorId { get; set; }
        int BookId { get; set; }
    }
}
