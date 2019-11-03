using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Acke_Gianni_Guns_of_the_Old_West.Controllers
{
    public class StatsController : Controller
    {
        public IActionResult Stats()
        {
          return View();
           // return View("~/Views/Shared/_Layout_mod - Copy.cshtml");
        }
    }
}