using Sneakerinformation1.Models;
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
            var sneakers = new Sneakers()
            {
                ShoeModel = "History Of Air Jordan",
                ModelNumber = 1,
                DescriptionHtml = "<p>On October 18, 1984, the NBA banned Michael Jordan’s black and red Air Jordan 1s for violating the league’s uniform codes. This decision triggered a craze that foreshadowed a legend in the making. </p>",
                Brands = new Brand[]
                {
                    new Brand() {Name = "Peter Moore", Role = "Designer" },
                    new Brand() {Name = "Nike", Role = "Brand Name" },
                    new Brand() {Name = "Michael Jordan", Role = "Designed for" },
                    new Brand() {Name = "$160", Role = "Retail" },
                    new Brand() {Name = "1985", Role = "Release Year" },
                }
            };

            return View(sneakers);
        }
    }
}