using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Web.Migrations
{
    public partial class addExpirationForProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Expiration",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Expiration",
                table: "Products");
        }
    }
}
