using Microsoft.EntityFrameworkCore.Migrations;

namespace Loca_ly.Data.Migrations
{
    public partial class SyntaxFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "264ce434-ce87-45fb-8e25-5f0cc1f771e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75c65d65-06c7-4ff5-988a-e93283a45df9");

            migrationBuilder.DropColumn(
                name: "AverageRating",
                table: "Venue");

            migrationBuilder.DropColumn(
                name: "AverageRating",
                table: "Artist");

            migrationBuilder.AddColumn<string>(
                name: "ArtistReviews",
                table: "Venue",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AverageArtistRating",
                table: "Venue",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ArtistReviews",
                table: "Artist",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AverageArtistRating",
                table: "Artist",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "AverageVenueRating",
                table: "Artist",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "MainSongName",
                table: "Artist",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VenueReviews",
                table: "Artist",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "06124ee3-0073-4c22-9b6a-9c182c4619be", "25edb690-80df-46af-ab77-d04a70433824", "Venue", "VENUE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd319cad-7146-4701-8e13-8d0af90d417b", "44c3911a-0a21-4dc1-8f76-98e834021a99", "Artist", "ARTIST" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06124ee3-0073-4c22-9b6a-9c182c4619be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd319cad-7146-4701-8e13-8d0af90d417b");

            migrationBuilder.DropColumn(
                name: "ArtistReviews",
                table: "Venue");

            migrationBuilder.DropColumn(
                name: "AverageArtistRating",
                table: "Venue");

            migrationBuilder.DropColumn(
                name: "ArtistReviews",
                table: "Artist");

            migrationBuilder.DropColumn(
                name: "AverageArtistRating",
                table: "Artist");

            migrationBuilder.DropColumn(
                name: "AverageVenueRating",
                table: "Artist");

            migrationBuilder.DropColumn(
                name: "MainSongName",
                table: "Artist");

            migrationBuilder.DropColumn(
                name: "VenueReviews",
                table: "Artist");

            migrationBuilder.AddColumn<double>(
                name: "AverageRating",
                table: "Venue",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "AverageRating",
                table: "Artist",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "264ce434-ce87-45fb-8e25-5f0cc1f771e2", "8fd39663-11c6-49f5-96f9-4b0c17f1673b", "Venue", "VENUE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "75c65d65-06c7-4ff5-988a-e93283a45df9", "2ad4fffc-d511-40db-ad6d-328a5e07da27", "Artist", "ARTIST" });
        }
    }
}
