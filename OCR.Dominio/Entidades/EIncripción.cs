using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR.Dominio.Entidades
{
    public class EIncripción
    {
        [Key]
        public int EInscripciónId { get; set; }

        public required string NombreCompleto { get; set; }

      
        public required string Facultad { get; set; }

        
        public required string EscuelaProfesional { get; set; }

     
        public required string Ciclo { get; set; }

        
        public required string Codigo { get; set; }

       
        public required string Dni { get; set; }

       
        public required string Telefono { get; set; }


        public required string Taller { get; set; }

        
       //  public required byte[] Imagen { get; set; }

       // public string? DatosExtraidos { get; set; }

       //public byte[]? ArchivoExcel { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaActualizacion { get; set; }

       // public required string Estado { get; set; }


    }
}
