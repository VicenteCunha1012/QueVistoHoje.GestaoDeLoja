using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueVistoHoje.GestaoDeLoja.Migrations
{
    /// <inheritdoc />
    public partial class encomendascomtransportadora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresas_Transportadoras_TransportadoraId",
                table: "Empresas");

            migrationBuilder.DropIndex(
                name: "IX_Empresas_TransportadoraId",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "TransportadoraId",
                table: "Empresas");

            migrationBuilder.AddColumn<int>(
                name: "TransportadoraId",
                table: "Encomendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Encomendas_TransportadoraId",
                table: "Encomendas",
                column: "TransportadoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Encomendas_Transportadoras_TransportadoraId",
                table: "Encomendas",
                column: "TransportadoraId",
                principalTable: "Transportadoras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Encomendas_Transportadoras_TransportadoraId",
                table: "Encomendas");

            migrationBuilder.DropIndex(
                name: "IX_Encomendas_TransportadoraId",
                table: "Encomendas");

            migrationBuilder.DropColumn(
                name: "TransportadoraId",
                table: "Encomendas");

            migrationBuilder.AddColumn<int>(
                name: "TransportadoraId",
                table: "Empresas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_TransportadoraId",
                table: "Empresas",
                column: "TransportadoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresas_Transportadoras_TransportadoraId",
                table: "Empresas",
                column: "TransportadoraId",
                principalTable: "Transportadoras",
                principalColumn: "Id");
        }
    }
}
