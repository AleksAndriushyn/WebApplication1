using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Bl.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AuthorsBooksController : Controller
    {
        private readonly IAuthors_BookService _authorsBookService;
        public AuthorsBooksController(IAuthors_BookService authorsBookService)
        {
            _authorsBookService = authorsBookService;
        }
        public IActionResult Index(string AuthorName)
        {
            var authorsbooks = _authorsBookService.List();
            if (!String.IsNullOrEmpty(AuthorName))
            {
                authorsbooks = _authorsBookService.FindByAuthor(AuthorName).ToList();
            }
            return View(authorsbooks);
        }
    }
}