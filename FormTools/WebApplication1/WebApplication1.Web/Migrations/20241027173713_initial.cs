using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Web.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pName = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    pType = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    pPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    color = table.Column<string>(type: "nvarchar(40)", nullable: true),
                    height = table.Column<int>(type: "int", nullable: true),
                    width = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
