using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Laboratorium_3___App.Controllers
{
    public class ContactController : Controller
    {
        //lista kontaktow 
        static Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        static int id = 1;

        public IActionResult Index()
        {
            return View(_contacts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact model) 
        { 
            if (ModelState.IsValid) 
            {
                // dodaj model do bazy lub kolekcji
                model.Id = id++;
                _contacts.Add(model.Id, model);
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpGet]
        public IActionResult Update (int id) 
        {
            
            return View(_contacts[id]);
        }
        [HttpPost]
        public IActionResult Update(Contact model) 
        
        {
            if (ModelState.IsValid)
            {
                _contacts[model.Id] = model;
            }
            return RedirectToAction("Index");
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (_contacts.ContainsKey(id))
            {
                return View(_contacts[id]);
            }
            else
            {
                return NotFound(); // Możesz obsłużyć sytuację, gdy kontakt o podanym ID nie istnieje
            }
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            if (_contacts.ContainsKey(id))
            {
                _contacts.Remove(id); // Usuń kontakt z kolekcji
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound(); // Możesz obsłużyć sytuację, gdy kontakt o podanym ID nie istnieje
            }
        }
        [HttpGet]
        public IActionResult Details(int id)
        { return View(_contacts[id]); }
        [HttpPost]
        public IActionResult Details(Contact model
            )
        
            {
                if (ModelState.IsValid)
                {
                    _contacts[model.Id] = model;
                }
                return RedirectToAction("Index");
                return View();
            }
        
    }
}
