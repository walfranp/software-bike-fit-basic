using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeFitBasic.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciclistas",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MedidaCavalo = table.Column<int>(type: "INTEGER", nullable: false),
                    MedidaAntebraco = table.Column<int>(type: "INTEGER", nullable: false),
                    NivelFlexibilidade = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciclistas", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ciclistas");
        }
    }
}
