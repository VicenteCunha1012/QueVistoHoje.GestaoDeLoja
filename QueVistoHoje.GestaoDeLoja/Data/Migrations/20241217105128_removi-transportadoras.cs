using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueVistoHoje.GestaoDeLoja.Migrations
{
    /// <inheritdoc />
    public partial class removitransportadoras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Encomendas_Transportadoras_TransportadoraId",
                table: "Encomendas");

            migrationBuilder.DropTable(
                name: "Transportadoras");

            migrationBuilder.DropIndex(
                name: "IX_Encomendas_TransportadoraId",
                table: "Encomendas");

            migrationBuilder.DropColumn(
                name: "TransportadoraId",
                table: "Encomendas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransportadoraId",
                table: "Encomendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Transportadoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportadoras", x => x.Id);
                });

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
    }
}
