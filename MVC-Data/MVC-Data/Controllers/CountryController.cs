using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Data.Data;
using MVC_Data.Models;
using System.Linq;

namespace MVC_Data.Controllers
{
    [Authorize(Roles = "Admin")]

    public class CountryController : Controller
    {
        private readonly ApplicationDbContent _context;

        public CountryController(ApplicationDbContent context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Countries()
        {
            var listOfCountries = _context.Countries.ToList();
            return View(listOfCountries);
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Country country)
        {
            if (ModelState.IsValid)
            {
                _context.Countries.Add(country);
                _context.SaveChanges();
                return RedirectToAction("Countries");

            }
            return View();
        }

        public IActionResult Remove(string name)
        {
            var countryToRemove = _context.Countries.Find(name);

            _context.Countries.Remove(countryToRemove);
            _context.SaveChanges();

            return RedirectToAction("Countries");
        }

        public IActionResult Edit(string name)
        {

            ViewBag.Name = name;
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Country country, int Id)
        {
           
            string Country = (TempData["countryName"]).ToString();
            Country foundCountry = _context.Countries.Find(Country);
            foundCountry.Id = Id;
            _context.SaveChanges();

            return RedirectToAction("Countries");
        }


    }
}
