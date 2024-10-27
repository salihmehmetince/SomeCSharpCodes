using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Web.Migrations
{
    public partial class addStockPieceDescriptionForProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "piece",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "stock",
                table: "Products",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "piece",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "stock",
                table: "Products");
        }
    }
}
