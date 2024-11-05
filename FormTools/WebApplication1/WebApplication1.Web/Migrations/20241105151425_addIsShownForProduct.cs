using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Web.Migrations
{
    public partial class addIsShownForProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isShow",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isShow",
                table: "Products");
        }
    }
}
