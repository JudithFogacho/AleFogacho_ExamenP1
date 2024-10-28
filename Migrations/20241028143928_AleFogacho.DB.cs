using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AleFogacho_ExamenP1.Migrations
{
    /// <inheritdoc />
    public partial class AleFogachoDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AF_Cita",
                columns: table => new
                {
                    AF_CitaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AF_FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AF_NombreCita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AF_Detalle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AF_ValorCita = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AF_Seguro = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AF_Cita", x => x.AF_CitaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AF_Cita");
        }
    }
}
