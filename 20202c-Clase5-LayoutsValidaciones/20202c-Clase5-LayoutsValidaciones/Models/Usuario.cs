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

        private static List<string> MalasPalabras = new List<string>() { "tonto", "sonso" };

        public int IdUsuario { get; set; }
        public string AvatarUrl { get; set; }

        [Required(ErrorMessage = "Nombre de usuario es requerido")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "Email es requerido")]
        [EmailAddress(ErrorMessage ="Formato de Email invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Reingresar Email es requerido")]
        [Compare("Email", ErrorMessage = "Los Emails deben coincidir")]
        [Display(Name = "Reingresar Email")]
        public string ReEmail { get; set; }

        [Required(ErrorMessage = "Contraseña es requerida")]
        [StringLength(20, ErrorMessage = "La Contraseña debe ser de 8 a 20 caracteres", MinimumLength = 8)]
        [RegularExpression(".*[A-Z].*", ErrorMessage = "Debe usar al menos una mayúscula")]
        public string Contrasenia { get; set; }

        [Required(ErrorMessage = "Edad es requerida")]
        [Range(18, 1000, ErrorMessage = "Debe ser mayor a 18 años para registrarse")]
        public int Edad { get; set; }

        [CustomValidation(typeof(Usuario), "ValidacionMalasPalabras", ErrorMessage = "No se aceptan malas palabras")]
        public string Biografia { get; set; }


        public static ValidationResult ValidacionMalasPalabras(object value, ValidationContext context)
        {
            Usuario usuario = context.ObjectInstance as Usuario;
            if (string.IsNullOrEmpty(usuario.Biografia))
                return ValidationResult.Success;

            foreach (string malaPalabra in MalasPalabras)
            {
                if (usuario.Biografia.ToLower().Contains(malaPalabra))
                {
                    return new ValidationResult("No se aceptan malas palabras");
                }
            }

            return ValidationResult.Success;
        }
    }
}