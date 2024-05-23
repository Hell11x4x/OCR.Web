using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OCR.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR.Infraestuctura.Datos
{
    public class AplicacionDbContexto : DbContext
    {
        public AplicacionDbContexto(DbContextOptions<AplicacionDbContexto> options) : base(options)
        {

        }
        public DbSet<EIncripción> incripciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EIncripción>().HasData(

                new EIncripción
                {
                    EInscripciónId = 1,
                    NombreCompleto = "Juan Quispe",
                    Facultad = "Ingeniería",
                    EscuelaProfesional = "Sistemas y Computación",
                    Ciclo = "VI",
                    Codigo = "P00926B",
                    Dni = "12345678",
                    Telefono = "123456789",
                    Taller = "Danza",
                }
                );
        }
    }
}
