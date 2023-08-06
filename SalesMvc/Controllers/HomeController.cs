using Microsoft.AspNetCore.Mvc;
using SalesMvc.Models;
using System.Diagnostics;

namespace SalesMvc.Controllers
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

        public IActionResult About()
        {
            ViewData["Message"] = "First Web MVC Using ASP.NET and C#";

            return View();  
        }

        public IActionResult Contact()
        {
            ViewData["email"] = "vitoxdantas@gmail.com";
            
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