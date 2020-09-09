using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Web.Migrations
{
    public partial class stage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Highschool",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Middleschool",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Primaryschool",
                table: "Students",
                newName: "StageSchool");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StageSchool",
                table: "Students",
                newName: "Primaryschool");

            migrationBuilder.AddColumn<bool>(
                name: "Highschool",
                table: "Students",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Middleschool",
                table: "Students",
                nullable: false,
                defaultValue: false);
        }
    }
}
