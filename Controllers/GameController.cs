using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acke_Gianni_Guns_of_the_Old_West.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Acke_Gianni_Guns_of_the_Old_West.Controllers
{
    
    public class GameController : Controller
    {
       // private Kogels kogels = new Kogels(12);
        public IActionResult GameIndex()
        {
            return View();
        }

        //protected RedirectToActionResult btnLogin_Click(object sender, EventArgs e)
        //{
        //    Kogels kogels = new Kogels(12);
        //    kogels.SetAantal(12);

        //    return RedirectToAction("GameIndex");

        //}

        public IActionResult ScherpSchutter()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Controleer(Kogels kogels)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            if (randomNumber < 4)
            {
                return RedirectToAction("ScherpSchutter");
            }
            else
            {
                var aantal = kogels.GetAantal();
                aantal--;
                kogels.SetAantal(aantal);
                return RedirectToAction("GameIndex");
                
            }
        }
    }
}
//{
//    public class GameController : Controller
//    {
//        private static int Aantal = 12;
//        public IActionResult Index()
//        {

//            return View(Aantal);
//        }

//        public IActionResult ScherpSchutter()
//        {
//            return View();
//        }

//        public IActionResult controleer()
//        {
//            Random random = new Random();
//            int randomNumber = random.Next(0, 100);

//            if (randomNumber < 4)
//            {
//                return RedirectToAction("ScherpSchutter");
//            }
//            else
//            {
//                Aantal = Aantal - 1;
//                return RedirectToAction("Index");
//            }
//        }
//    }
//}