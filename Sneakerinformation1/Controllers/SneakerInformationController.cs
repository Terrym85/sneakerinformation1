using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sneakerinformation1.Controllers
{
    public class SneakerInformationController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.ShoeModel = "History Of Air Jordan";
            ViewBag.ModelNumber = 1;
            ViewBag.Description = "<p>On October 18, 1984, the NBA banned Michael Jordan’s black and red Air Jordan 1s for violating the league’s uniform codes. This decision triggered a craze that foreshadowed a legend in the making. </p>";
            ViewBag.Brands = new string[]
            {
                "Designer: Peter Moore ",
                "Brand Name: Nike ",
                "Designed for: Michael Jordan",
                "Retail: $160",
                "Release Year: 1985"
            };
        
            return View();
        }
    }
}