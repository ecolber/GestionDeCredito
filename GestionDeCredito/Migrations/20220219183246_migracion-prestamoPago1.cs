using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionDeCredito.Migrations
{
    public partial class migracionprestamoPago1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(nullable: false),
                    Monto = table.Column<double>(nullable: false),
                    Interes = table.Column<double>(nullable: false),
                    Plazo = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(maxLength: 15, nullable: true),
                    FechaCreacion = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestamo_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pago",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPrestamo = table.Column<int>(nullable: false),
                    MontoPagado = table.Column<double>(nullable: false),
                    FechaPago = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pago", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pago_Prestamo_IdPrestamo",
                        column: x => x.IdPrestamo,
                        principalTable: "Prestamo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pago_IdPrestamo",
                table: "Pago",
                column: "IdPrestamo");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_IdCliente",
                table: "Prestamo",
                column: "IdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pago");

            migrationBuilder.DropTable(
                name: "Prestamo");
        }
    }
}
