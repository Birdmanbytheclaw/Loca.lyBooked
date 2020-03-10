using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loca_ly.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87ae4405-eb45-4e66-9441-779449d2aa44");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff764c31-cef6-476f-83c2-c0b893f4a4b7");

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndividualName = table.Column<string>(nullable: true),
                    BandName = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Zipcode = table.Column<int>(nullable: false),
                    MinPay = table.Column<double>(nullable: false),
                    AverageRating = table.Column<double>(nullable: false),
                    GigAcceptedCurrently = table.Column<bool>(nullable: false),
                    MaxTravelDistance = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Venue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    GenrePreference = table.Column<string>(nullable: true),
                    CoverCharge = table.Column<bool>(nullable: false),
                    MaxPay = table.Column<int>(nullable: false),
                    GigTime = table.Column<DateTime>(nullable: false),
                    AverageRating = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "06a22d06-c406-4fe2-b458-c0cb783f40fd", "cc4cf074-5452-42ea-b49e-c9f6eb8cec9f", "Venue", "VENUE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59f6c924-ebdf-4bb5-99a6-e48e7c77a465", "28002088-f8ea-42e6-b238-33bb1349e41b", "Artist", "ARTIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Venue");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06a22d06-c406-4fe2-b458-c0cb783f40fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59f6c924-ebdf-4bb5-99a6-e48e7c77a465");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87ae4405-eb45-4e66-9441-779449d2aa44", "ebf91222-ddad-4b10-8657-314f099cecf2", "Venue", "VENUE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff764c31-cef6-476f-83c2-c0b893f4a4b7", "a4c1a42b-29f3-47bb-bf68-0010ad17ffbe", "Artist", "ARTIST" });
        }
    }
}
