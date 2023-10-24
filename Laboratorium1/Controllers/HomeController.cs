using Laboratorium1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorium1.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult About(Operator op)
        {
            ViewBag.Op = op;
            return View();
        }
        public enum Operator
        {
            Unknown, Add, Mul, Sub, Div
        }
        public IActionResult Calculator(Operator op, double? a, double? b)
        {
            ViewBag.Op = op;
            ViewBag.A = a;
            ViewBag.B = b;
            double result = 0;

            if (a.HasValue && b.HasValue)
            {
                switch (op)
                {
                    case Operator.Add:
                        result = a.Value + b.Value;
                        break;
                    case Operator.Sub:
                        result = a.Value - b.Value;
                        break;
                    case Operator.Mul:
                        result = a.Value * b.Value;
                        break;
                    case Operator.Div:
                        if (b.Value != 0)
                        {
                            result = a.Value / b.Value;
                        }
                        break;
                    default:
                        ViewBag.ErrorMessage = "Niepoprawny operator.";
                        break;
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Wartości a i b muszą być podane.";
            }

            ViewBag.Result = result;
            return View();
        }
    }
}