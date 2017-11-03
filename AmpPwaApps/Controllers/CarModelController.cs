using Microsoft.AspNetCore.Mvc;
using AmpPwaApps.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Cors;

namespace AmpPwaApps.Controllers
{
    [Produces("application/json")]
    [Route("api/cars")]
    public class CarModelController : Controller
    {
        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
            return CarModelsDatabase.Cars;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var car = CarModelsDatabase.Cars.FirstOrDefault(x => x.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            return new ObjectResult(car);
        }
    }
}