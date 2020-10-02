using System;
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
                    Id = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Admin = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Teacher = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Student = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    StudentID = table.Column<string>(type: "nvarchar(10)", nullable: false),
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
                    average = table.Column<double>(nullable: false),
                    FK_SectionID = table.Column<int>(nullable: false)
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
