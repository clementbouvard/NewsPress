using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPress.Migrations
{
    public partial class AddArticleThemeToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Themes",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Themes",
                table: "Articles");
        }
    }
}
