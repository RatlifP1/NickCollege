using Microsoft.EntityFrameworkCore.Migrations;

namespace NickCollege.Migrations.SectionDb
{
    public partial class SectionMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FK_UserID",
                table: "Section",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FK_UserID",
                table: "Section");
        }
    }
}
