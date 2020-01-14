using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamenOnlineGokken.Migrations
{
    public partial class AddedLeagueENAddedSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "LeagueId",
                table: "Games",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "League",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_League", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "League",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "serie A" },
                    { 2L, "UEFA Champions League" },
                    { 3L, "UEFA Europa League" },
                    { 4L, "Jupiler Pro League" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L,
                column: "LeagueId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L,
                column: "LeagueId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L,
                column: "LeagueId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4L,
                column: "LeagueId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5L,
                column: "LeagueId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6L,
                column: "LeagueId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7L,
                column: "LeagueId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8L,
                column: "LeagueId",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9L,
                column: "LeagueId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10L,
                column: "LeagueId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11L,
                column: "LeagueId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12L,
                column: "LeagueId",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13L,
                column: "LeagueId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14L,
                column: "LeagueId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15L,
                column: "LeagueId",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16L,
                column: "LeagueId",
                value: 4L);

            migrationBuilder.CreateIndex(
                name: "IX_Games_LeagueId",
                table: "Games",
                column: "LeagueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_League_LeagueId",
                table: "Games",
                column: "LeagueId",
                principalTable: "League",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_League_LeagueId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "League");

            migrationBuilder.DropIndex(
                name: "IX_Games_LeagueId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "Games");
        }
    }
}
