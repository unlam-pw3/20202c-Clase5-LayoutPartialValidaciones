using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20202c_Clase5_LayoutsValidaciones.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string AvatarUrl { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
        public int Edad { get; set; }
        public string Biografia { get; set; }
    }
}