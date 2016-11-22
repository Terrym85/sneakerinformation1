using Sneakerinformation1.Data;
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
        private SneakerInformationRepository _sneakerinformationRepository = null;

        public SneakerInformationController()
        {
            _sneakerinformationRepository = new SneakerInformationRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var sneakers = _sneakerinformationRepository.GetSneakers((int)id);

            return View(sneakers);
        }
    }
}