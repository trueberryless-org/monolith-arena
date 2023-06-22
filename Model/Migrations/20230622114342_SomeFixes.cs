using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class SomeFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORDERS_BT_TILES_BT_ID",
                table: "ORDERS_BT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ORDERS_BT",
                table: "ORDERS_BT");

            migrationBuilder.RenameTable(
                name: "ORDERS_BT",
                newName: "ORDERS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ORDERS",
                table: "ORDERS",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ORDERS_TILES_BT_ID",
                table: "ORDERS",
                column: "ID",
                principalTable: "TILES_BT",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORDERS_TILES_BT_ID",
                table: "ORDERS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ORDERS",
                table: "ORDERS");

            migrationBuilder.RenameTable(
                name: "ORDERS",
                newName: "ORDERS_BT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ORDERS_BT",
                table: "ORDERS_BT",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ORDERS_BT_TILES_BT_ID",
                table: "ORDERS_BT",
                column: "ID",
                principalTable: "TILES_BT",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
