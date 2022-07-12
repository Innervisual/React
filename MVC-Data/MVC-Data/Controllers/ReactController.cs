using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Data.Data;
using MVC_Data.Models;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVC_Data.Controllers
{
    //applies to all methods in the class
    [EnableCors("MyPolicy")] 
    [ApiController]
    [Route("api/[controller]")]
    public class ReactController : Controller
    {
        private readonly ApplicationDbContent _context;


        public ReactController(ApplicationDbContent context)
        {
            _context = context;
        }


        public IActionResult PostPerson()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult<HttpStatusCode>> PostPerson([FromBody]Person prsn)
        {
            
            Person newPerson = new Person();

            var cityFound = _context.Cities.Find(prsn.tempCityName);
            newPerson.City = cityFound;
            var countryFound = _context.Countries.Find(prsn.tempCountryName);
            newPerson.Name = prsn.Name;
            newPerson.PhoneNumber = prsn.PhoneNumber;
            newPerson.Id = prsn.Id;
            newPerson.tempCityName = prsn.tempCityName;
            newPerson.tempCountryName = prsn.tempCountryName;
            newPerson.tempLanguageName = prsn.tempLanguageName;

            _context.People.Add(newPerson);
            await _context.SaveChangesAsync();

            return (HttpStatusCode.OK);
        }



        //DELETe    api/React/5
        [HttpDelete("{id}")]
        public async Task<HttpStatusCode> DeletePerson(int id) {
            if (_context.People == null)
            {
                return HttpStatusCode.NotFound;
            }
            var foundPerson = new Person();
            foreach (Person prsn in _context.People)
            {
                if (prsn.Id == id)
                {
                    foundPerson = prsn;
                }
            }
            if (foundPerson == null)
            {
                return HttpStatusCode.NotFound;

            }

            _context.People.Remove(foundPerson);
            await _context.SaveChangesAsync();

            return (HttpStatusCode.OK);

        }


        //api/React/cities
        [HttpGet("cities")]
        public async Task<ActionResult<List<City>>> GetCities()
        {
            if (_context.Cities == null)
            {
                return NotFound();
            }

            return await _context.Cities.ToListAsync(); ;
        }

        //api/React/languages
        [HttpGet("languages")]
        public async Task<ActionResult<List<Language>>> GetLanguages()
        {
            if (_context.Langs == null)
            {
                return NotFound();
            }

            return await _context.Langs.ToListAsync(); ;
        }

        //api/React/countries
        [HttpGet("countries")]
        public async Task<ActionResult<List<Country>>> GetCountries()
        {
            if (_context.Countries == null)
            {
                return NotFound();
            }

            return await _context.Countries.ToListAsync(); ;
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPeople()
        {
            if (_context.People == null)
            {
                return NotFound();
            }
            
            return await _context.People.ToListAsync(); ;
        }

    }
}
