using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vividly.Models;

namespace Vividly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie>GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Batman" },
                new Movie { Id = 2, Name = "Superman" }
            };

        }
    }
}