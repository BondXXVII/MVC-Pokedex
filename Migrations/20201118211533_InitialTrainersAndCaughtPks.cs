using Microsoft.EntityFrameworkCore.Migrations;

namespace PokedexV.Migrations
{
    public partial class InitialTrainersAndCaughtPks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaughtPkId",
                table: "Pokemon",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TrainerStuff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TrainerName = table.Column<string>(type: "TEXT", nullable: true),
                    TrainerImage = table.Column<string>(type: "TEXT", nullable: true),
                    Badges = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerStuff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaughtPk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CaughtName = table.Column<string>(type: "TEXT", nullable: true),
                    CaughtDexNum = table.Column<int>(type: "INTEGER", nullable: false),
                    TrainerId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaughtPk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaughtPk_TrainerStuff_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "TrainerStuff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_CaughtPkId",
                table: "Pokemon",
                column: "CaughtPkId");

            migrationBuilder.CreateIndex(
                name: "IX_CaughtPk_TrainerId",
                table: "CaughtPk",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_CaughtPk_CaughtPkId",
                table: "Pokemon",
                column: "CaughtPkId",
                principalTable: "CaughtPk",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_CaughtPk_CaughtPkId",
                table: "Pokemon");

            migrationBuilder.DropTable(
                name: "CaughtPk");

            migrationBuilder.DropTable(
                name: "TrainerStuff");

            migrationBuilder.DropIndex(
                name: "IX_Pokemon_CaughtPkId",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "CaughtPkId",
                table: "Pokemon");
        }
    }
}
