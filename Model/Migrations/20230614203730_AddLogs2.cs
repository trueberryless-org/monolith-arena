using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class AddLogs2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GAME_LOGS_GAMES_GAME_ID",
                table: "GAME_LOGS");

            migrationBuilder.DropForeignKey(
                name: "FK_GAME_LOGS_POSITIONS_POSITION_ID",
                table: "GAME_LOGS");

            migrationBuilder.DropForeignKey(
                name: "FK_GAME_LOGS_USERS_USER_ID",
                table: "GAME_LOGS");

            migrationBuilder.DropForeignKey(
                name: "FK_TILE_FIELD_DIRECTION_LOGS_DIRECTIONS_FACING",
                table: "TILE_FIELD_DIRECTION_LOGS");

            migrationBuilder.DropForeignKey(
                name: "FK_TILE_FIELD_DIRECTION_LOGS_TILE_FIELD_LOGS_Id",
                table: "TILE_FIELD_DIRECTION_LOGS");

            migrationBuilder.DropForeignKey(
                name: "FK_TILE_FIELD_LOGS_FIELDS_FIELD_ID",
                table: "TILE_FIELD_LOGS");

            migrationBuilder.DropForeignKey(
                name: "FK_TILE_FIELD_LOGS_TILE_LOGS_Id",
                table: "TILE_FIELD_LOGS");

            migrationBuilder.DropForeignKey(
                name: "FK_TILE_LOGS_GAME_LOGS_Id",
                table: "TILE_LOGS");

            migrationBuilder.DropForeignKey(
                name: "FK_TILE_LOGS_TILES_BT_TILE_ID",
                table: "TILE_LOGS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TILE_LOGS",
                table: "TILE_LOGS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TILE_FIELD_LOGS",
                table: "TILE_FIELD_LOGS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TILE_FIELD_DIRECTION_LOGS",
                table: "TILE_FIELD_DIRECTION_LOGS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GAME_LOGS",
                table: "GAME_LOGS");

            migrationBuilder.RenameTable(
                name: "TILE_LOGS",
                newName: "TILE_LOGS_BT");

            migrationBuilder.RenameTable(
                name: "TILE_FIELD_LOGS",
                newName: "TILE_FIELD_LOGS_BT");

            migrationBuilder.RenameTable(
                name: "TILE_FIELD_DIRECTION_LOGS",
                newName: "TILE_FIELD_DIRECTION_LOGS_BT");

            migrationBuilder.RenameTable(
                name: "GAME_LOGS",
                newName: "GAME_LOGS_BT");

            migrationBuilder.RenameIndex(
                name: "IX_TILE_LOGS_TILE_ID",
                table: "TILE_LOGS_BT",
                newName: "IX_TILE_LOGS_BT_TILE_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TILE_FIELD_LOGS_FIELD_ID",
                table: "TILE_FIELD_LOGS_BT",
                newName: "IX_TILE_FIELD_LOGS_BT_FIELD_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TILE_FIELD_DIRECTION_LOGS_FACING",
                table: "TILE_FIELD_DIRECTION_LOGS_BT",
                newName: "IX_TILE_FIELD_DIRECTION_LOGS_BT_FACING");

            migrationBuilder.RenameIndex(
                name: "IX_GAME_LOGS_USER_ID",
                table: "GAME_LOGS_BT",
                newName: "IX_GAME_LOGS_BT_USER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_GAME_LOGS_POSITION_ID",
                table: "GAME_LOGS_BT",
                newName: "IX_GAME_LOGS_BT_POSITION_ID");

            migrationBuilder.RenameIndex(
                name: "IX_GAME_LOGS_GAME_ID",
                table: "GAME_LOGS_BT",
                newName: "IX_GAME_LOGS_BT_GAME_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TILE_LOGS_BT",
                table: "TILE_LOGS_BT",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TILE_FIELD_LOGS_BT",
                table: "TILE_FIELD_LOGS_BT",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TILE_FIELD_DIRECTION_LOGS_BT",
                table: "TILE_FIELD_DIRECTION_LOGS_BT",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GAME_LOGS_BT",
                table: "GAME_LOGS_BT",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BATTLE_STARTS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BATTLE_STARTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BATTLE_STARTS_GAME_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "GAME_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_CHARGES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_CHARGES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_CHARGES_TILE_FIELD_DIRECTION_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_FIELD_DIRECTION_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_DISCARDS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_DISCARDS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_DISCARDS_TILE_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_DRAWS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_DRAWS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_DRAWS_TILE_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_FALSE_ORDERS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_FALSE_ORDERS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_FALSE_ORDERS_TILE_FIELD_DIRECTION_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_FIELD_DIRECTION_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_MANA_CHARGES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_MANA_CHARGES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_MANA_CHARGES_TILE_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_MOVEMENTS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_MOVEMENTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_MOVEMENTS_TILE_FIELD_DIRECTION_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_FIELD_DIRECTION_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_NETS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_NETS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_NETS_TILE_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_PLACEMENTS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_PLACEMENTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_PLACEMENTS_TILE_FIELD_DIRECTION_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_FIELD_DIRECTION_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_PRECISE_SHOTS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_PRECISE_SHOTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_PRECISE_SHOTS_TILE_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_PUSHES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_PUSHES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_PUSHES_TILE_FIELD_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_FIELD_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_STORAGES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_STORAGES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_STORAGES_TILE_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_GAME_LOGS_BT_GAMES_GAME_ID",
                table: "GAME_LOGS_BT",
                column: "GAME_ID",
                principalTable: "GAMES",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GAME_LOGS_BT_POSITIONS_POSITION_ID",
                table: "GAME_LOGS_BT",
                column: "POSITION_ID",
                principalTable: "POSITIONS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GAME_LOGS_BT_USERS_USER_ID",
                table: "GAME_LOGS_BT",
                column: "USER_ID",
                principalTable: "USERS",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TILE_FIELD_DIRECTION_LOGS_BT_DIRECTIONS_FACING",
                table: "TILE_FIELD_DIRECTION_LOGS_BT",
                column: "FACING",
                principalTable: "DIRECTIONS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TILE_FIELD_DIRECTION_LOGS_BT_TILE_FIELD_LOGS_BT_Id",
                table: "TILE_FIELD_DIRECTION_LOGS_BT",
                column: "Id",
                principalTable: "TILE_FIELD_LOGS_BT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TILE_FIELD_LOGS_BT_FIELDS_FIELD_ID",
                table: "TILE_FIELD_LOGS_BT",
                column: "FIELD_ID",
                principalTable: "FIELDS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TILE_FIELD_LOGS_BT_TILE_LOGS_BT_Id",
                table: "TILE_FIELD_LOGS_BT",
                column: "Id",
                principalTable: "TILE_LOGS_BT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TILE_LOGS_BT_GAME_LOGS_BT_Id",
                table: "TILE_LOGS_BT",
                column: "Id",
                principalTable: "GAME_LOGS_BT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TILE_LOGS_BT_TILES_BT_TILE_ID",
                table: "TILE_LOGS_BT",
                column: "TILE_ID",
                principalTable: "TILES_BT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GAME_LOGS_BT_GAMES_GAME_ID",
                table: "GAME_LOGS_BT");

            migrationBuilder.DropForeignKey(
                name: "FK_GAME_LOGS_BT_POSITIONS_POSITION_ID",
                table: "GAME_LOGS_BT");

            migrationBuilder.DropForeignKey(
                name: "FK_GAME_LOGS_BT_USERS_USER_ID",
                table: "GAME_LOGS_BT");

            migrationBuilder.DropForeignKey(
                name: "FK_TILE_FIELD_DIRECTION_LOGS_BT_DIRECTIONS_FACING",
                table: "TILE_FIELD_DIRECTION_LOGS_BT");

            migrationBuilder.DropForeignKey(
                name: "FK_TILE_FIELD_DIRECTION_LOGS_BT_TILE_FIELD_LOGS_BT_Id",
                table: "TILE_FIELD_DIRECTION_LOGS_BT");

            migrationBuilder.DropForeignKey(
                name: "FK_TILE_FIELD_LOGS_BT_FIELDS_FIELD_ID",
                table: "TILE_FIELD_LOGS_BT");

            migrationBuilder.DropForeignKey(
                name: "FK_TILE_FIELD_LOGS_BT_TILE_LOGS_BT_Id",
                table: "TILE_FIELD_LOGS_BT");

            migrationBuilder.DropForeignKey(
                name: "FK_TILE_LOGS_BT_GAME_LOGS_BT_Id",
                table: "TILE_LOGS_BT");

            migrationBuilder.DropForeignKey(
                name: "FK_TILE_LOGS_BT_TILES_BT_TILE_ID",
                table: "TILE_LOGS_BT");

            migrationBuilder.DropTable(
                name: "BATTLE_STARTS");

            migrationBuilder.DropTable(
                name: "TILE_CHARGES");

            migrationBuilder.DropTable(
                name: "TILE_DISCARDS");

            migrationBuilder.DropTable(
                name: "TILE_DRAWS");

            migrationBuilder.DropTable(
                name: "TILE_FALSE_ORDERS");

            migrationBuilder.DropTable(
                name: "TILE_MANA_CHARGES");

            migrationBuilder.DropTable(
                name: "TILE_MOVEMENTS");

            migrationBuilder.DropTable(
                name: "TILE_NETS");

            migrationBuilder.DropTable(
                name: "TILE_PLACEMENTS");

            migrationBuilder.DropTable(
                name: "TILE_PRECISE_SHOTS");

            migrationBuilder.DropTable(
                name: "TILE_PUSHES");

            migrationBuilder.DropTable(
                name: "TILE_STORAGES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TILE_LOGS_BT",
                table: "TILE_LOGS_BT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TILE_FIELD_LOGS_BT",
                table: "TILE_FIELD_LOGS_BT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TILE_FIELD_DIRECTION_LOGS_BT",
                table: "TILE_FIELD_DIRECTION_LOGS_BT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GAME_LOGS_BT",
                table: "GAME_LOGS_BT");

            migrationBuilder.RenameTable(
                name: "TILE_LOGS_BT",
                newName: "TILE_LOGS");

            migrationBuilder.RenameTable(
                name: "TILE_FIELD_LOGS_BT",
                newName: "TILE_FIELD_LOGS");

            migrationBuilder.RenameTable(
                name: "TILE_FIELD_DIRECTION_LOGS_BT",
                newName: "TILE_FIELD_DIRECTION_LOGS");

            migrationBuilder.RenameTable(
                name: "GAME_LOGS_BT",
                newName: "GAME_LOGS");

            migrationBuilder.RenameIndex(
                name: "IX_TILE_LOGS_BT_TILE_ID",
                table: "TILE_LOGS",
                newName: "IX_TILE_LOGS_TILE_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TILE_FIELD_LOGS_BT_FIELD_ID",
                table: "TILE_FIELD_LOGS",
                newName: "IX_TILE_FIELD_LOGS_FIELD_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TILE_FIELD_DIRECTION_LOGS_BT_FACING",
                table: "TILE_FIELD_DIRECTION_LOGS",
                newName: "IX_TILE_FIELD_DIRECTION_LOGS_FACING");

            migrationBuilder.RenameIndex(
                name: "IX_GAME_LOGS_BT_USER_ID",
                table: "GAME_LOGS",
                newName: "IX_GAME_LOGS_USER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_GAME_LOGS_BT_POSITION_ID",
                table: "GAME_LOGS",
                newName: "IX_GAME_LOGS_POSITION_ID");

            migrationBuilder.RenameIndex(
                name: "IX_GAME_LOGS_BT_GAME_ID",
                table: "GAME_LOGS",
                newName: "IX_GAME_LOGS_GAME_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TILE_LOGS",
                table: "TILE_LOGS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TILE_FIELD_LOGS",
                table: "TILE_FIELD_LOGS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TILE_FIELD_DIRECTION_LOGS",
                table: "TILE_FIELD_DIRECTION_LOGS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GAME_LOGS",
                table: "GAME_LOGS",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GAME_LOGS_GAMES_GAME_ID",
                table: "GAME_LOGS",
                column: "GAME_ID",
                principalTable: "GAMES",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GAME_LOGS_POSITIONS_POSITION_ID",
                table: "GAME_LOGS",
                column: "POSITION_ID",
                principalTable: "POSITIONS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GAME_LOGS_USERS_USER_ID",
                table: "GAME_LOGS",
                column: "USER_ID",
                principalTable: "USERS",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TILE_FIELD_DIRECTION_LOGS_DIRECTIONS_FACING",
                table: "TILE_FIELD_DIRECTION_LOGS",
                column: "FACING",
                principalTable: "DIRECTIONS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TILE_FIELD_DIRECTION_LOGS_TILE_FIELD_LOGS_Id",
                table: "TILE_FIELD_DIRECTION_LOGS",
                column: "Id",
                principalTable: "TILE_FIELD_LOGS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TILE_FIELD_LOGS_FIELDS_FIELD_ID",
                table: "TILE_FIELD_LOGS",
                column: "FIELD_ID",
                principalTable: "FIELDS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TILE_FIELD_LOGS_TILE_LOGS_Id",
                table: "TILE_FIELD_LOGS",
                column: "Id",
                principalTable: "TILE_LOGS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TILE_LOGS_GAME_LOGS_Id",
                table: "TILE_LOGS",
                column: "Id",
                principalTable: "GAME_LOGS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TILE_LOGS_TILES_BT_TILE_ID",
                table: "TILE_LOGS",
                column: "TILE_ID",
                principalTable: "TILES_BT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
