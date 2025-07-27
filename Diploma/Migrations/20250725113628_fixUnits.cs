using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class fixUnits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_Points_PointAddID",
                table: "Units");

            migrationBuilder.RenameColumn(
                name: "PointAddID",
                table: "Units",
                newName: "PointAddId");

            migrationBuilder.RenameIndex(
                name: "IX_Units_PointAddID",
                table: "Units",
                newName: "IX_Units_PointAddId");

            migrationBuilder.AlterColumn<bool>(
                name: "Type",
                table: "Units",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Points_PointAddId",
                table: "Units",
                column: "PointAddId",
                principalTable: "Points",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_Points_PointAddId",
                table: "Units");

            migrationBuilder.RenameColumn(
                name: "PointAddId",
                table: "Units",
                newName: "PointAddID");

            migrationBuilder.RenameIndex(
                name: "IX_Units_PointAddId",
                table: "Units",
                newName: "IX_Units_PointAddID");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Units",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Points_PointAddID",
                table: "Units",
                column: "PointAddID",
                principalTable: "Points",
                principalColumn: "ID");
        }
    }
}
