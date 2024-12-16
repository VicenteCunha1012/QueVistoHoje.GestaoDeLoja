using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueVistoHoje.GestaoDeLoja.Migrations
{
    /// <inheritdoc />
    public partial class adicionadastransportadoras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransportadoraId",
                table: "Empresas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Transportadoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportadoras", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresas_Transportadoras_TransportadoraId",
                table: "Empresas");

            migrationBuilder.DropTable(
                name: "Transportadoras");

            migrationBuilder.DropIndex(
                name: "IX_Empresas_TransportadoraId",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "TransportadoraId",
                table: "Empresas");
        }
    }
}
