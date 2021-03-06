using Microsoft.AspNetCore.Mvc;
using AmpPwaApps.Models;
using System.Collections.Generic;
using AmpPwaApps.Utils.Email;
using AmpPwaApps.Utils;
using System;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace AmpPwaApps.Controllers
{
    [Produces("application/json")]
    [Route("api/carDealers")]
    public class CarDealerController : Controller
    {
        [HttpPost("appointment")]
        public IActionResult ArrangeAppointment(CarDealerAppointment carDealerAppointment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var dutchCultureInfo = new CultureInfo("nl-NL");
                    var emailSettings = new EmailSettings
                    {
                        FromAddress = "macaw.amp.sender@gmail.com",
                        FromAdressTitle = $"Appointment arranged with {carDealerAppointment.DealerName ?? "dealer"}",
                        ToAddress = carDealerAppointment.Email ?? "julius.mazionis@macaw.nl",
                        ToAddressTitle = $"Appointment arranged with {carDealerAppointment.DealerName ?? "dealer"}",
                        Subject = $"Appointment arranged with {carDealerAppointment.DealerName ?? "dealer"}",
                        BodyContent = $"{carDealerAppointment.GreetingPrefix ?? ""} {carDealerAppointment.FirstName} {carDealerAppointment.LastName}, an appointment was arranged with {carDealerAppointment.DealerName} on {carDealerAppointment.AppointmentDate.Date.ToString("d", dutchCultureInfo)}!",
                        SmtpServer = "smtp.gmail.com",
                        SmtpPortNumber = 587
                    };
                    EmailSender.SendEmail(emailSettings);

                    Request.HttpContext.Response.Headers.Add("AMP-Access-Control-Allow-Source-Origin", Request.Query["__amp_source_origin"]);
                    return Ok(new JsonResult(new { Message = "Appointment was successfully arranged!" }));
                }
                else
                {
                    
                    return StatusCode(StatusCodes.Status500InternalServerError, new JsonResult(new { Message = "There was an error while sending an email" }));
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "There was an error while sending the email");
            }                  
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
