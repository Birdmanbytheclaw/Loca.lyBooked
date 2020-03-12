using Microsoft.EntityFrameworkCore.Migrations;

namespace Loca_ly.Data.Migrations
{
    public partial class roleFixTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8960f39a-2d96-4853-b22d-107cfed0edfe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b20dfea8-3f44-4a5a-acbe-5a3e2cbcda11");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a3dcbd6-d70c-43bb-814a-67a597ee413b", "ab520374-0380-4b16-8935-f134807e799e", "Venue", "VENUE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eadb0e37-b33a-4b63-93bf-4d42a6cc62e7", "33706faf-448f-4623-8e10-4414314060a8", "Artist", "ARTIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a3dcbd6-d70c-43bb-814a-67a597ee413b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eadb0e37-b33a-4b63-93bf-4d42a6cc62e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8960f39a-2d96-4853-b22d-107cfed0edfe", "08dffd15-4be5-49fa-bc16-7787f5f98643", "Venue", "VENUE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b20dfea8-3f44-4a5a-acbe-5a3e2cbcda11", "7319672c-a08f-4ef1-b2ee-5f9ac409caf8", "Artist", "ARTIST" });
        }
    }
}
