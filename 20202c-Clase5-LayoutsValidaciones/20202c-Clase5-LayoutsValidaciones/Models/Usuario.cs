using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20202c_Clase5_LayoutsValidaciones.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string AvatarUrl { get; set; }

        [Required (ErrorMessage ="Nombre de usuario es requerido")]
        public string NombreUsuario { get; set; }

        [Required (ErrorMessage = "Email es requerido")]
        public string Email { get; set; }
        
        [Required (ErrorMessage = "Contraseña es requerida")]
        public string Contrasenia { get; set; }

        [Required (ErrorMessage = "Edad es requerida")]
        public int Edad { get; set; }
        public string Biografia { get; set; }
    }
}