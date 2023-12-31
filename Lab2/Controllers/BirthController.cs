﻿using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result(Urodziny model)
        {
            if (!model.IsValid())
                return View("Error");

            return View(model);
        }
    }
}
