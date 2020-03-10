using Microsoft.EntityFrameworkCore.Migrations;

namespace Loca_ly.Data.Migrations
{
    public partial class instumentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06a22d06-c406-4fe2-b458-c0cb783f40fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59f6c924-ebdf-4bb5-99a6-e48e7c77a465");

            migrationBuilder.AddColumn<string>(
                name: "Instrument",
                table: "Artist",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2802f12a-cc83-440a-b430-e0a7e02f4ac9", "25d9f276-c7bb-41a7-be97-e1fb592ad1b7", "Venue", "VENUE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a93381b0-4912-43c0-8833-9bb69af80553", "094a5e9d-050f-4cda-a572-e96066c0d2c0", "Artist", "ARTIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2802f12a-cc83-440a-b430-e0a7e02f4ac9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a93381b0-4912-43c0-8833-9bb69af80553");

            migrationBuilder.DropColumn(
                name: "Instrument",
                table: "Artist");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "06a22d06-c406-4fe2-b458-c0cb783f40fd", "cc4cf074-5452-42ea-b49e-c9f6eb8cec9f", "Venue", "VENUE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59f6c924-ebdf-4bb5-99a6-e48e7c77a465", "28002088-f8ea-42e6-b238-33bb1349e41b", "Artist", "ARTIST" });
        }
    }
}
