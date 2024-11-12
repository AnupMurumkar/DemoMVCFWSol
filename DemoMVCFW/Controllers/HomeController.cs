using DemoMVCFW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoMVCFW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Details()
        {
            ViewData["title"] = "Student details page";
            ViewData["header"] = "student details";

            Student student = new Student()
            {
                id = 5, name = "vanita" , age = 45 , email = "vanita@gmail.com",
            };

            ViewData["student"] = student;
            return View();
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
