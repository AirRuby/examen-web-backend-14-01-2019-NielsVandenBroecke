using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamenOnlineGokken.Migrations
{
    public partial class AddedLeague : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeagueIdFK",
                table: "Games",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeagueIdFK",
                table: "Games");
        }
    }
}
