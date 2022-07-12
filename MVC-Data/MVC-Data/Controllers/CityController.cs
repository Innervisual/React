using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Data.Data;
using MVC_Data.Models;
using System.Linq;

namespace MVC_Data.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CityController : Controller
    {
        private readonly ApplicationDbContent _context;

        public CityController(ApplicationDbContent context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cities()
        {
            var listOfCities = _context.Cities.ToList();
            return View(listOfCities);
        }

        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(_context.Countries, "Name", "Name");

            return View();

        }
        [HttpPost]
        public IActionResult Create(City city, string Country)
        {
            if (ModelState.IsValid)
            {
                var selectedCountry = _context.Countries.Find(Country);
                city.Country = selectedCountry;  
                _context.Cities.Add(city);
                _context.SaveChanges(); 
                return RedirectToAction("Cities");

            }
            return View();
        }

        public IActionResult Remove(string name)
        {
            var cityToRemove = _context.Cities.Find(name);

            _context.Cities.Remove(cityToRemove);
            _context.SaveChanges();

            return RedirectToAction("Cities");
        }

        public IActionResult Edit(string name)
        {
            ViewBag.Name = name;
            ViewBag.Countries = new SelectList(_context.Countries, "Name", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Edit(City city, string Country)
        {
            City cityToChange  = _context.Cities.Find(city.Name);
            Country newCountry = _context.Countries.Find(Country);
            cityToChange.Country = newCountry;

            _context.SaveChanges();

            return RedirectToAction("Cities");

        }


    }
}
