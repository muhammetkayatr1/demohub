using Microsoft.EntityFrameworkCore.Migrations;

namespace Halic.Data.Migrations
{
    public partial class CreateContentColumnInAuthorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Authors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Authors");
        }
    }
}
