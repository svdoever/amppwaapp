using Microsoft.AspNetCore.Mvc;
using AmpPwaApps.Models;

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
    }
}
