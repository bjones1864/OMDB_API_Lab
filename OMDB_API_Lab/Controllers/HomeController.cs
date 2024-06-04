using Microsoft.AspNetCore.Mvc;
using OMDB_API_Lab.Models;
using System.Diagnostics;

namespace OMDB_API_Lab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieSearch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieSearch(string title)
        {
            return View(MovieDAL.GetMovie(title));
        }

        public IActionResult MovieNight(string title1, string title2, string title3)
        {
            return View(new List<MovieModel>() { MovieDAL.GetMovie(title1), MovieDAL.GetMovie(title2), MovieDAL.GetMovie(title3) });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
