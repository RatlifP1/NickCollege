using Microsoft.EntityFrameworkCore.Migrations;

namespace NickCollege.Migrations.CourseInfoDb
{
    public partial class addtablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseInfo",
                columns: table => new
                {
                    CourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(nullable: true),
                    CourseDescribtion = table.Column<string>(nullable: true),
                    Credits = table.Column<int>(nullable: false),
                    grade1 = table.Column<double>(nullable: false),
                    grade2 = table.Column<double>(nullable: false),
                    grade3 = table.Column<double>(nullable: false),
                    grade4 = table.Column<double>(nullable: false),
                    grade5 = table.Column<double>(nullable: false),
                    grade6 = table.Column<double>(nullable: false),
                    grade7 = table.Column<double>(nullable: false),
                    grade8 = table.Column<double>(nullable: false),
                    grade9 = table.Column<double>(nullable: false),
                    grade10 = table.Column<double>(nullable: false),
                    average = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInfo", x => x.CourseID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseInfo");
        }
    }
}
