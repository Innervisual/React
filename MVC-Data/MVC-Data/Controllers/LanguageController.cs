using Microsoft.AspNetCore.Mvc;
using MVC_Data.Data;
using MVC_Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MVC_Data.Controllers
{

    public class LanguageController : Controller
    {
        private readonly ApplicationDbContent _context;

        public LanguageController(ApplicationDbContent context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Languages()
        {
            return View(_context.Langs.ToList());
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Language language)
        {
            if (ModelState.IsValid)
            {
                _context.Langs.Add(language);
                _context.SaveChanges();
                return RedirectToAction("Languages");

            }
            return View();
        }
        public IActionResult Remove(string name)
        {
            var langugageToRemove = _context.Langs.Find(name);

            _context.Langs.Remove(langugageToRemove);
            _context.SaveChanges();

            return RedirectToAction("Languages");
        }

        public IActionResult Edit(string name)
        {
            ViewBag.Name = name;

            return View();
        }
        [HttpPost]
        public IActionResult Edit(Language language, int id) 
        {
            if (ModelState.IsValid)
            {
                var langToChange = _context.Langs.Find(language.Name);
                langToChange.Id = id;
                _context.SaveChanges();

                return RedirectToAction("Languages");
            }

            return View();
        }

    }
}
