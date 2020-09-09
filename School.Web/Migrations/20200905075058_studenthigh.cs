using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Web.Migrations
{
    public partial class studenthigh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Results",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Results_StudentId",
                table: "Results",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Students_StudentId",
                table: "Results",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Students_StudentId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_StudentId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Results");
        }
    }
}
