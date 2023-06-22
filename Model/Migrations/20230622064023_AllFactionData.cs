using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class AllFactionData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ENDED_AT",
                table: "GAMES",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                columns: new[] { "ID", "ATTACK", "CHAMPION_ID", "DIRECTION", "STRENGTH" },
                values: new object[,]
                {
                    { 201, "MELEE_ATTACK", 201, "NORTH_EAST", 1 },
                    { 202, "MELEE_ATTACK", 201, "EAST", 1 },
                    { 203, "MELEE_ATTACK", 201, "SOUTH_EAST", 1 },
                    { 204, "MELEE_ATTACK", 201, "SOUTH_WEST", 1 },
                    { 205, "MELEE_ATTACK", 201, "WEST", 1 },
                    { 206, "MELEE_ATTACK", 201, "NORTH_WEST", 1 },
                    { 301, "MELEE_ATTACK", 301, "NORTH_EAST", 1 },
                    { 302, "MELEE_ATTACK", 301, "EAST", 1 },
                    { 303, "MELEE_ATTACK", 301, "SOUTH_EAST", 1 },
                    { 304, "MELEE_ATTACK", 301, "SOUTH_WEST", 1 },
                    { 305, "MELEE_ATTACK", 301, "WEST", 1 },
                    { 306, "MELEE_ATTACK", 301, "NORTH_WEST", 1 },
                    { 401, "MELEE_ATTACK", 401, "NORTH_EAST", 1 },
                    { 402, "MELEE_ATTACK", 401, "EAST", 1 },
                    { 403, "MELEE_ATTACK", 401, "SOUTH_EAST", 1 },
                    { 404, "MELEE_ATTACK", 401, "SOUTH_WEST", 1 },
                    { 405, "MELEE_ATTACK", 401, "WEST", 1 },
                    { 406, "MELEE_ATTACK", 401, "NORTH_WEST", 1 }
                });

            migrationBuilder.InsertData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                columns: new[] { "ID", "CHAMPION_ID", "INITIATIVE" },
                values: new object[,]
                {
                    { 201, 201, 0 },
                    { 301, 301, 0 },
                    { 401, 401, 0 }
                });

            migrationBuilder.InsertData(
                table: "TILES_BT",
                columns: new[] { "ID", "FACTION_ID", "QUANTITY" },
                values: new object[,]
                {
                    { 202, 2, 3 },
                    { 203, 2, 3 },
                    { 204, 2, 2 },
                    { 205, 2, 2 },
                    { 206, 2, 1 },
                    { 207, 2, 2 },
                    { 208, 2, 1 },
                    { 209, 2, 2 },
                    { 210, 2, 2 },
                    { 211, 2, 2 },
                    { 212, 2, 2 },
                    { 213, 2, 1 },
                    { 214, 2, 1 },
                    { 215, 2, 6 },
                    { 216, 2, 2 },
                    { 217, 2, 2 },
                    { 302, 3, 3 },
                    { 303, 3, 3 },
                    { 304, 3, 2 },
                    { 305, 3, 2 },
                    { 306, 3, 1 },
                    { 307, 3, 1 },
                    { 308, 3, 1 },
                    { 309, 3, 1 },
                    { 310, 3, 2 },
                    { 311, 3, 1 },
                    { 312, 3, 2 },
                    { 313, 3, 1 },
                    { 314, 3, 5 },
                    { 315, 3, 3 },
                    { 316, 3, 2 },
                    { 317, 3, 1 },
                    { 318, 3, 2 },
                    { 319, 3, 1 },
                    { 402, 4, 2 },
                    { 403, 4, 4 },
                    { 404, 4, 2 },
                    { 405, 4, 1 },
                    { 406, 4, 2 },
                    { 407, 4, 3 },
                    { 408, 4, 1 },
                    { 409, 4, 3 },
                    { 410, 4, 1 },
                    { 411, 4, 2 },
                    { 412, 4, 1 },
                    { 413, 4, 1 },
                    { 414, 4, 6 },
                    { 415, 4, 4 },
                    { 416, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "CHAMPIONS",
                columns: new[] { "ID", "NAME" },
                values: new object[,]
                {
                    { 202, "Mygalomorph" },
                    { 203, "Spike" },
                    { 204, "Chaos" },
                    { 205, "Horror" },
                    { 206, "Nightmare" },
                    { 207, "Wraith" },
                    { 208, "Demon" },
                    { 302, "Axeman" },
                    { 303, "Crossbowman" },
                    { 304, "Veteran" },
                    { 305, "Golem" },
                    { 306, "Combat Platform" },
                    { 307, "Pupil" },
                    { 308, "Wyvern" },
                    { 402, "Morlock" },
                    { 403, "Spark" },
                    { 404, "Hunter" },
                    { 405, "Sorcerer" },
                    { 406, "Herne" },
                    { 407, "Assassin" },
                    { 408, "Wyrm" }
                });

            migrationBuilder.InsertData(
                table: "ORDERS_BT",
                columns: new[] { "ID", "OrderType" },
                values: new object[,]
                {
                    { 215, "BATTLE" },
                    { 216, "MOVE" },
                    { 217, "PUSH" },
                    { 314, "BATTLE" },
                    { 315, "PUSH" },
                    { 316, "FIRE_CONCOCTION" },
                    { 317, "ENTRENCHMENT" },
                    { 318, "ROTATION" },
                    { 319, "FALSE_ORDER" },
                    { 414, "BATTLE" },
                    { 415, "MOVE" },
                    { 416, "PRECISE_SHOT" }
                });

            migrationBuilder.InsertData(
                table: "RUNES",
                columns: new[] { "ID", "RuneType" },
                values: new object[,]
                {
                    { 209, "DISARMAMENT" },
                    { 210, "MINOR_ACCELERATION" },
                    { 211, "TELEPORTATION" },
                    { 212, "STRENGTH" },
                    { 213, "REGENERATION" },
                    { 214, "DOUBLE_ATTACK" },
                    { 309, "AGILITY" },
                    { 310, "REINFORCEMENT" },
                    { 311, "DOUBLE_ATTACK" },
                    { 312, "REGENERATION" },
                    { 313, "PENETRATION" },
                    { 409, "MINOR_ACCELERATION" },
                    { 410, "GREATER_ACCELERATION" },
                    { 411, "REGENERATION" },
                    { 412, "ACCURACY" },
                    { 413, "DOUBLE_ATTACK" }
                });

            migrationBuilder.InsertData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                columns: new[] { "ID", "ATTACK", "CHAMPION_ID", "DIRECTION", "STRENGTH" },
                values: new object[,]
                {
                    { 207, "MELEE_ATTACK", 202, "EAST", 1 },
                    { 208, "MELEE_ATTACK", 202, "SOUTH_WEST", 1 },
                    { 209, "MELEE_ATTACK", 202, "NORTH_WEST", 1 },
                    { 210, "MELEE_ATTACK", 203, "EAST", 1 },
                    { 211, "MELEE_ATTACK", 204, "WEST", 2 },
                    { 212, "ARMOR", 204, "NORTH_WEST", 1 },
                    { 213, "RANGED_ATTACK", 204, "NORTH_EAST", 1 },
                    { 214, "MELEE_ATTACK", 205, "NORTH_WEST", 2 },
                    { 215, "NET", 205, "NORTH_WEST", 1 },
                    { 216, "NET", 206, "EAST", 1 },
                    { 217, "MELEE_ATTACK", 207, "WEST", 1 },
                    { 218, "MELEE_ATTACK", 207, "NORTH_WEST", 1 },
                    { 219, "MELEE_ATTACK", 208, "WEST", 2 },
                    { 220, "MELEE_ATTACK", 208, "NORTH_WEST", 2 },
                    { 221, "MELEE_ATTACK", 208, "NORTH_EAST", 2 },
                    { 307, "MELEE_ATTACK", 302, "NORTH_EAST", 1 },
                    { 308, "MELEE_ATTACK", 302, "WEST", 1 },
                    { 309, "MELEE_ATTACK", 302, "NORTH_WEST", 1 },
                    { 310, "RANGED_ATTACK", 303, "NORTH_WEST", 1 },
                    { 311, "RANGED_ATTACK", 303, "NORTH_WEST", 1 },
                    { 312, "MELEE_ATTACK", 304, "WEST", 1 },
                    { 313, "MELEE_ATTACK", 304, "NORTH_WEST", 2 },
                    { 314, "MELEE_ATTACK", 304, "NORTH_EAST", 1 },
                    { 315, "ARMOR", 304, "NORTH_WEST", 1 },
                    { 316, "ARMOR", 305, "WEST", 1 },
                    { 317, "RANGED_ATTACK", 306, "SOUTH_WEST", 1 },
                    { 318, "RANGED_ATTACK", 306, "WEST", 1 },
                    { 319, "RANGED_ATTACK", 306, "NORTH_WEST", 1 },
                    { 320, "RANGED_ATTACK", 306, "NORTH_EAST", 1 },
                    { 321, "MELEE_ATTACK", 307, "WEST", 1 },
                    { 322, "MELEE_ATTACK", 308, "NORTH_EAST", 1 },
                    { 323, "MELEE_ATTACK", 308, "EAST", 1 },
                    { 324, "MELEE_ATTACK", 308, "SOUTH_EAST", 1 },
                    { 325, "MELEE_ATTACK", 308, "SOUTH_WEST", 1 },
                    { 326, "MELEE_ATTACK", 308, "WEST", 2 },
                    { 327, "MELEE_ATTACK", 308, "NORTH_WEST", 1 },
                    { 407, "KILL_ATTACK", 402, "NORTH_WEST", 1 },
                    { 408, "RANGED_ATTACK", 403, "NORTH_EAST", 1 },
                    { 409, "RANGED_ATTACK", 403, "EAST", 1 },
                    { 410, "RANGED_ATTACK", 404, "NORTH_EAST", 1 },
                    { 411, "RANGED_ATTACK", 405, "NORTH_WEST", 2 },
                    { 412, "MELEE_ATTACK", 406, "WEST", 2 },
                    { 413, "MELEE_ATTACK", 407, "ENTIRE_BOARD", 1 },
                    { 414, "MELEE_ATTACK", 408, "NORTH_EAST", 1 },
                    { 415, "MELEE_ATTACK", 408, "EAST", 1 },
                    { 416, "MELEE_ATTACK", 408, "SOUTH_EAST", 1 },
                    { 417, "MELEE_ATTACK", 408, "SOUTH_WEST", 1 },
                    { 418, "MELEE_ATTACK", 408, "WEST", 1 },
                    { 419, "MELEE_ATTACK", 408, "NORTH_WEST", 1 }
                });

            migrationBuilder.InsertData(
                table: "CHAMPION_HAS_FEATURES_JT",
                columns: new[] { "ID", "CHAMPION_ID", "FEATURE", "QUANTITY" },
                values: new object[,]
                {
                    { 201, 202, "VENOM", 1 },
                    { 202, 206, "TELEPORT", 1 },
                    { 203, 207, "MANEUVER", 1 },
                    { 204, 208, "TRANSFORMATION", 1 },
                    { 301, 303, "TOUGHNESS", 1 },
                    { 302, 305, "MANEUVER", 2 },
                    { 303, 307, "MANEUVER", 1 },
                    { 304, 308, "TOUGHNESS", 1 },
                    { 401, 406, "MANEUVER", 1 },
                    { 402, 407, "INFINITY_ATTACK", 1 },
                    { 403, 408, "MANEUVER", 1 }
                });

            migrationBuilder.InsertData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                columns: new[] { "ID", "CHAMPION_ID", "INITIATIVE" },
                values: new object[,]
                {
                    { 202, 202, 3 },
                    { 203, 203, 1 },
                    { 204, 204, 2 },
                    { 205, 205, 0 },
                    { 206, 207, 2 },
                    { 207, 208, 1 },
                    { 302, 302, 2 },
                    { 303, 302, 1 },
                    { 304, 303, 2 },
                    { 305, 304, 2 },
                    { 306, 306, 3 },
                    { 307, 307, 3 },
                    { 308, 308, 2 },
                    { 402, 402, -1 },
                    { 403, 403, 2 },
                    { 404, 404, 3 },
                    { 405, 404, 0 },
                    { 406, 405, 2 },
                    { 407, 406, 2 },
                    { 408, 407, 3 },
                    { 409, 408, 2 },
                    { 410, 408, 1 }
                });

            migrationBuilder.InsertData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                columns: new[] { "ID", "DIRECTION", "RUNE_ID" },
                values: new object[,]
                {
                    { 201, "SOUTH_EAST", 209 },
                    { 202, "SOUTH_WEST", 209 },
                    { 203, "EAST", 210 },
                    { 204, "SOUTH_EAST", 210 },
                    { 205, "SOUTH_WEST", 210 },
                    { 206, "NORTH_WEST", 210 },
                    { 207, "SOUTH_EAST", 211 },
                    { 208, "SOUTH_EAST", 212 },
                    { 209, "SOUTH_WEST", 212 },
                    { 210, "SOUTH_EAST", 213 },
                    { 211, "SOUTH_EAST", 214 },
                    { 212, "SOUTH_WEST", 214 },
                    { 301, "SOUTH_EAST", 309 },
                    { 302, "SOUTH_WEST", 309 },
                    { 303, "SOUTH_EAST", 310 },
                    { 304, "SOUTH_WEST", 310 },
                    { 305, "WEST", 310 },
                    { 306, "NORTH_EAST", 311 },
                    { 307, "EAST", 311 },
                    { 308, "SOUTH_EAST", 311 },
                    { 309, "SOUTH_WEST", 311 },
                    { 310, "WEST", 311 },
                    { 311, "NORTH_WEST", 311 },
                    { 312, "SOUTH_EAST", 312 },
                    { 313, "SOUTH_WEST", 312 },
                    { 314, "SOUTH_EAST", 313 },
                    { 401, "NORTH_EAST", 409 },
                    { 402, "EAST", 409 },
                    { 403, "SOUTH_EAST", 409 },
                    { 404, "SOUTH_WEST", 409 },
                    { 405, "WEST", 409 },
                    { 406, "NORTH_WEST", 409 },
                    { 407, "EAST", 410 },
                    { 408, "SOUTH_EAST", 410 },
                    { 409, "SOUTH_WEST", 410 },
                    { 410, "NORTH_EAST", 411 },
                    { 411, "SOUTH_EAST", 411 },
                    { 412, "NORTH_EAST", 412 },
                    { 413, "EAST", 412 },
                    { 414, "SOUTH_EAST", 412 },
                    { 415, "SOUTH_WEST", 412 },
                    { 416, "WEST", 412 },
                    { 417, "NORTH_WEST", 412 },
                    { 418, "NORTH_EAST", 413 },
                    { 419, "EAST", 413 },
                    { 420, "SOUTH_EAST", 413 },
                    { 421, "SOUTH_WEST", 413 },
                    { 422, "WEST", 413 },
                    { 423, "NORTH_WEST", 413 }
                });

            migrationBuilder.InsertData(
                table: "RUNE_HAS_FEATURES_JT",
                columns: new[] { "ID", "FEATURE", "RUNE_ID" },
                values: new object[,]
                {
                    { 201, "TOUGHNESS", 212 },
                    { 301, "ROTATION", 309 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_ATTACKS_JT",
                keyColumn: "ID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_FEATURES_JT",
                keyColumn: "ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_FEATURES_JT",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_FEATURES_JT",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_FEATURES_JT",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_FEATURES_JT",
                keyColumn: "ID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_FEATURES_JT",
                keyColumn: "ID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_FEATURES_JT",
                keyColumn: "ID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_FEATURES_JT",
                keyColumn: "ID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_FEATURES_JT",
                keyColumn: "ID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_FEATURES_JT",
                keyColumn: "ID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_FEATURES_JT",
                keyColumn: "ID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "CHAMPION_HAS_INITIATIVES_JT",
                keyColumn: "ID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ORDERS_BT",
                keyColumn: "ID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ORDERS_BT",
                keyColumn: "ID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ORDERS_BT",
                keyColumn: "ID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ORDERS_BT",
                keyColumn: "ID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ORDERS_BT",
                keyColumn: "ID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ORDERS_BT",
                keyColumn: "ID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ORDERS_BT",
                keyColumn: "ID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ORDERS_BT",
                keyColumn: "ID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ORDERS_BT",
                keyColumn: "ID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ORDERS_BT",
                keyColumn: "ID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ORDERS_BT",
                keyColumn: "ID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ORDERS_BT",
                keyColumn: "ID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_DIRECTIONS_JT",
                keyColumn: "ID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_FEATURES_JT",
                keyColumn: "ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "RUNE_HAS_FEATURES_JT",
                keyColumn: "ID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "CHAMPIONS",
                keyColumn: "ID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "RUNES",
                keyColumn: "ID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "TILES_BT",
                keyColumn: "ID",
                keyValue: 413);

            migrationBuilder.DropColumn(
                name: "ENDED_AT",
                table: "GAMES");
        }
    }
}
