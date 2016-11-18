using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sneakerinformation1.Models
{
    public class Sneakers
    {
        public int Id { get; set; }
        public string ShoeModel { get; set; }
        public int ModelNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Brand[] Brands { get; set; }
        public bool Favorite { get; set; }
    }
}