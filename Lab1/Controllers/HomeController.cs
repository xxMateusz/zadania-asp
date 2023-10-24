using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using System.Diagnostics;

namespace Lab1.Controllers
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
        public IActionResult About(string author, int? id)

        {
            // string author = Request.Query["author"];
            //string strid = Request.Query["id"];
            //if(int.TryParse(strid,out var id))
            //{

            //}
            //ViewBag.Author = author + " id = " + id;
            if (id == null || author == null)
            {
                return BadRequest();
            }
            ViewBag.Author = author + " id= " + id;
            return View();
        }
        public IActionResult Birthday(Birthday urodziny)
        {
            ViewBag.powitanie = $"Witaj {urodziny.Imie} masz {DateTime.Now.Year - urodziny.Rok} Lat";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}