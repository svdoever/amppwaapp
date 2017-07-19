using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AmpPwaApps.Areas.ReactTest.Controllers
{
    public class ReactHomeController : Controller
    {
        [Area("ReactTest")]
        public IActionResult React()
        {
            return View();
        }
    }
}