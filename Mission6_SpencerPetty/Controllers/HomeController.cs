using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_SpencerPetty.Models;

namespace Mission6_SpencerPetty.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _context; // setting up the context variable

        public HomeController(MovieFormContext context) // constructor
        {
            _context = context;
        }

        public IActionResult Index() // Home page
        {
            return View();
        }

        public IActionResult GetToKnowJoel() // Get to Know Joel page
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovieForm() // Add Movie Form page
        {
            return View();
        }
        public IActionResult Confirmation() // Confirmation page
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovieForm(Movie movie) // Add Movie Form POST
        {
            _context.Movies.Add(movie);
            _context.SaveChanges(); // Add and save the movie to the database
            return RedirectToAction("Confirmation");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
