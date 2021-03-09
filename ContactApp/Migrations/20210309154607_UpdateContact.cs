using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactApp.Migrations
{
    public partial class UpdateContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Contact");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
