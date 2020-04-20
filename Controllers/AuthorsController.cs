using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Bl.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IAuthorService _authorService;
        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }
        public IActionResult Index(string searchString, string searchDate)
        {
            DateTime dateofbirth = new DateTime();
            dateofbirth = Convert.ToDateTime(searchDate);

            var authors = _authorService.List();
            if (!String.IsNullOrEmpty(searchString))
            {
                authors = _authorService.FindByFirstName(searchString).ToList();
            }
            if (!String.IsNullOrEmpty(searchDate))
            {
                authors = _authorService.FindByDate(dateofbirth).ToList();
            }

            return View(authors);
        }
    }
}