using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial3Proyecto.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Almacen = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Producto = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Costo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Almacen);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
