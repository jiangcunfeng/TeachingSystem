using Microsoft.EntityFrameworkCore.Migrations;

namespace TeachingSystem.Migrations
{
    public partial class OnlineJudger2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05ccc701-f09e-46c4-b826-e1b98098e3cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74af2655-5e31-4f9a-a443-7fce399e6f1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a888c12-065d-4688-ae6e-dc6831e69e6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e82a84e4-2ca2-4220-8f30-8e0a2afabc15");

            migrationBuilder.AddColumn<string>(
                name: "Score",
                table: "TestResults",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "261f890d-c650-4110-865f-8b04cda29d26", "778acc5b-7c67-43be-afe2-1f406de9ba21", "Admin", "ADMIN" },
                    { "74f20661-df10-4628-8d94-aac95fa3b425", "7b3e68e3-21c7-4d91-8da8-c47c73f7cc48", "Teacher", "TEACHER" },
                    { "a6d492e4-7fb6-483d-b5bd-577f621891c9", "5d5b4ef8-781b-4154-a8b4-308d19c96bbb", "Student", "STUDENT" },
                    { "f134009e-89ff-47a2-9dbd-1af5fb30dd24", "2438dab1-f6b3-4eff-be27-c970d2231afe", "Manager", "MANAGER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "261f890d-c650-4110-865f-8b04cda29d26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74f20661-df10-4628-8d94-aac95fa3b425");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6d492e4-7fb6-483d-b5bd-577f621891c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f134009e-89ff-47a2-9dbd-1af5fb30dd24");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "TestResults");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05ccc701-f09e-46c4-b826-e1b98098e3cb", "19640505-e50b-4a78-927b-2cdc4d2a9731", "Admin", "ADMIN" },
                    { "e82a84e4-2ca2-4220-8f30-8e0a2afabc15", "bcec6194-8b53-4639-a5dc-9d1d0507c468", "Teacher", "TEACHER" },
                    { "74af2655-5e31-4f9a-a443-7fce399e6f1e", "f444ba03-2be3-4fad-a9c2-f28aa5cbe288", "Student", "STUDENT" },
                    { "8a888c12-065d-4688-ae6e-dc6831e69e6c", "f2bb29b3-69fb-497d-afbd-cb56b8ec7229", "Manager", "MANAGER" }
                });
        }
    }
}
