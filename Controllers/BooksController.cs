using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Bl.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index(string searchTitle)
        {
            var books = _bookService.List();
            if (!String.IsNullOrEmpty(searchTitle))
            {
                books = _bookService.FindByTitle(searchTitle).ToList();
            }
            return View(books);
        }

    }
}