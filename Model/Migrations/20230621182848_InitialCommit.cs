using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FACTIONS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FACTIONS", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FIELDS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    Z = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FIELDS", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GAMES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    STARTEDAT = table.Column<DateTime>(name: "STARTED_AT", type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GAMES", x => x.Id);
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
                    USERNAME = table.Column<string>(type: "varchar(255)", nullable: false)
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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FACTIONID = table.Column<int>(name: "FACTION_ID", type: "int", nullable: false),
                    QUANTITY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILES_BT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TILES_BT_FACTIONS_FACTION_ID",
                        column: x => x.FACTIONID,
                        principalTable: "FACTIONS",
                        principalColumn: "ID",
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
                    FACTIONID = table.Column<int>(name: "FACTION_ID", type: "int", nullable: false),
                    STARREDTHISGAME = table.Column<bool>(name: "STARRED_THIS_GAME", type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_PLAYS_GAMES_JT", x => new { x.USERID, x.GAMEID });
                    table.ForeignKey(
                        name: "FK_USER_PLAYS_GAMES_JT_FACTIONS_FACTION_ID",
                        column: x => x.FACTIONID,
                        principalTable: "FACTIONS",
                        principalColumn: "ID",
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
                    ID = table.Column<int>(type: "int", nullable: false),
                    NAME = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAMPIONS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CHAMPIONS_TILES_BT_ID",
                        column: x => x.ID,
                        principalTable: "TILES_BT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ORDERS_BT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    OrderType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERS_BT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ORDERS_BT_TILES_BT_ID",
                        column: x => x.ID,
                        principalTable: "TILES_BT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RUNES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    RuneType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUNES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RUNES_TILES_BT_ID",
                        column: x => x.ID,
                        principalTable: "TILES_BT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GAME_LOGS_BT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GAMEID = table.Column<int>(name: "GAME_ID", type: "int", nullable: false),
                    POSITIONID = table.Column<int>(name: "POSITION_ID", type: "int", nullable: false),
                    USERID = table.Column<int>(name: "USER_ID", type: "int", nullable: false),
                    TILEID = table.Column<int>(name: "TILE_ID", type: "int", nullable: true),
                    FIELDID = table.Column<int>(name: "FIELD_ID", type: "int", nullable: true),
                    DIRECTION = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LOGTYPE = table.Column<string>(name: "LOG_TYPE", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GAME_LOGS_BT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GAME_LOGS_BT_FIELDS_FIELD_ID",
                        column: x => x.FIELDID,
                        principalTable: "FIELDS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_GAME_LOGS_BT_GAMES_GAME_ID",
                        column: x => x.GAMEID,
                        principalTable: "GAMES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GAME_LOGS_BT_POSITIONS_POSITION_ID",
                        column: x => x.POSITIONID,
                        principalTable: "POSITIONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GAME_LOGS_BT_TILES_BT_TILE_ID",
                        column: x => x.TILEID,
                        principalTable: "TILES_BT",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_GAME_LOGS_BT_USERS_USER_ID",
                        column: x => x.USERID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
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
                    DIRECTION = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TILE_OCCUPIES_FIELD_JT", x => new { x.FIELDID, x.TILEID, x.POSITIONID });
                    table.ForeignKey(
                        name: "FK_TILE_OCCUPIES_FIELD_JT_FIELDS_FIELD_ID",
                        column: x => x.FIELDID,
                        principalTable: "FIELDS",
                        principalColumn: "ID",
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BANNERS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    BannerType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HEALTH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANNERS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BANNERS_CHAMPIONS_ID",
                        column: x => x.ID,
                        principalTable: "CHAMPIONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CHAMPION_HAS_ATTACKS_JT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CHAMPIONID = table.Column<int>(name: "CHAMPION_ID", type: "int", nullable: false),
                    ATTACK = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DIRECTION = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    STRENGTH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAMPION_HAS_ATTACKS_JT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CHAMPION_HAS_ATTACKS_JT_CHAMPIONS_CHAMPION_ID",
                        column: x => x.CHAMPIONID,
                        principalTable: "CHAMPIONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CHAMPION_HAS_FEATURES_JT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CHAMPIONID = table.Column<int>(name: "CHAMPION_ID", type: "int", nullable: false),
                    FEATURE = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QUANTITY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAMPION_HAS_FEATURES_JT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CHAMPION_HAS_FEATURES_JT_CHAMPIONS_CHAMPION_ID",
                        column: x => x.CHAMPIONID,
                        principalTable: "CHAMPIONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CHAMPION_HAS_INITIATIVES_JT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CHAMPIONID = table.Column<int>(name: "CHAMPION_ID", type: "int", nullable: false),
                    INITIATIVE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAMPION_HAS_INITIATIVES_JT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CHAMPION_HAS_INITIATIVES_JT_CHAMPIONS_CHAMPION_ID",
                        column: x => x.CHAMPIONID,
                        principalTable: "CHAMPIONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RUNE_HAS_DIRECTIONS_JT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RUNEID = table.Column<int>(name: "RUNE_ID", type: "int", nullable: false),
                    DIRECTION = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUNE_HAS_DIRECTIONS_JT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RUNE_HAS_DIRECTIONS_JT_RUNES_RUNE_ID",
                        column: x => x.RUNEID,
                        principalTable: "RUNES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RUNE_HAS_FEATURES_JT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RUNEID = table.Column<int>(name: "RUNE_ID", type: "int", nullable: false),
                    FEATURE = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUNE_HAS_FEATURES_JT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RUNE_HAS_FEATURES_JT_RUNES_RUNE_ID",
                        column: x => x.RUNEID,
                        principalTable: "RUNES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BANNER_HAS_DIRECTIONS_JT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BANNERID = table.Column<int>(name: "BANNER_ID", type: "int", nullable: false),
                    DIRECTION = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANNER_HAS_DIRECTIONS_JT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BANNER_HAS_DIRECTIONS_JT_BANNERS_BANNER_ID",
                        column: x => x.BANNERID,
                        principalTable: "BANNERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "FACTIONS",
                columns: new[] { "ID", "Color", "NAME" },
                values: new object[,]
                {
                    { 1, "BLUE", "Dragon Empire" },
                    { 2, "RED", "Lord of the Abyss" },
                    { 3, "ORANGE", "Guardians of the Realm" },
                    { 4, "GREEN", "Harbingers of the Forest" }
                });

            migrationBuilder.InsertData(
                table: "ROLES",
                columns: new[] { "ROLE_ID", "DESCRIPTION", "IDENTIFIER" },
                values: new object[] { 1, "Administrator", "Admin" });

            migrationBuilder.InsertData(
                table: "TILES_BT",
                columns: new[] { "ID", "FACTION_ID", "QUANTITY" },
                values: new object[,]
                {
                    { 101, 1, 1 },
                    { 102, 1, 3 },
                    { 103, 1, 4 },
                    { 104, 1, 1 },
                    { 105, 1, 2 },
                    { 106, 1, 1 },
                    { 107, 1, 2 },
                    { 108, 1, 2 },
                    { 109, 1, 3 },
                    { 110, 1, 1 },
                    { 111, 1, 2 },
                    { 112, 1, 1 },
                    { 113, 1, 7 },
                    { 114, 1, 4 },
                    { 115, 1, 1 },
                    { 201, 2, 1 },
                    { 301, 3, 1 },
                    { 401, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "CHAMPIONS",
                columns: new[] { "ID", "NAME" },
                values: new object[,]
                {
                    { 101, "Banner" },
                    { 102, "Pikeman" },
                    { 103, "Knight" },
                    { 104, "Dragon Rider" },
                    { 105, "Swordsman" },
                    { 106, "Landsknecht" },
                    { 107, "Arquebusier" },
                    { 201, "Banner" },
                    { 301, "Banner" },
                    { 401, "Banner" }
                });

            migrationBuilder.InsertData(
                table: "ORDERS_BT",
                columns: new[] { "ID", "OrderType" },
                values: new object[,]
                {
                    { 113, "BATTLE_OR_CHARGE" },
                    { 114, "MOVE" },
                    { 115, "NET" }
                });

            migrationBuilder.InsertData(
                table: "RUNES",
                columns: new[] { "ID", "RuneType" },
                values: new object[,]
                {
                    { 108, "MINOR_ACCELERATION" },
                    { 109, "REGENERATION" },
                    { 110, "AGILITY" },
                    { 111, "STRENGTH" },
                    { 112, "CHARGE" }
                });

            migrationBuilder.InsertData(
                table: "BANNERS",
                columns: new[] { "ID", "BannerType", "HEALTH" },
                values: new object[,]
                {
                    { 101, "STRENGTH", 20 },
                    { 201, "VENOM", 20 },
                    { 301, "TOUGHNESS", 20 },
                    { 401, "MANEUVER", 20 }
                });

            migrationBuilder.InsertData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                columns: new[] { "ID", "ATTACK", "CHAMPION_ID", "DIRECTION", "STRENGTH" },
                values: new object[,]
                {
                    { 101, "MELEE_ATTACK", 101, "NORTH_EAST", 1 },
                    { 102, "MELEE_ATTACK", 101, "EAST", 1 },
                    { 103, "MELEE_ATTACK", 101, "SOUTH_EAST", 1 },
                    { 104, "MELEE_ATTACK", 101, "SOUTH_WEST", 1 },
                    { 105, "MELEE_ATTACK", 101, "WEST", 1 },
                    { 106, "MELEE_ATTACK", 101, "NORTH_WEST", 1 },
                    { 107, "MELEE_ATTACK", 102, "NORTH_EAST", 1 },
                    { 108, "MELEE_ATTACK", 102, "EAST", 1 },
                    { 109, "MELEE_ATTACK", 102, "WEST", 1 },
                    { 110, "MELEE_ATTACK", 102, "NORTH_WEST", 1 },
                    { 111, "MELEE_ATTACK", 103, "NORTH_WEST", 2 },
                    { 112, "ARMOR", 103, "NORTH_EAST", 1 },
                    { 113, "ARMOR", 103, "WEST", 1 },
                    { 114, "ARMOR", 103, "NORTH_WEST", 1 },
                    { 115, "MELEE_ATTACK", 104, "NORTH_WEST", 3 },
                    { 116, "ARMOR", 104, "NORTH_EAST", 1 },
                    { 117, "ARMOR", 104, "WEST", 1 },
                    { 118, "ARMOR", 104, "NORTH_WEST", 1 },
                    { 119, "MELEE_ATTACK", 105, "NORTH_EAST", 1 },
                    { 120, "MELEE_ATTACK", 105, "WEST", 1 },
                    { 121, "MELEE_ATTACK", 106, "NORTH_EAST", 2 },
                    { 122, "MELEE_ATTACK", 106, "EAST", 1 },
                    { 123, "ARMOR", 106, "NORTH_EAST", 1 },
                    { 124, "ARMOR", 106, "EAST", 1 },
                    { 125, "RANGED_ATTACK", 107, "NORTH_WEST", 1 },
                    { 126, "ARMOR", 107, "NORTH_WEST", 1 }
                });

            migrationBuilder.InsertData(
                table: "CHAMPION_HAS_FEATURES_JT",
                columns: new[] { "ID", "CHAMPION_ID", "FEATURE", "QUANTITY" },
                values: new object[,]
                {
                    { 101, 103, "TOUGHNESS", 1 },
                    { 102, 103, "MANEUVER", 1 },
                    { 103, 103, "CAVALRY", 1 },
                    { 104, 104, "MANEUVER", 1 },
                    { 105, 104, "CAVALRY", 1 }
                });

            migrationBuilder.InsertData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                columns: new[] { "ID", "CHAMPION_ID", "INITIATIVE" },
                values: new object[,]
                {
                    { 101, 101, 0 },
                    { 102, 102, 2 },
                    { 103, 103, 1 },
                    { 104, 104, 2 },
                    { 105, 105, 3 },
                    { 106, 106, 2 },
                    { 107, 107, 2 }
                });

            migrationBuilder.InsertData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                columns: new[] { "ID", "DIRECTION", "RUNE_ID" },
                values: new object[,]
                {
                    { 101, "NORTH_EAST", 108 },
                    { 102, "EAST", 108 },
                    { 103, "SOUTH_EAST", 108 },
                    { 104, "SOUTH_WEST", 108 },
                    { 105, "WEST", 108 },
                    { 106, "NORTH_WEST", 108 },
                    { 107, "SOUTH_EAST", 109 },
                    { 108, "SOUTH_WEST", 109 },
                    { 109, "NORTH_EAST", 110 },
                    { 110, "EAST", 110 },
                    { 111, "SOUTH_EAST", 110 },
                    { 112, "SOUTH_WEST", 110 },
                    { 113, "WEST", 110 },
                    { 114, "NORTH_WEST", 110 },
                    { 115, "EAST", 111 },
                    { 116, "SOUTH_EAST", 111 },
                    { 117, "SOUTH_WEST", 111 }
                });

            migrationBuilder.InsertData(
                table: "RUNE_HAS_FEATURES_JT",
                columns: new[] { "ID", "FEATURE", "RUNE_ID" },
                values: new object[] { 101, "BOUNDLESS", 112 });

            migrationBuilder.CreateIndex(
                name: "IX_BANNER_HAS_DIRECTIONS_JT_BANNER_ID",
                table: "BANNER_HAS_DIRECTIONS_JT",
                column: "BANNER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CHAMPION_HAS_ATTACKS_JT_CHAMPION_ID",
                table: "CHAMPION_HAS_ATTACKS_JT",
                column: "CHAMPION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CHAMPION_HAS_FEATURES_JT_CHAMPION_ID",
                table: "CHAMPION_HAS_FEATURES_JT",
                column: "CHAMPION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CHAMPION_HAS_INITIATIVES_JT_CHAMPION_ID",
                table: "CHAMPION_HAS_INITIATIVES_JT",
                column: "CHAMPION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GAME_LOGS_BT_FIELD_ID",
                table: "GAME_LOGS_BT",
                column: "FIELD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GAME_LOGS_BT_GAME_ID",
                table: "GAME_LOGS_BT",
                column: "GAME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GAME_LOGS_BT_POSITION_ID",
                table: "GAME_LOGS_BT",
                column: "POSITION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GAME_LOGS_BT_TILE_ID",
                table: "GAME_LOGS_BT",
                column: "TILE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GAME_LOGS_BT_USER_ID",
                table: "GAME_LOGS_BT",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LOG_ENTRIES_USER_ID",
                table: "LOG_ENTRIES",
                column: "USER_ID");

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
                name: "IX_RUNE_HAS_DIRECTIONS_JT_RUNE_ID",
                table: "RUNE_HAS_DIRECTIONS_JT",
                column: "RUNE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RUNE_HAS_FEATURES_JT_RUNE_ID",
                table: "RUNE_HAS_FEATURES_JT",
                column: "RUNE_ID");

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

            migrationBuilder.CreateIndex(
                name: "IX_USERS_USERNAME",
                table: "USERS",
                column: "USERNAME",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BANNER_HAS_DIRECTIONS_JT");

            migrationBuilder.DropTable(
                name: "CHAMPION_HAS_ATTACKS_JT");

            migrationBuilder.DropTable(
                name: "CHAMPION_HAS_FEATURES_JT");

            migrationBuilder.DropTable(
                name: "CHAMPION_HAS_INITIATIVES_JT");

            migrationBuilder.DropTable(
                name: "GAME_LOGS_BT");

            migrationBuilder.DropTable(
                name: "LOG_ENTRIES");

            migrationBuilder.DropTable(
                name: "ORDERS_BT");

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
                name: "BANNERS");

            migrationBuilder.DropTable(
                name: "RUNES");

            migrationBuilder.DropTable(
                name: "FIELDS");

            migrationBuilder.DropTable(
                name: "POSITIONS");

            migrationBuilder.DropTable(
                name: "ROLES");

            migrationBuilder.DropTable(
                name: "USERS");

            migrationBuilder.DropTable(
                name: "CHAMPIONS");

            migrationBuilder.DropTable(
                name: "GAMES");

            migrationBuilder.DropTable(
                name: "TILES_BT");

            migrationBuilder.DropTable(
                name: "FACTIONS");
        }
    }
}
