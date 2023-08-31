using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApp.Migrations
{
    /// <inheritdoc />
    public partial class IdentityRoleSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b7ee05f-2b0f-4468-9297-5384e13cc840");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9539c915-0a48-40a7-966c-e4aab506b1b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a672a631-5d8d-420c-a598-2c6fece580b4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3080fadd-2d30-48fa-8401-a845fc3abb3c", null, "Admin", "ADMIN" },
                    { "7ae15388-c1bb-44ed-b0c5-7f33dceb2b4d", null, "Editor", "EDITOR" },
                    { "82e14d0a-c12f-4624-a826-bab9b168578b", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3080fadd-2d30-48fa-8401-a845fc3abb3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ae15388-c1bb-44ed-b0c5-7f33dceb2b4d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82e14d0a-c12f-4624-a826-bab9b168578b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6b7ee05f-2b0f-4468-9297-5384e13cc840", null, "User", "USER" },
                    { "9539c915-0a48-40a7-966c-e4aab506b1b2", null, "Editor", "EDITOR" },
                    { "a672a631-5d8d-420c-a598-2c6fece580b4", null, "Admin", "EDITOR" }
                });
        }
    }
}
