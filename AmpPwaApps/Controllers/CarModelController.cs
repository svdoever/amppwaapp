using Microsoft.AspNetCore.Mvc;
using AmpPwaApps.Models;
using System.Collections.Generic;
using System;
using System.Linq;

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

        [HttpGet("{carId}/photos/{colourId}")]
        public IActionResult GetCarPhotos(string carId, string colourId)
        {
            try
            {
                var photos = CarModelsDatabase.Cars.First(x => x.Id == carId)
                                          .Colours.First(x => x.Id == colourId)
                                            .ImageFolder.Images.Select(x => new Image {
                                                Url = $"https://www.autoabonnement.nl{x.Url}",
                                                Alt = x.Alt,
                                                Width = x.Width,
                                                Height = x.Height
                                            }).ToList();
                var itemContainer = new ItemContainer<Image>();
                itemContainer.Items = photos;
                return new JsonResult(itemContainer);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet("{carId}/kilometrage/{kilometrage}/duration/{duration}/color/{colorId}")]
        public IActionResult GetTotalPrice(string carId, int kilometrage, int duration, string colorId)
        {
            var targetCar = CarModelsDatabase.Cars.First(x => x.Id == carId);
            double kilometrageCoefficient = (0.08 * ((kilometrage - 5000) / 5000) + 1);
            double durationCoefficient = (1 - ((duration - 12) / 12) * 0.05);
            double colourPrice = targetCar.Colours.First(x => x.Id == colorId).Price;
            var leasePriceResult = new
            {
                TotalLeasePrice = Math.Round(targetCar.Price * kilometrageCoefficient * durationCoefficient + colourPrice, 2)
            };
            return new JsonResult(leasePriceResult);
        }
        
    }
}