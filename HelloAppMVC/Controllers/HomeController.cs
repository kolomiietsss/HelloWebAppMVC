using HelloAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult SayHelloViewBag(string name)
        {
            ViewBag.Message = name;
            return View("Index");
        }

        public IActionResult SayHelloContent(string name)
        {
            string message = "Здарова, " + name + "!";
            return Content(message);
        }

        public IActionResult SayHelloView(string name)
        {
            ViewBag.Message = name;
            return View("View");
        }

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}