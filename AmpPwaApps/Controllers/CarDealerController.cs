using Microsoft.AspNetCore.Mvc;
using AmpPwaApps.Models;
using System.Collections.Generic;

namespace AmpPwaApps.Controllers
{
    [Produces("application/json")]
    [Route("api/carDealers")]
    public class CarDealerController : Controller
    {
        [HttpPost("appointment")]
        public IActionResult ArrangeAppointment(CarDealerAppointment carDealerAppointment)
        {
            //TO DO: send an appointment via email
            return new NotFoundResult();
        }

        [HttpGet]
        public IActionResult GetCarDealers()
        {
            var itemContainer = new ItemContainer<CarDealer>();
            var carDealers = new List<CarDealer> { new CarDealer() };
            itemContainer.Items = carDealers;
            return new JsonResult(itemContainer);
        }
    }
}
