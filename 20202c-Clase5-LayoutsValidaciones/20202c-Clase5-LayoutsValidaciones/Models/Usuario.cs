using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20202c_Clase5_LayoutsValidaciones.Models
{
    public class Usuario
    {
        //required
        //stringlength
        //rango
        //compare
        //regularexpression
        //customvalidation
        //emailaddress

        public int IdUsuario { get; set; }
        public string AvatarUrl { get; set; }

        [Required (ErrorMessage ="Nombre de usuario es requerido")]
        public string NombreUsuario { get; set; }

        [Required (ErrorMessage = "Email es requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Reingresar Email es requerido")]
        [Compare("Email", ErrorMessage ="Los Emails deben coincidir")]
        [Display(Name = "Reingresar Email")]
        public string ReEmail { get; set; }

        [Required (ErrorMessage = "Contraseña es requerida")]
        [StringLength(20, ErrorMessage ="La Contraseña debe ser de 8 a 20 caracteres", MinimumLength =8)]
        [RegularExpression(".*[A-Z].*", ErrorMessage ="Debe usar al menos una mayúscula")]
        public string Contrasenia { get; set; }

        [Required (ErrorMessage = "Edad es requerida")]
        [Range(18,1000, ErrorMessage ="Debe ser mayor a 18 años para registrarse")]
        public int Edad { get; set; }
        public string Biografia { get; set; }
    }
}