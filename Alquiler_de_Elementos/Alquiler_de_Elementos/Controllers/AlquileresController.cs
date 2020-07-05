

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alquiler_de_Elementos.Controllers
{
    public class AlquileresController : Controller
    {
        // GET: Añquileres
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AltaAlquiler() {
            return View();
        }
    }
}