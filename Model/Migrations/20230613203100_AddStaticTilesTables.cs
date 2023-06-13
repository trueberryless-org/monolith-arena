using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class AddStaticTilesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ATTACKS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AttackType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATTACKS", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DIRECTIONS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DirectionType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIRECTIONS", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FACTIONS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FACTIONS", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FEATURES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FeatureType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FEATURES", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "INITIATIVES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INITIATIVES", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TILES_BT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FACTIONID = table.Column<int>(name: "FACTION_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILES_BT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TILES_BT_FACTIONS_FACTION_ID",
                        column: x => x.FACTIONID,
                        principalTable: "FACTIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CHAMPIONS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ChampionType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAMPIONS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CHAMPIONS_TILES_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILES_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ORDERS_BT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERS_BT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ORDERS_BT_TILES_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILES_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RUNES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RuneType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUNES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RUNES_TILES_BT_Id",
                        column: x => x.Id,
                        principalTable: "TILES_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CHAMPION_HAS_ATTACKS_JT",
                columns: table => new
                {
                    CHAMPIONID = table.Column<int>(name: "CHAMPION_ID", type: "int", nullable: false),
                    ATTACKID = table.Column<int>(name: "ATTACK_ID", type: "int", nullable: false),
                    DIRECTIONID = table.Column<int>(name: "DIRECTION_ID", type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAMPION_HAS_ATTACKS_JT", x => new { x.CHAMPIONID, x.ATTACKID, x.DIRECTIONID });
                    table.ForeignKey(
                        name: "FK_CHAMPION_HAS_ATTACKS_JT_ATTACKS_ATTACK_ID",
                        column: x => x.ATTACKID,
                        principalTable: "ATTACKS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CHAMPION_HAS_ATTACKS_JT_CHAMPIONS_CHAMPION_ID",
                        column: x => x.CHAMPIONID,
                        principalTable: "CHAMPIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CHAMPION_HAS_ATTACKS_JT_DIRECTIONS_DIRECTION_ID",
                        column: x => x.DIRECTIONID,
                        principalTable: "DIRECTIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CHAMPION_HAS_FEATURES_JT",
                columns: table => new
                {
                    CHAMPIONID = table.Column<int>(name: "CHAMPION_ID", type: "int", nullable: false),
                    FEATUREID = table.Column<int>(name: "FEATURE_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAMPION_HAS_FEATURES_JT", x => new { x.CHAMPIONID, x.FEATUREID });
                    table.ForeignKey(
                        name: "FK_CHAMPION_HAS_FEATURES_JT_CHAMPIONS_CHAMPION_ID",
                        column: x => x.CHAMPIONID,
                        principalTable: "CHAMPIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CHAMPION_HAS_FEATURES_JT_FEATURES_FEATURE_ID",
                        column: x => x.FEATUREID,
                        principalTable: "FEATURES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CHAMPION_HAS_INITIATIVES_JT",
                columns: table => new
                {
                    CHAMPIONID = table.Column<int>(name: "CHAMPION_ID", type: "int", nullable: false),
                    INITIATIVEID = table.Column<int>(name: "INITIATIVE_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAMPION_HAS_INITIATIVES_JT", x => new { x.CHAMPIONID, x.INITIATIVEID });
                    table.ForeignKey(
                        name: "FK_CHAMPION_HAS_INITIATIVES_JT_CHAMPIONS_CHAMPION_ID",
                        column: x => x.CHAMPIONID,
                        principalTable: "CHAMPIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CHAMPION_HAS_INITIATIVES_JT_INITIATIVES_INITIATIVE_ID",
                        column: x => x.INITIATIVEID,
                        principalTable: "INITIATIVES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ORDER_COMMANDS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    OrderType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER_COMMANDS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ORDER_COMMANDS_ORDERS_BT_Id",
                        column: x => x.Id,
                        principalTable: "ORDERS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ORDER_LOGIC_GATES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    LogicGateType = table.Column<int>(type: "int", nullable: false),
                    OPTIONONEORDERID = table.Column<int>(name: "OPTION_ONE_ORDER_ID", type: "int", nullable: false),
                    OPTIONTWOORDERID = table.Column<int>(name: "OPTION_TWO_ORDER_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER_LOGIC_GATES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ORDER_LOGIC_GATES_ORDERS_BT_Id",
                        column: x => x.Id,
                        principalTable: "ORDERS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDER_LOGIC_GATES_ORDERS_BT_OPTION_ONE_ORDER_ID",
                        column: x => x.OPTIONONEORDERID,
                        principalTable: "ORDERS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDER_LOGIC_GATES_ORDERS_BT_OPTION_TWO_ORDER_ID",
                        column: x => x.OPTIONTWOORDERID,
                        principalTable: "ORDERS_BT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RUNE_HAS_DIRECTIONS_JT",
                columns: table => new
                {
                    RUNEID = table.Column<int>(name: "RUNE_ID", type: "int", nullable: false),
                    DIRECTIONID = table.Column<int>(name: "DIRECTION_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUNE_HAS_DIRECTIONS_JT", x => new { x.RUNEID, x.DIRECTIONID });
                    table.ForeignKey(
                        name: "FK_RUNE_HAS_DIRECTIONS_JT_DIRECTIONS_DIRECTION_ID",
                        column: x => x.DIRECTIONID,
                        principalTable: "DIRECTIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RUNE_HAS_DIRECTIONS_JT_RUNES_RUNE_ID",
                        column: x => x.RUNEID,
                        principalTable: "RUNES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RUNE_HAS_FEATURES_JT",
                columns: table => new
                {
                    RUNEID = table.Column<int>(name: "RUNE_ID", type: "int", nullable: false),
                    FEATUREID = table.Column<int>(name: "FEATURE_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUNE_HAS_FEATURES_JT", x => new { x.RUNEID, x.FEATUREID });
                    table.ForeignKey(
                        name: "FK_RUNE_HAS_FEATURES_JT_FEATURES_FEATURE_ID",
                        column: x => x.FEATUREID,
                        principalTable: "FEATURES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RUNE_HAS_FEATURES_JT_RUNES_RUNE_ID",
                        column: x => x.RUNEID,
                        principalTable: "RUNES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CHAMPION_HAS_ATTACKS_JT_ATTACK_ID",
                table: "CHAMPION_HAS_ATTACKS_JT",
                column: "ATTACK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CHAMPION_HAS_ATTACKS_JT_DIRECTION_ID",
                table: "CHAMPION_HAS_ATTACKS_JT",
                column: "DIRECTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CHAMPION_HAS_FEATURES_JT_FEATURE_ID",
                table: "CHAMPION_HAS_FEATURES_JT",
                column: "FEATURE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CHAMPION_HAS_INITIATIVES_JT_INITIATIVE_ID",
                table: "CHAMPION_HAS_INITIATIVES_JT",
                column: "INITIATIVE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_LOGIC_GATES_OPTION_ONE_ORDER_ID",
                table: "ORDER_LOGIC_GATES",
                column: "OPTION_ONE_ORDER_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_LOGIC_GATES_OPTION_TWO_ORDER_ID",
                table: "ORDER_LOGIC_GATES",
                column: "OPTION_TWO_ORDER_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RUNE_HAS_DIRECTIONS_JT_DIRECTION_ID",
                table: "RUNE_HAS_DIRECTIONS_JT",
                column: "DIRECTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RUNE_HAS_FEATURES_JT_FEATURE_ID",
                table: "RUNE_HAS_FEATURES_JT",
                column: "FEATURE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TILES_BT_FACTION_ID",
                table: "TILES_BT",
                column: "FACTION_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHAMPION_HAS_ATTACKS_JT");

            migrationBuilder.DropTable(
                name: "CHAMPION_HAS_FEATURES_JT");

            migrationBuilder.DropTable(
                name: "CHAMPION_HAS_INITIATIVES_JT");

            migrationBuilder.DropTable(
                name: "ORDER_COMMANDS");

            migrationBuilder.DropTable(
                name: "ORDER_LOGIC_GATES");

            migrationBuilder.DropTable(
                name: "RUNE_HAS_DIRECTIONS_JT");

            migrationBuilder.DropTable(
                name: "RUNE_HAS_FEATURES_JT");

            migrationBuilder.DropTable(
                name: "ATTACKS");

            migrationBuilder.DropTable(
                name: "CHAMPIONS");

            migrationBuilder.DropTable(
                name: "INITIATIVES");

            migrationBuilder.DropTable(
                name: "ORDERS_BT");

            migrationBuilder.DropTable(
                name: "DIRECTIONS");

            migrationBuilder.DropTable(
                name: "FEATURES");

            migrationBuilder.DropTable(
                name: "RUNES");

            migrationBuilder.DropTable(
                name: "TILES_BT");

            migrationBuilder.DropTable(
                name: "FACTIONS");
        }
    }
}
