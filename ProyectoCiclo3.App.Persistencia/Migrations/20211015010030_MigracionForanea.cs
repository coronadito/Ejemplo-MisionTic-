using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    public partial class MigracionForanea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "destino",
                table: "Rutas");

            migrationBuilder.DropColumn(
                name: "origen",
                table: "Rutas");

            migrationBuilder.AddColumn<int>(
                name: "destinoid",
                table: "Rutas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "origenid",
                table: "Rutas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "marca",
                table: "Buses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rutas_destinoid",
                table: "Rutas",
                column: "destinoid");

            migrationBuilder.CreateIndex(
                name: "IX_Rutas_origenid",
                table: "Rutas",
                column: "origenid");

            migrationBuilder.AddForeignKey(
                name: "FK_Rutas_Estaciones_destinoid",
                table: "Rutas",
                column: "destinoid",
                principalTable: "Estaciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rutas_Estaciones_origenid",
                table: "Rutas",
                column: "origenid",
                principalTable: "Estaciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rutas_Estaciones_destinoid",
                table: "Rutas");

            migrationBuilder.DropForeignKey(
                name: "FK_Rutas_Estaciones_origenid",
                table: "Rutas");

            migrationBuilder.DropIndex(
                name: "IX_Rutas_destinoid",
                table: "Rutas");

            migrationBuilder.DropIndex(
                name: "IX_Rutas_origenid",
                table: "Rutas");

            migrationBuilder.DropColumn(
                name: "destinoid",
                table: "Rutas");

            migrationBuilder.DropColumn(
                name: "origenid",
                table: "Rutas");

            migrationBuilder.AddColumn<int>(
                name: "destino",
                table: "Rutas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "origen",
                table: "Rutas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "marca",
                table: "Buses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
