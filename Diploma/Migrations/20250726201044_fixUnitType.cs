using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class fixUnitType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_MountMeters_MountMeterAddID",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Units_MountMeterAddID",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "MountMeterAddID",
                table: "Units");

            migrationBuilder.AddColumn<int>(
                name: "UnitAddID",
                table: "MountMeters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MountMeters_UnitAddID",
                table: "MountMeters",
                column: "UnitAddID",
                unique: true,
                filter: "[UnitAddID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_MountMeters_Units_UnitAddID",
                table: "MountMeters",
                column: "UnitAddID",
                principalTable: "Units",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MountMeters_Units_UnitAddID",
                table: "MountMeters");

            migrationBuilder.DropIndex(
                name: "IX_MountMeters_UnitAddID",
                table: "MountMeters");

            migrationBuilder.DropColumn(
                name: "UnitAddID",
                table: "MountMeters");

            migrationBuilder.AddColumn<int>(
                name: "MountMeterAddID",
                table: "Units",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Units_MountMeterAddID",
                table: "Units",
                column: "MountMeterAddID",
                unique: true,
                filter: "[MountMeterAddID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_MountMeters_MountMeterAddID",
                table: "Units",
                column: "MountMeterAddID",
                principalTable: "MountMeters",
                principalColumn: "ID");
        }
    }
}
