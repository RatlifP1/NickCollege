using Microsoft.EntityFrameworkCore.Migrations;

namespace NickCollege.Migrations.CourseInfoDb
{
    public partial class CourseMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FK_UserID",
                table: "CourseInfo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FK_UserID",
                table: "CourseInfo");
        }
    }
}
