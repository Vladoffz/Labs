using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fttbll.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Championship",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Championship", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    MatchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataProvedeniya = table.Column<DateTime>(nullable: false),
                    Result = table.Column<int>(nullable: false),
                    CommandID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.MatchID);
                });

            migrationBuilder.CreateTable(
                name: "Command",
                columns: table => new
                {
                    CommandID = table.Column<int>(nullable: false),
                    PlayerID = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    MatchID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Command", x => x.CommandID);
                    table.ForeignKey(
                        name: "FK_Command_Match_MatchID",
                        column: x => x.MatchID,
                        principalTable: "Match",
                        principalColumn: "MatchID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChampionshipCommand",
                columns: table => new
                {
                    ChampionshipCommandID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChampionshipID = table.Column<int>(nullable: false),
                    CommandID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionshipCommand", x => x.ChampionshipCommandID);
                    table.ForeignKey(
                        name: "FK_ChampionshipCommand_Championship_ChampionshipID",
                        column: x => x.ChampionshipID,
                        principalTable: "Championship",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChampionshipCommand_Command_CommandID",
                        column: x => x.CommandID,
                        principalTable: "Command",
                        principalColumn: "CommandID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Command = table.Column<string>(nullable: true),
                    CommandID = table.Column<int>(nullable: true),
                    PlayerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Player_Command_CommandID",
                        column: x => x.CommandID,
                        principalTable: "Command",
                        principalColumn: "CommandID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Player_Player_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Player",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChampionshipCommand_ChampionshipID",
                table: "ChampionshipCommand",
                column: "ChampionshipID");

            migrationBuilder.CreateIndex(
                name: "IX_ChampionshipCommand_CommandID",
                table: "ChampionshipCommand",
                column: "CommandID");

            migrationBuilder.CreateIndex(
                name: "IX_Command_MatchID",
                table: "Command",
                column: "MatchID");

            migrationBuilder.CreateIndex(
                name: "IX_Player_CommandID",
                table: "Player",
                column: "CommandID");

            migrationBuilder.CreateIndex(
                name: "IX_Player_PlayerID",
                table: "Player",
                column: "PlayerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChampionshipCommand");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Championship");

            migrationBuilder.DropTable(
                name: "Command");

            migrationBuilder.DropTable(
                name: "Match");
        }
    }
}
