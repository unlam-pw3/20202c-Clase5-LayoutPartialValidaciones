using _20202c_Clase5_LayoutsValidaciones.Models;
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

        public ActionResult VistaConPartialViewTipada()
        {
            var usuarioActual = new Usuario();
            usuarioActual.AvatarUrl = "https://image.flaticon.com/icons/png/512/147/147136.png";
            usuarioActual.NombreUsuario = "Vegeta";

            ViewBag.UsuarioActual = usuarioActual;

            return View();
        }
    }
}