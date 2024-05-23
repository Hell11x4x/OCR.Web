using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OCR.Infraestuctura.Migrations
{
    /// <inheritdoc />
    public partial class incripciones01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "incripciones",
                columns: table => new
                {
                    EInscripciónId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Facultad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EscuelaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciclo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Taller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_incripciones", x => x.EInscripciónId);
                });

            migrationBuilder.InsertData(
                table: "incripciones",
                columns: new[] { "EInscripciónId", "Ciclo", "Codigo", "Dni", "EscuelaProfesional", "Facultad", "FechaActualizacion", "FechaCreacion", "NombreCompleto", "Taller", "Telefono" },
                values: new object[] { 1, "VI", "P00926B", "12345678", "Sistemas y Computación", "Ingeniería", null, null, "Juan Quispe", "Danza", "123456789" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "incripciones");
        }
    }
}
