using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachingSystem.Migrations
{
    public partial class @class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "ClassroomId",
                table: "Classes",
                nullable: true);

            migrationBuilder.AddColumn<List<int>>(
                name: "TeachTime",
                table: "Classes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestTime",
                table: "Classes",
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
                name: "IX_Classes_ClassroomId",
                table: "Classes",
                column: "ClassroomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Classrooms_ClassroomId",
                table: "Classes",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Classrooms_ClassroomId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_ClassroomId",
                table: "Classes");

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
                name: "ClassroomId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TeachTime",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TestTime",
                table: "Classes");

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
        }
    }
}
