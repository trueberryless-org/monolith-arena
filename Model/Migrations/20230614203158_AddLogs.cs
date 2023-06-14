using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class AddLogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "USERNAME",
                table: "USERS",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "FACTIONS",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GAME_LOGS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GAMEID = table.Column<int>(name: "GAME_ID", type: "int", nullable: false),
                    POSITIONID = table.Column<int>(name: "POSITION_ID", type: "int", nullable: false),
                    USERID = table.Column<int>(name: "USER_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GAME_LOGS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GAME_LOGS_GAMES_GAME_ID",
                        column: x => x.GAMEID,
                        principalTable: "GAMES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GAME_LOGS_POSITIONS_POSITION_ID",
                        column: x => x.POSITIONID,
                        principalTable: "POSITIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GAME_LOGS_USERS_USER_ID",
                        column: x => x.USERID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_LOGS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TILEID = table.Column<int>(name: "TILE_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_LOGS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_LOGS_GAME_LOGS_Id",
                        column: x => x.Id,
                        principalTable: "GAME_LOGS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TILE_LOGS_TILES_BT_TILE_ID",
                        column: x => x.TILEID,
                        principalTable: "TILES_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_FIELD_LOGS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FIELDID = table.Column<int>(name: "FIELD_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_FIELD_LOGS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_FIELD_LOGS_FIELDS_FIELD_ID",
                        column: x => x.FIELDID,
                        principalTable: "FIELDS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TILE_FIELD_LOGS_TILE_LOGS_Id",
                        column: x => x.Id,
                        principalTable: "TILE_LOGS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_FIELD_DIRECTION_LOGS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FACING = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_FIELD_DIRECTION_LOGS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_FIELD_DIRECTION_LOGS_DIRECTIONS_FACING",
                        column: x => x.FACING,
                        principalTable: "DIRECTIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TILE_FIELD_DIRECTION_LOGS_TILE_FIELD_LOGS_Id",
                        column: x => x.Id,
                        principalTable: "TILE_FIELD_LOGS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_USERS_USERNAME",
                table: "USERS",
                column: "USERNAME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GAME_LOGS_GAME_ID",
                table: "GAME_LOGS",
                column: "GAME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GAME_LOGS_POSITION_ID",
                table: "GAME_LOGS",
                column: "POSITION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GAME_LOGS_USER_ID",
                table: "GAME_LOGS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TILE_FIELD_DIRECTION_LOGS_FACING",
                table: "TILE_FIELD_DIRECTION_LOGS",
                column: "FACING");

            migrationBuilder.CreateIndex(
                name: "IX_TILE_FIELD_LOGS_FIELD_ID",
                table: "TILE_FIELD_LOGS",
                column: "FIELD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TILE_LOGS_TILE_ID",
                table: "TILE_LOGS",
                column: "TILE_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TILE_FIELD_DIRECTION_LOGS");

            migrationBuilder.DropTable(
                name: "TILE_FIELD_LOGS");

            migrationBuilder.DropTable(
                name: "TILE_LOGS");

            migrationBuilder.DropTable(
                name: "GAME_LOGS");

            migrationBuilder.DropIndex(
                name: "IX_USERS_USERNAME",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "FACTIONS");

            migrationBuilder.AlterColumn<string>(
                name: "USERNAME",
                table: "USERS",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
