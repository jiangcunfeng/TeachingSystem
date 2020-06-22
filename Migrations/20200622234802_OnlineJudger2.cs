using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TeachingSystem.Migrations
{
    public partial class OnlineJudger2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestResults_Tests_TestId",
                table: "TestResults");

            migrationBuilder.DropForeignKey(
                name: "FK_TestResults_AspNetUsers_UserId",
                table: "TestResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Classes_ClassId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_ClassId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_TestResults_TestId",
                table: "TestResults");

            migrationBuilder.DropIndex(
                name: "IX_TestResults_UserId",
                table: "TestResults");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "524e8573-afbe-480b-b6fb-5c59efc9851a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c93d0559-8e1d-4895-b71c-5b986541f766");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e09b585f-cd04-43a5-87a9-11738e2872e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7691cfd-4c54-4ac9-ac7b-84a6077c892b");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TestResults");

            migrationBuilder.AlterColumn<string>(
                name: "TestId",
                table: "Tests",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TestPaperId",
                table: "Tests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "className",
                table: "Tests",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "end_time",
                table: "Tests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "start_time",
                table: "Tests",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TestResultId",
                table: "TestResults",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "TestResults",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestPaperId",
                table: "TestResults",
                nullable: true);

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
                    Point = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "TestPapers",
                columns: table => new
                {
                    TestPaperId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Content = table.Column<string[]>(nullable: false),
                    Course = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestPapers", x => x.TestPaperId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "da15f5a4-4110-44db-8598-7e1a64d68d14", "f200c7fa-1d10-4d6f-90d9-1c7aeb348df0", "Admin", "ADMIN" },
                    { "4c425fec-c224-4293-8f9c-25d4c1e31427", "405840c5-8bc1-4464-a29a-65b25a6b3299", "Teacher", "TEACHER" },
                    { "b677c78b-5a3a-44a3-b388-d04b700dfbd3", "b32e0b80-29a7-41ff-bb08-d7ab454007ad", "Student", "STUDENT" },
                    { "0fe59c62-b082-434e-928f-a56d65f6c79a", "6701e9a4-e0a4-47ff-8197-fc81ef2f50e0", "Manager", "MANAGER" }
                });
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
                keyValue: "0fe59c62-b082-434e-928f-a56d65f6c79a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c425fec-c224-4293-8f9c-25d4c1e31427");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b677c78b-5a3a-44a3-b388-d04b700dfbd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da15f5a4-4110-44db-8598-7e1a64d68d14");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "TestPaperId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "className",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "end_time",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "start_time",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "TestPaperId",
                table: "TestResults");

            migrationBuilder.AlterColumn<long>(
                name: "TestId",
                table: "Tests",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "ClassId",
                table: "Tests",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "TestResultId",
                table: "TestResults",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<long>(
                name: "TestId",
                table: "TestResults",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TestResults",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e09b585f-cd04-43a5-87a9-11738e2872e9", "a83a54ea-ff62-402e-925e-37f1039dc513", "Admin", "ADMIN" },
                    { "524e8573-afbe-480b-b6fb-5c59efc9851a", "5c783f52-1857-4acc-8dc5-01b18923784f", "Teacher", "TEACHER" },
                    { "e7691cfd-4c54-4ac9-ac7b-84a6077c892b", "37c18b4a-9aad-41ed-a536-22a66758869f", "Student", "STUDENT" },
                    { "c93d0559-8e1d-4895-b71c-5b986541f766", "9410d188-f6e4-488b-96ea-39f6ddb3c675", "Manager", "MANAGER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_ClassId",
                table: "Tests",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_TestId",
                table: "TestResults",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_UserId",
                table: "TestResults",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestResults_Tests_TestId",
                table: "TestResults",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestResults_AspNetUsers_UserId",
                table: "TestResults",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Classes_ClassId",
                table: "Tests",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
