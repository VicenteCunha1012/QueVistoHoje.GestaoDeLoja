using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueVistoHoje.GestaoDeLoja.Migrations
{
    /// <inheritdoc />
    public partial class mudarencomenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Encomendas_AspNetUsers_ClienteId",
                table: "Encomendas");

            migrationBuilder.DropIndex(
                name: "IX_Encomendas_ClienteId",
                table: "Encomendas");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Encomendas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ClienteId",
                table: "Encomendas",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Encomendas_ClienteId",
                table: "Encomendas",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Encomendas_AspNetUsers_ClienteId",
                table: "Encomendas",
                column: "ClienteId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
