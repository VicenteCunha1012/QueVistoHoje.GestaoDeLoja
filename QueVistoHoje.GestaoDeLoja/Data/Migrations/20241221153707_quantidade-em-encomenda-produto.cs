using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueVistoHoje.GestaoDeLoja.Migrations
{
    /// <inheritdoc />
    public partial class quantidadeemencomendaproduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "EncomendaProduto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "EncomendaProduto");
        }
    }
}
