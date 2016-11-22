using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sneakerinformation1.Models;

namespace Sneakerinformation1.Data
{
    public class SneakerInformationRepository
    {
        private static Sneakers[] _sneakers = new Sneakers[]
        {
   new Sneakers()
            {
                Id = 1,
                ShoeModel = "Air Jordan Chicago",
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
            },
             new Sneakers()
            {
                Id = 2,
                ShoeModel = "Air Jordan 11",
                ModelNumber = 11,
                DescriptionHtml = "<p> This popular model was first released in 1995 when Jordan laced them up and led the Chicago Bulls to an all-time NBA best 72-win season. </p>",
                Brands = new Brand[]
                   {
                    new Brand() {Name = "Tinker Hatfield", Role = "Designer" },
                    new Brand() {Name = "Nike", Role = "Brand Name" },
                    new Brand() {Name = "Michael Jordan", Role = "Designed for" },
                    new Brand() {Name = "$220", Role = "Retail" },
                    new Brand() {Name = "1995", Role = "Release Year" },
                   }
            }
    };

        public Sneakers GetSneakers(int id)
        {
            Sneakers sneakersToReturn = null;

            foreach (var sneaker in _sneakers)
            {
                if (sneaker.Id == id)
                {
                    sneakersToReturn = sneaker;

                    break;
                }
            }

            return sneakersToReturn;
        }
    }
}