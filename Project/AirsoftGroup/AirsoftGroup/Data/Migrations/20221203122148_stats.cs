using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftGroup.Data.Migrations
{
    public partial class stats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Win = table.Column<int>(type: "int", nullable: false),
                    Defeat = table.Column<int>(type: "int", nullable: false),
                    Accuracy = table.Column<double>(type: "float", nullable: false),
                    HeadshotPercentage = table.Column<double>(type: "float", nullable: false),
                    FavouriteWeapon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stats");
        }
    }
}
