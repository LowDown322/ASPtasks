using Microsoft.AspNetCore.Mvc;
using StudentExerciseMVC.Models;

namespace StudentExerciseMVC.Controllers
{
  public class MovieController : Controller
  {
    private static List<MovieModelClass> _movies = new List<MovieModelClass>();
    public IActionResult Index1()
    {
     // MovieModelClass movie = new MovieModelClass();
    //  { movie.MovieTitle = "the godfather"; movie.Director = "Francis Ford Coppola"; movie.Year = 1972; }
      return View(_movies);
    }
    public IActionResult Index2()
    {
      var movieVm = new MovieModelClass();
      return View(movieVm);
    }
    public IActionResult CreateMovie(MovieModelClass movieViewModel) 
    {

      _movies.Add(movieViewModel);
      return RedirectToAction(nameof(Index));
      // return View("")
    }
  }
}
