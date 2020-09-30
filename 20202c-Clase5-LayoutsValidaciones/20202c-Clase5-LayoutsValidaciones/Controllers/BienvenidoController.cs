using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20202c_Clase5_LayoutsValidaciones.Controllers
{
    public class BienvenidoController : Controller
    {
        // GET: Bienvenido
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VistaConRegiones()
        {
            return View();
        }

        public ActionResult VistaConLayoutAnidado()
        {
            return View();
        }
    }
}