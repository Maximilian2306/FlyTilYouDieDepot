using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlyTilYouDieDepot.Migrations
{
    /// <inheritdoc />
    public partial class M6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planes_Orders_Name",
                table: "Planes");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Planes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_ImagePath",
                table: "Planes",
                column: "ImagePath",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_Orders_ImagePath",
                table: "Planes",
                column: "ImagePath",
                principalTable: "Orders",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planes_Orders_ImagePath",
                table: "Planes");

            migrationBuilder.DropIndex(
                name: "IX_Planes_ImagePath",
                table: "Planes");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Planes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_Orders_Name",
                table: "Planes",
                column: "Name",
                principalTable: "Orders",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
