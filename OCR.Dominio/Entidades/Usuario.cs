using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR.Dominio.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [Required]
        public required string NombreCompleto { get; set; }

        [Required]
        public required string NombreUsuario { get; set; }

        [Required]
        public required string Contraseña { get; set; }

        [Required]
        public required string Rol { get; set; }
    }
}
