using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eventos.Migrations
{
    public partial class migracion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Numero_Tarjeta",
                table: "Metodo_pago",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numero_Tarjeta",
                table: "Metodo_pago");
        }
    }
}
