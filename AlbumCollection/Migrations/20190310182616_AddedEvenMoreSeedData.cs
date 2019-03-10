using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class AddedEvenMoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "Artist", "ReleaseYear", "Title" },
                values: new object[] { 3, "Megadeth", 1994, "Youthanasia" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "SongName" },
                values: new object[,]
                {
                    { 6, 3, "Reckoning Day" },
                    { 7, 3, "Train of Consequences" },
                    { 8, 3, "Addicted To Chaos" },
                    { 9, 3, "A Tout le Monde" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3);
        }
    }
}
