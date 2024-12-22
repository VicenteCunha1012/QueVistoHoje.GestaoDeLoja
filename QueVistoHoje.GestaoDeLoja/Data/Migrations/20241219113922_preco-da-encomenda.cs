using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueVistoHoje.GestaoDeLoja.Migrations
{
    /// <inheritdoc />
    public partial class precodaencomenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecoTotal",
                table: "Encomendas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoTotal",
                table: "Encomendas");
        }
    }
}
