using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TeachingSystem.Migrations
{
    public partial class OnlineJudger1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestResults");

            migrationBuilder.DropTable(
                name: "Tests");

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
                name: "TestPapers",
                columns: table => new
                {
                    TestPaperId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Course = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestPapers", x => x.TestPaperId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: false),
                    ChoiceA = table.Column<string>(nullable: true),
                    ChoiceB = table.Column<string>(nullable: true),
                    ChoiceC = table.Column<string>(nullable: true),
                    ChoiceD = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: false),
                    Course = table.Column<string>(nullable: true),
                    Point = table.Column<string>(nullable: true),
                    TestPaperId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_TestPapers_TestPaperId",
                        column: x => x.TestPaperId,
                        principalTable: "TestPapers",
                        principalColumn: "TestPaperId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16bcf8f0-d3ef-4878-ab4f-8bf57e5f72cc", "c6459d14-41fc-48d2-a1e2-06201128f204", "Admin", "ADMIN" },
                    { "95b549b7-2252-4d87-9c1a-80c1ac335194", "ab20bfdc-16b8-47b1-9670-7bd7fe23e009", "Teacher", "TEACHER" },
                    { "90e1eb79-29c6-4ac4-b236-17d941d3ef3c", "f0b22560-aa65-4348-83a6-8bddcf87d414", "Student", "STUDENT" },
                    { "f6a18f83-18b0-41f6-86c6-5c888bb2eb01", "d75e52ed-2d00-4b1c-91cd-50220eac5a75", "Manager", "MANAGER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TestPaperId",
                table: "Questions",
                column: "TestPaperId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "TestPapers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16bcf8f0-d3ef-4878-ab4f-8bf57e5f72cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90e1eb79-29c6-4ac4-b236-17d941d3ef3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95b549b7-2252-4d87-9c1a-80c1ac335194");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6a18f83-18b0-41f6-86c6-5c888bb2eb01");

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    TestId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClassId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.TestId);
                    table.ForeignKey(
                        name: "FK_Tests_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestResults",
                columns: table => new
                {
                    TestResultId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TestId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestResults", x => x.TestResultId);
                    table.ForeignKey(
                        name: "FK_TestResults_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "TestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestResults_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_TestId",
                table: "TestResults",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_UserId",
                table: "TestResults",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_ClassId",
                table: "Tests",
                column: "ClassId");
        }
    }
}
