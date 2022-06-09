using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudFixture.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fixture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Local = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Visitante = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Estadio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dia = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    Resultado = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixture", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fixture");
        }
    }
}
