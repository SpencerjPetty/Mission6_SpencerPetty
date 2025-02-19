using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = _context.Categories.ToList(); // Get the categories from the database
            return View(new Movie());
        }

        [HttpPost]
        public IActionResult AddMovieForm(Movie movie) // Add Movie Form POST
        {
                if (ModelState.IsValid == false) // If the form is not valid
            {
                ViewBag.Categories = _context.Categories.ToList(); // Get the categories from the database
                return View(movie); // Return the form with the data
            }
            else
            {
                _context.Movies.Add(movie);
                _context.SaveChanges(); // Add and save the movie to the database
                return View("Confirmation", movie);
            }
        }
        
        public IActionResult MovieList() // Movie List page
        {
            var movies = _context.Movies
                .Include(m => m.Category)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id) // Edit page
        {
            var recordToEdit = _context.Movies.Find(id);

            ViewBag.Categories = _context.Categories.ToList(); // Get the categories from the database
            return View("AddMovieForm", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedMovie) // Edit Post
        {
            _context.Update(updatedMovie);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id) // Show Delete Page
        {
            var recordToDelete = _context.Movies.Find(id);
            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Movie movie) // Delete Post
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
