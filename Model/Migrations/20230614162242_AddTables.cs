using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class AddTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

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
                name: "FIELDS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    Z = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FIELDS", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GAMES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GAMES", x => x.Id);
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
                name: "ROLES",
                columns: table => new
                {
                    ROLEID = table.Column<int>(name: "ROLE_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDENTIFIER = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRIPTION = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLES", x => x.ROLEID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    USERID = table.Column<int>(name: "USER_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    USERNAME = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMAIL = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PASSWORDHASH = table.Column<string>(name: "PASSWORD_HASH", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.USERID);
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
                name: "POSITIONS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GAMEID = table.Column<int>(name: "GAME_ID", type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSITIONS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_POSITIONS_GAMES_GAME_ID",
                        column: x => x.GAMEID,
                        principalTable: "GAMES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LOG_ENTRIES",
                columns: table => new
                {
                    LOGID = table.Column<int>(name: "LOG_ID", type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    USERID = table.Column<int>(name: "USER_ID", type: "int", nullable: false),
                    FIELDTYPE = table.Column<string>(name: "FIELD_TYPE", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CHANGEDATE = table.Column<DateOnly>(name: "CHANGE_DATE", type: "date", nullable: false),
                    OLDVALUE = table.Column<string>(name: "OLD_VALUE", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NEWVALUE = table.Column<string>(name: "NEW_VALUE", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOG_ENTRIES", x => x.LOGID);
                    table.ForeignKey(
                        name: "FK_LOG_ENTRIES_USERS_USER_ID",
                        column: x => x.USERID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "USER_HAS_ROLES_JT",
                columns: table => new
                {
                    USERID = table.Column<int>(name: "USER_ID", type: "int", nullable: false),
                    ROLEID = table.Column<int>(name: "ROLE_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_HAS_ROLES_JT", x => new { x.USERID, x.ROLEID });
                    table.ForeignKey(
                        name: "FK_USER_HAS_ROLES_JT_ROLES_ROLE_ID",
                        column: x => x.ROLEID,
                        principalTable: "ROLES",
                        principalColumn: "ROLE_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USER_HAS_ROLES_JT_USERS_USER_ID",
                        column: x => x.USERID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "USER_PLAYS_GAMES_JT",
                columns: table => new
                {
                    USERID = table.Column<int>(name: "USER_ID", type: "int", nullable: false),
                    GAMEID = table.Column<int>(name: "GAME_ID", type: "int", nullable: false),
                    FACTIONID = table.Column<int>(name: "FACTION_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_PLAYS_GAMES_JT", x => new { x.USERID, x.GAMEID });
                    table.ForeignKey(
                        name: "FK_USER_PLAYS_GAMES_JT_FACTIONS_FACTION_ID",
                        column: x => x.FACTIONID,
                        principalTable: "FACTIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USER_PLAYS_GAMES_JT_GAMES_GAME_ID",
                        column: x => x.GAMEID,
                        principalTable: "GAMES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USER_PLAYS_GAMES_JT_USERS_USER_ID",
                        column: x => x.USERID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CHAMPIONS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NAME = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChampionType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QUANTITY = table.Column<int>(type: "int", nullable: false)
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
                name: "TILE_OCCUPIES_FIELD_JT",
                columns: table => new
                {
                    FIELDID = table.Column<int>(name: "FIELD_ID", type: "int", nullable: false),
                    TILEID = table.Column<int>(name: "TILE_ID", type: "int", nullable: false),
                    POSITIONID = table.Column<int>(name: "POSITION_ID", type: "int", nullable: false),
                    FACING = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_OCCUPIES_FIELD_JT", x => new { x.FIELDID, x.TILEID, x.POSITIONID });
                    table.ForeignKey(
                        name: "FK_TILE_OCCUPIES_FIELD_JT_DIRECTIONS_FACING",
                        column: x => x.FACING,
                        principalTable: "DIRECTIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TILE_OCCUPIES_FIELD_JT_FIELDS_FIELD_ID",
                        column: x => x.FIELDID,
                        principalTable: "FIELDS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TILE_OCCUPIES_FIELD_JT_POSITIONS_POSITION_ID",
                        column: x => x.POSITIONID,
                        principalTable: "POSITIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TILE_OCCUPIES_FIELD_JT_TILES_BT_TILE_ID",
                        column: x => x.TILEID,
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
                    FEATUREID = table.Column<int>(name: "FEATURE_ID", type: "int", nullable: false),
                    QUANTITY = table.Column<int>(type: "int", nullable: false)
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
                    LogicGateType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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

            migrationBuilder.InsertData(
                table: "ROLES",
                columns: new[] { "ROLE_ID", "DESCRIPTION", "IDENTIFIER" },
                values: new object[] { 1, "Administrator", "Admin" });

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
                name: "IX_LOG_ENTRIES_USER_ID",
                table: "LOG_ENTRIES",
                column: "USER_ID");

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
                name: "IX_POSITIONS_GAME_ID",
                table: "POSITIONS",
                column: "GAME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ROLES_IDENTIFIER",
                table: "ROLES",
                column: "IDENTIFIER",
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
                name: "IX_TILE_OCCUPIES_FIELD_JT_FACING",
                table: "TILE_OCCUPIES_FIELD_JT",
                column: "FACING");

            migrationBuilder.CreateIndex(
                name: "IX_TILE_OCCUPIES_FIELD_JT_POSITION_ID",
                table: "TILE_OCCUPIES_FIELD_JT",
                column: "POSITION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TILE_OCCUPIES_FIELD_JT_TILE_ID",
                table: "TILE_OCCUPIES_FIELD_JT",
                column: "TILE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TILES_BT_FACTION_ID",
                table: "TILES_BT",
                column: "FACTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_HAS_ROLES_JT_ROLE_ID",
                table: "USER_HAS_ROLES_JT",
                column: "ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_PLAYS_GAMES_JT_FACTION_ID",
                table: "USER_PLAYS_GAMES_JT",
                column: "FACTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_PLAYS_GAMES_JT_GAME_ID",
                table: "USER_PLAYS_GAMES_JT",
                column: "GAME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USERS_EMAIL",
                table: "USERS",
                column: "EMAIL",
                unique: true);
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
                name: "LOG_ENTRIES");

            migrationBuilder.DropTable(
                name: "ORDER_COMMANDS");

            migrationBuilder.DropTable(
                name: "ORDER_LOGIC_GATES");

            migrationBuilder.DropTable(
                name: "RUNE_HAS_DIRECTIONS_JT");

            migrationBuilder.DropTable(
                name: "RUNE_HAS_FEATURES_JT");

            migrationBuilder.DropTable(
                name: "TILE_OCCUPIES_FIELD_JT");

            migrationBuilder.DropTable(
                name: "USER_HAS_ROLES_JT");

            migrationBuilder.DropTable(
                name: "USER_PLAYS_GAMES_JT");

            migrationBuilder.DropTable(
                name: "ATTACKS");

            migrationBuilder.DropTable(
                name: "CHAMPIONS");

            migrationBuilder.DropTable(
                name: "INITIATIVES");

            migrationBuilder.DropTable(
                name: "ORDERS_BT");

            migrationBuilder.DropTable(
                name: "FEATURES");

            migrationBuilder.DropTable(
                name: "RUNES");

            migrationBuilder.DropTable(
                name: "DIRECTIONS");

            migrationBuilder.DropTable(
                name: "FIELDS");

            migrationBuilder.DropTable(
                name: "POSITIONS");

            migrationBuilder.DropTable(
                name: "ROLES");

            migrationBuilder.DropTable(
                name: "USERS");

            migrationBuilder.DropTable(
                name: "TILES_BT");

            migrationBuilder.DropTable(
                name: "GAMES");

            migrationBuilder.DropTable(
                name: "FACTIONS");
        }
    }
}
