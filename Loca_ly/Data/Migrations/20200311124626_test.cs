using Microsoft.EntityFrameworkCore.Migrations;

namespace Loca_ly.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "264ce434-ce87-45fb-8e25-5f0cc1f771e2", "8fd39663-11c6-49f5-96f9-4b0c17f1673b", "Venue", "VENUE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "75c65d65-06c7-4ff5-988a-e93283a45df9", "2ad4fffc-d511-40db-ad6d-328a5e07da27", "Artist", "ARTIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "264ce434-ce87-45fb-8e25-5f0cc1f771e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75c65d65-06c7-4ff5-988a-e93283a45df9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a3dcbd6-d70c-43bb-814a-67a597ee413b", "ab520374-0380-4b16-8935-f134807e799e", "Venue", "VENUE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eadb0e37-b33a-4b63-93bf-4d42a6cc62e7", "33706faf-448f-4623-8e10-4414314060a8", "Artist", "ARTIST" });
        }
    }
}
