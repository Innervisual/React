using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Data.Data;
using MVC_Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Data.Controllers
{
    public class PeopleController : Controller
    {
        private readonly ApplicationDbContent _context;


        public PeopleController(ApplicationDbContent context)
        {
            _context = context;
        }
         
        public IActionResult Index()
        {
            var listOfPeople = _context.People.ToList();
            return View(listOfPeople);
        }

        [HttpPost] //search/filter:
        public IActionResult Index(Person person)
        {
            var listOfAllPeople = _context.People.ToList();
            var listOfFilteredPeople = new List<Person>();

            foreach (var prsn in listOfAllPeople)
            {
                if (prsn.Name == person.Name)
                {
                    listOfFilteredPeople.Add(prsn);
                }
            }
            if (listOfFilteredPeople.Count > 0) //found the person
            {
                return View(listOfFilteredPeople);
            }

            return View();
        }




        public IActionResult Create()
        {
            ViewBag.Cities = new SelectList(_context.Cities, "Name", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person, string personCity)
        {
            if (ModelState.IsValid)
            {
                var selectedCity = _context.Cities.Find(personCity);

                person.City = selectedCity;
                _context.People.Add(person);
                _context.SaveChanges(); //actually saves info in database
                return RedirectToAction("Index");
            }
            return View();    
        }

        public IActionResult Remove(string name)
        {
            var peopleToRemove = _context.People.Find(name);

            _context.People.Remove(peopleToRemove);
            _context.SaveChanges();

            return RedirectToAction("Index"); 
        }


        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Edit(string name)
        {
            ViewBag.Name = name;
            ViewBag.Cities = new SelectList(_context.Cities, "Name", "Name");


            return View();
        }

        [HttpPost]
        public IActionResult Edit(Person person, string personCity)
        {
            Person personToChange = _context.People.Find(person.Name);
            City city = _context.Cities.Find(personCity);
            if (ModelState.IsValid)
            {
                _context.People.Remove(personToChange);
                person.City = city;
                _context.People.Add(person);
                _context.SaveChanges(); //This one applies changes to DB

                return RedirectToAction("Index");

            }
            return View();
        }
    }
}
