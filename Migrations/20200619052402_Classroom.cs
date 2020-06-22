using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TeachingSystem.Migrations
{
    public partial class Classroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15d682dd-0514-42d1-844c-e94a7a1ac62f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535a2475-a5a8-41af-b0c2-1056f3904bba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7caf6577-754b-4bd1-aa15-dbd79589a4c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a230dbc9-e4de-4184-9338-9d5b26a56020");

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    ClassroomId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Campus = table.Column<string>(nullable: true),
                    Building = table.Column<string>(nullable: true),
                    RoomNumber = table.Column<int>(nullable: false),
                    ClassroomName = table.Column<string>(nullable: true),
                    Capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.ClassroomId);
                });

            migrationBuilder.CreateTable(
                name: "newClass",
                columns: table => new
                {
                    newClassId = table.Column<string>(nullable: false),
                    CourseId = table.Column<string>(nullable: true),
                    TeacherID = table.Column<string>(nullable: true),
                    TeacherName = table.Column<string>(nullable: true),
                    StuIDList = table.Column<List<string>>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newClass", x => x.newClassId);
                    table.ForeignKey(
                        name: "FK_newClass_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpecialityCourse",
                columns: table => new
                {
                    SpecialityCourseID = table.Column<string>(nullable: false),
                    CourseId = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialityCourse", x => x.SpecialityCourseID);
                    table.ForeignKey(
                        name: "FK_SpecialityCourse_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2dc7c241-c869-497e-ae72-dc2ec8b4ac00", "e2087829-7392-4cbe-8af9-cfddf5b3aac6", "Admin", "ADMIN" },
                    { "53a9eea5-b91c-4617-895c-b1abed029216", "2482827a-c83c-47f0-9f7f-1e9ba0bb6e27", "Teacher", "TEACHER" },
                    { "0ed6d63d-d249-45c2-a9ec-e634776b8c0f", "2bcf98d0-68ac-49a2-8770-c1f4a9df897d", "Student", "STUDENT" },
                    { "f59c86da-2a2e-4d61-917a-e505be716582", "2b082589-b597-480e-a844-5910a95bc052", "Manager", "MANAGER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_newClass_CourseId",
                table: "newClass",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialityCourse_CourseId",
                table: "SpecialityCourse",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "newClass");

            migrationBuilder.DropTable(
                name: "SpecialityCourse");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ed6d63d-d249-45c2-a9ec-e634776b8c0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dc7c241-c869-497e-ae72-dc2ec8b4ac00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53a9eea5-b91c-4617-895c-b1abed029216");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f59c86da-2a2e-4d61-917a-e505be716582");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "535a2475-a5a8-41af-b0c2-1056f3904bba", "033deb12-2663-4a8b-8d93-2f2be0670686", "Admin", "ADMIN" },
                    { "15d682dd-0514-42d1-844c-e94a7a1ac62f", "212bc4d6-1474-4952-8393-920901dd069b", "Teacher", "TEACHER" },
                    { "a230dbc9-e4de-4184-9338-9d5b26a56020", "0ec43f15-a6b9-4334-91de-f8c561b5dd90", "Student", "STUDENT" },
                    { "7caf6577-754b-4bd1-aa15-dbd79589a4c8", "63f6ade5-38dd-490b-8f9d-c2ba766339d9", "Manager", "MANAGER" }
                });
        }
    }
}
