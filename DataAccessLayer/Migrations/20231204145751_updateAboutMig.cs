using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class updateAboutMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Abouts",
                newName: "LinkedIn");

            migrationBuilder.AddColumn<string>(
                name: "GitHub",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GitHub",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "LinkedIn",
                table: "Abouts",
                newName: "Phone");
        }
    }
}
