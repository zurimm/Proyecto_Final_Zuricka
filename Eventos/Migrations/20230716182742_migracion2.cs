using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eventos.Migrations
{
    public partial class migracion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Adm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email_Adm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contraseña_Adm = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cat_evento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Cat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio_cat_Entrada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contraseña_cat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cat_evento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_evento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion_evento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_Evento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hora_evento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    espacios_evento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Metodo_pago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_vencimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVV = table.Column<int>(type: "int", nullable: false),
                    Nombre_tarjeta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metodo_pago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soporte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Soporte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email_Soporte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contraseña_Soporte = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soporte", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contraseña_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nacimiento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrador");

            migrationBuilder.DropTable(
                name: "cat_evento");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "Metodo_pago");

            migrationBuilder.DropTable(
                name: "Soporte");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
