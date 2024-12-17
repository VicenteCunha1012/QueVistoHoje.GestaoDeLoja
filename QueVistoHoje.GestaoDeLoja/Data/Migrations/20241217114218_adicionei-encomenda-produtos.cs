using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueVistoHoje.GestaoDeLoja.Migrations
{
    /// <inheritdoc />
    public partial class adicioneiencomendaprodutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Encomendas_EncomendaId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_EncomendaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "EncomendaId",
                table: "Produtos");

            migrationBuilder.CreateTable(
                name: "EncomendaProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EncomendaId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncomendaProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EncomendaProduto_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EncomendaProduto_Encomendas_EncomendaId",
                        column: x => x.EncomendaId,
                        principalTable: "Encomendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EncomendaProduto_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EncomendaProduto_ApplicationUserId",
                table: "EncomendaProduto",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EncomendaProduto_EncomendaId",
                table: "EncomendaProduto",
                column: "EncomendaId");

            migrationBuilder.CreateIndex(
                name: "IX_EncomendaProduto_ProdutoId",
                table: "EncomendaProduto",
                column: "ProdutoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EncomendaProduto");

            migrationBuilder.AddColumn<int>(
                name: "EncomendaId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_EncomendaId",
                table: "Produtos",
                column: "EncomendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Encomendas_EncomendaId",
                table: "Produtos",
                column: "EncomendaId",
                principalTable: "Encomendas",
                principalColumn: "Id");
        }
    }
}
