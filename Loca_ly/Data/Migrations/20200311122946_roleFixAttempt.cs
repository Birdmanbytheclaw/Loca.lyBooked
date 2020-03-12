using Microsoft.EntityFrameworkCore.Migrations;

namespace Loca_ly.Data.Migrations
{
    public partial class roleFixAttempt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2802f12a-cc83-440a-b430-e0a7e02f4ac9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a93381b0-4912-43c0-8833-9bb69af80553");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8960f39a-2d96-4853-b22d-107cfed0edfe", "08dffd15-4be5-49fa-bc16-7787f5f98643", "Venue", "VENUE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b20dfea8-3f44-4a5a-acbe-5a3e2cbcda11", "7319672c-a08f-4ef1-b2ee-5f9ac409caf8", "Artist", "ARTIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2802f12a-cc83-440a-b430-e0a7e02f4ac9", "25d9f276-c7bb-41a7-be97-e1fb592ad1b7", "Venue", "VENUE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a93381b0-4912-43c0-8833-9bb69af80553", "094a5e9d-050f-4cda-a572-e96066c0d2c0", "Artist", "ARTIST" });
        }
    }
}
