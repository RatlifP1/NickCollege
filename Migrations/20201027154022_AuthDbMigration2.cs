using Microsoft.EntityFrameworkCore.Migrations;

namespace NickCollege.Migrations
{
    public partial class AuthDbMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "AspNetUsers");
        }
    }
}
