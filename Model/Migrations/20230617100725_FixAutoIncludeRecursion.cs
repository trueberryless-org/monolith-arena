using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class FixAutoIncludeRecursion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "TILE_GIFTS");

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

            migrationBuilder.DropTable(
                name: "TILE_FIELD_DIRECTION_LOGS_BT");

            migrationBuilder.DropTable(
                name: "TILE_FIELD_LOGS_BT");

            migrationBuilder.DropTable(
                name: "TILE_LOGS_BT");

            migrationBuilder.DropColumn(
                name: "ChampionType",
                table: "CHAMPIONS");

            migrationBuilder.DropColumn(
                name: "QUANTITY",
                table: "CHAMPIONS");

            migrationBuilder.RenameColumn(
                name: "AttackType",
                table: "ATTACKS",
                newName: "ATTACK_TYPE");

            migrationBuilder.AddColumn<int>(
                name: "QUANTITY",
                table: "TILES_BT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SPECIAL_FEATURE_ID",
                table: "RUNES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FACING",
                table: "GAME_LOGS_BT",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FIELD_ID",
                table: "GAME_LOGS_BT",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LOG_TYPE",
                table: "GAME_LOGS_BT",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "TILE_ID",
                table: "GAME_LOGS_BT",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BANNERS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SPECIALFEATUREID = table.Column<int>(name: "SPECIAL_FEATURE_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANNERS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BANNERS_CHAMPIONS_Id",
                        column: x => x.Id,
                        principalTable: "CHAMPIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BANNERS_FEATURES_SPECIAL_FEATURE_ID",
                        column: x => x.SPECIALFEATUREID,
                        principalTable: "FEATURES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_RUNES_SPECIAL_FEATURE_ID",
                table: "RUNES",
                column: "SPECIAL_FEATURE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GAME_LOGS_BT_FACING",
                table: "GAME_LOGS_BT",
                column: "FACING");

            migrationBuilder.CreateIndex(
                name: "IX_GAME_LOGS_BT_FIELD_ID",
                table: "GAME_LOGS_BT",
                column: "FIELD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GAME_LOGS_BT_TILE_ID",
                table: "GAME_LOGS_BT",
                column: "TILE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BANNERS_SPECIAL_FEATURE_ID",
                table: "BANNERS",
                column: "SPECIAL_FEATURE_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_GAME_LOGS_BT_DIRECTIONS_FACING",
                table: "GAME_LOGS_BT",
                column: "FACING",
                principalTable: "DIRECTIONS",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GAME_LOGS_BT_FIELDS_FIELD_ID",
                table: "GAME_LOGS_BT",
                column: "FIELD_ID",
                principalTable: "FIELDS",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GAME_LOGS_BT_TILES_BT_TILE_ID",
                table: "GAME_LOGS_BT",
                column: "TILE_ID",
                principalTable: "TILES_BT",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RUNES_FEATURES_SPECIAL_FEATURE_ID",
                table: "RUNES",
                column: "SPECIAL_FEATURE_ID",
                principalTable: "FEATURES",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GAME_LOGS_BT_DIRECTIONS_FACING",
                table: "GAME_LOGS_BT");

            migrationBuilder.DropForeignKey(
                name: "FK_GAME_LOGS_BT_FIELDS_FIELD_ID",
                table: "GAME_LOGS_BT");

            migrationBuilder.DropForeignKey(
                name: "FK_GAME_LOGS_BT_TILES_BT_TILE_ID",
                table: "GAME_LOGS_BT");

            migrationBuilder.DropForeignKey(
                name: "FK_RUNES_FEATURES_SPECIAL_FEATURE_ID",
                table: "RUNES");

            migrationBuilder.DropTable(
                name: "BANNERS");

            migrationBuilder.DropIndex(
                name: "IX_RUNES_SPECIAL_FEATURE_ID",
                table: "RUNES");

            migrationBuilder.DropIndex(
                name: "IX_GAME_LOGS_BT_FACING",
                table: "GAME_LOGS_BT");

            migrationBuilder.DropIndex(
                name: "IX_GAME_LOGS_BT_FIELD_ID",
                table: "GAME_LOGS_BT");

            migrationBuilder.DropIndex(
                name: "IX_GAME_LOGS_BT_TILE_ID",
                table: "GAME_LOGS_BT");

            migrationBuilder.DropColumn(
                name: "QUANTITY",
                table: "TILES_BT");

            migrationBuilder.DropColumn(
                name: "SPECIAL_FEATURE_ID",
                table: "RUNES");

            migrationBuilder.DropColumn(
                name: "FACING",
                table: "GAME_LOGS_BT");

            migrationBuilder.DropColumn(
                name: "FIELD_ID",
                table: "GAME_LOGS_BT");

            migrationBuilder.DropColumn(
                name: "LOG_TYPE",
                table: "GAME_LOGS_BT");

            migrationBuilder.DropColumn(
                name: "TILE_ID",
                table: "GAME_LOGS_BT");

            migrationBuilder.RenameColumn(
                name: "ATTACK_TYPE",
                table: "ATTACKS",
                newName: "AttackType");

            migrationBuilder.AddColumn<string>(
                name: "ChampionType",
                table: "CHAMPIONS",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "QUANTITY",
                table: "CHAMPIONS",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "TILE_LOGS_BT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TILEID = table.Column<int>(name: "TILE_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_LOGS_BT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_LOGS_BT_GAME_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "GAME_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TILE_LOGS_BT_TILES_BT_TILE_ID",
                        column: x => x.TILEID,
                        principalTable: "TILES_BT",
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
                name: "TILE_FIELD_LOGS_BT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FIELDID = table.Column<int>(name: "FIELD_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_FIELD_LOGS_BT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_FIELD_LOGS_BT_FIELDS_FIELD_ID",
                        column: x => x.FIELDID,
                        principalTable: "FIELDS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TILE_FIELD_LOGS_BT_TILE_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_LOGS_BT",
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

            migrationBuilder.CreateTable(
                name: "TILE_FIELD_DIRECTION_LOGS_BT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FACING = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_FIELD_DIRECTION_LOGS_BT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_FIELD_DIRECTION_LOGS_BT_DIRECTIONS_FACING",
                        column: x => x.FACING,
                        principalTable: "DIRECTIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TILE_FIELD_DIRECTION_LOGS_BT_TILE_FIELD_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_FIELD_LOGS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILE_GIFTS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_GIFTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILE_GIFTS_TILE_FIELD_LOGS_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILE_FIELD_LOGS_BT",
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

            migrationBuilder.CreateIndex(
                name: "IX_TILE_FIELD_DIRECTION_LOGS_BT_FACING",
                table: "TILE_FIELD_DIRECTION_LOGS_BT",
                column: "FACING");

            migrationBuilder.CreateIndex(
                name: "IX_TILE_FIELD_LOGS_BT_FIELD_ID",
                table: "TILE_FIELD_LOGS_BT",
                column: "FIELD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TILE_LOGS_BT_TILE_ID",
                table: "TILE_LOGS_BT",
                column: "TILE_ID");
        }
    }
}
