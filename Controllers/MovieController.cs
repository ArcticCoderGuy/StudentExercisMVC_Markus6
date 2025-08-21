using Microsoft.AspNetCore.Mvc;
using StudentExercisMVC_Markus6.Models;

namespace StudentExercisMVC_Markus6.Controllers
{
    public class MovieController : Controller
    {
        private static List<Movie> Movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "The Godfather", Director = "Francis Ford Coppola", Year = 1972, ImageUrl = "/images/Movie-Godfather.png" },
            new Movie { Id = 2, Title = "The Usual Suspects", Director = "Bryan Singer", Year = 1995, ImageUrl = "/images/Movie-UsualSuspect.png" },
            new Movie { Id = 3, Title = "Pulp Fiction", Director = "Quentin Tarantino", Year = 1994, ImageUrl = "/images/Movie-PulpFiction.png" },
            new Movie { Id = 4, Title = "Aliens", Director = "James Cameron", Year = 1986, ImageUrl = "/images/Aliens_poster.jpg" }
        };

        public IActionResult Index()
        {
            return View(Movies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movie.Id = Movies.Count + 1;
                Movies.Add(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }
    }
}
