using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionDeCredito.Migrations
{
    public partial class migracioncliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(maxLength: 100, nullable: false),
                    Direccion = table.Column<string>(maxLength: 500, nullable: false),
                    Telefono = table.Column<string>(maxLength: 8, nullable: true),
                    Genero = table.Column<string>(maxLength: 1, nullable: true),
                    Cedula = table.Column<string>(maxLength: 20, nullable: false),
                    IdUsuario = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
