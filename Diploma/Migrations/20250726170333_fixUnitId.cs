using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class fixUnitId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MountMeters_MountMetersShortCalc_MountMeterCalcID",
                table: "MountMeters");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_MountMeters_MountMeterID",
                table: "Units");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_UnitsShortCalc_UnitCalcID",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Units_MountMeterID",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "MountMeterID",
                table: "Units");

            migrationBuilder.RenameColumn(
                name: "UnitCalcID",
                table: "Units",
                newName: "UnitSCID");

            migrationBuilder.RenameIndex(
                name: "IX_Units_UnitCalcID",
                table: "Units",
                newName: "IX_Units_UnitSCID");

            migrationBuilder.RenameColumn(
                name: "MountMeterCalcID",
                table: "MountMeters",
                newName: "MountMeterSCID");

            migrationBuilder.RenameIndex(
                name: "IX_MountMeters_MountMeterCalcID",
                table: "MountMeters",
                newName: "IX_MountMeters_MountMeterSCID");

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
                name: "FK_MountMeters_MountMetersShortCalc_MountMeterSCID",
                table: "MountMeters",
                column: "MountMeterSCID",
                principalTable: "MountMetersShortCalc",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_MountMeters_MountMeterAddID",
                table: "Units",
                column: "MountMeterAddID",
                principalTable: "MountMeters",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_UnitsShortCalc_UnitSCID",
                table: "Units",
                column: "UnitSCID",
                principalTable: "UnitsShortCalc",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MountMeters_MountMetersShortCalc_MountMeterSCID",
                table: "MountMeters");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_MountMeters_MountMeterAddID",
                table: "Units");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_UnitsShortCalc_UnitSCID",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Units_MountMeterAddID",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "MountMeterAddID",
                table: "Units");

            migrationBuilder.RenameColumn(
                name: "UnitSCID",
                table: "Units",
                newName: "UnitCalcID");

            migrationBuilder.RenameIndex(
                name: "IX_Units_UnitSCID",
                table: "Units",
                newName: "IX_Units_UnitCalcID");

            migrationBuilder.RenameColumn(
                name: "MountMeterSCID",
                table: "MountMeters",
                newName: "MountMeterCalcID");

            migrationBuilder.RenameIndex(
                name: "IX_MountMeters_MountMeterSCID",
                table: "MountMeters",
                newName: "IX_MountMeters_MountMeterCalcID");

            migrationBuilder.AddColumn<int>(
                name: "MountMeterID",
                table: "Units",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Units_MountMeterID",
                table: "Units",
                column: "MountMeterID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MountMeters_MountMetersShortCalc_MountMeterCalcID",
                table: "MountMeters",
                column: "MountMeterCalcID",
                principalTable: "MountMetersShortCalc",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_MountMeters_MountMeterID",
                table: "Units",
                column: "MountMeterID",
                principalTable: "MountMeters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_UnitsShortCalc_UnitCalcID",
                table: "Units",
                column: "UnitCalcID",
                principalTable: "UnitsShortCalc",
                principalColumn: "ID");
        }
    }
}
