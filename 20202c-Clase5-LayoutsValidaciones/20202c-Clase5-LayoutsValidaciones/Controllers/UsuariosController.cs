using _20202c_Clase5_LayoutsValidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20202c_Clase5_LayoutsValidaciones.Controllers
{
    public class UsuariosController : Controller
    {
        public static List<Usuario> ListaUsuarios { get; set; }
        // GET: Usuarios
        public UsuariosController()
        {
            if (ListaUsuarios == null)
            {
                ListaUsuarios = new List<Usuario>();
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Alta(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                ListaUsuarios.Add(usuario);
            }
            //required
            //stringlength
            //rango
            //compare
            //regularexpression
            //customvalidation
            //emailaddress
            return View();
        }
    }
}