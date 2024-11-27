using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorApp.Model.Compras;
using BlazorApp.Model.Cargas;
using System.Runtime.CompilerServices;

namespace BlazorApp.Model.Usuarios
{
    public class Usuario
    {
        [Key]
        public int IdUsu { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Telefono { get; set; }

        [Required]
        public DateTime FecNacimiento { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Contrasenia { get; set; }

        [Required]
        [MaxLength(8)]
        public string TipoUsuario { get; set; }

        [MaxLength(50)]
        public string? MedioDePago { get; set; }

        public List<Compra>? Compras { get; set; }

        public List<Carga>? Cargas { get; set; }
    }
    public class LoginData
    {
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Contrasenia { get; set; }
    }
}
