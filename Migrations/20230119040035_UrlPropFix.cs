using Microsoft.EntityFrameworkCore.Migrations;

namespace eMovieTickets.Migrations
{
    public partial class UrlPropFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProvilePictureUrl",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Movies",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "StartData",
                table: "Movies",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "EndData",
                table: "Movies",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "ProvilePictureUrl",
                table: "Actors",
                newName: "ProfilePictureURL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Producers",
                newName: "ProvilePictureUrl");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Movies",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Movies",
                newName: "StartData");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Movies",
                newName: "EndData");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Actors",
                newName: "ProvilePictureUrl");
        }
    }
}
