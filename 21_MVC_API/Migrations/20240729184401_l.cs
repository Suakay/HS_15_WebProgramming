using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _21_MVC_API.Migrations
{
    /// <inheritdoc />
    public partial class l : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "396285ca-6674-4129-92fc-a3004b52d1c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbf44967-46e6-4d47-bc5b-40db6b3ad91b");

            migrationBuilder.RenameColumn(
                name: "LastNme",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FirstNme",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29dcbc29-ed7f-4f06-80a7-b996be56a97d", null, "User", "USER" },
                    { "549b8aec-262c-44c7-a021-4802b7f6324d", null, "Admin", "ADMİN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29dcbc29-ed7f-4f06-80a7-b996be56a97d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "549b8aec-262c-44c7-a021-4802b7f6324d");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "LastNme");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "FirstNme");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "396285ca-6674-4129-92fc-a3004b52d1c5", null, "User", "USER" },
                    { "cbf44967-46e6-4d47-bc5b-40db6b3ad91b", null, "Admin", "ADMİN" }
                });
        }
    }
}
