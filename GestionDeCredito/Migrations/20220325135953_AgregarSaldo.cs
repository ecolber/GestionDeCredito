using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionDeCredito.Migrations
{
    public partial class AgregarSaldo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Saldo",
                table: "Prestamo",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Saldo",
                table: "Prestamo");
        }
    }
}
