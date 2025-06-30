using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using System.Diagnostics;

namespace MVCProject.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Learn()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Tools()
        {
            return View();
        }
        public IActionResult Curriculum()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Platform()
        {
            return View();
        }
        public IActionResult Solution()
        {
            return View();
        }
        public IActionResult Resource()
        {
            return View();
        }
        public IActionResult Contact()
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
