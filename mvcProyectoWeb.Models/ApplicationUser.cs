using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace mvcProyectoWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese su Departamento")]
        public string Departamento {  get; set; }
        [Required(ErrorMessage = "Ingrese su numero de celular")]
        public string Celular {  get; set; }
    }
}
