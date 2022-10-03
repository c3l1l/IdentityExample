using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityExample.Data.Migrations
{
    public partial class Rolebasedauthorization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "255eb91c-3ce0-48da-8de4-026a83f47252", "06ff15ad-ddf9-4820-916d-f4fe00880c3a", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4aecea72-1f64-486a-bcdd-52fd7b051f64", "3439f3a8-240f-4664-8cd4-6da5391cb373", "user", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "255eb91c-3ce0-48da-8de4-026a83f47252");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4aecea72-1f64-486a-bcdd-52fd7b051f64");
        }
    }
}
