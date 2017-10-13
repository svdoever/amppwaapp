using Microsoft.AspNetCore.Mvc;
using AmpPwaApps.Models;
using System.Collections.Generic;

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
    }
}