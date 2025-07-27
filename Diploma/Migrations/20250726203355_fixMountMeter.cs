using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class fixMountMeter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MountMeters_Meters_MeterID",
                table: "MountMeters");

            migrationBuilder.DropIndex(
                name: "IX_MountMeters_MeterID",
                table: "MountMeters");

            migrationBuilder.RenameColumn(
                name: "MeterID",
                table: "MountMeters",
                newName: "MeterAddID");

            migrationBuilder.CreateIndex(
                name: "IX_MountMeters_MeterAddID",
                table: "MountMeters",
                column: "MeterAddID",
                unique: true,
                filter: "[MeterAddID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_MountMeters_Meters_MeterAddID",
                table: "MountMeters",
                column: "MeterAddID",
                principalTable: "Meters",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MountMeters_Meters_MeterAddID",
                table: "MountMeters");

            migrationBuilder.DropIndex(
                name: "IX_MountMeters_MeterAddID",
                table: "MountMeters");

            migrationBuilder.RenameColumn(
                name: "MeterAddID",
                table: "MountMeters",
                newName: "MeterID");

            migrationBuilder.CreateIndex(
                name: "IX_MountMeters_MeterID",
                table: "MountMeters",
                column: "MeterID",
                unique: true,
                filter: "[MeterID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_MountMeters_Meters_MeterID",
                table: "MountMeters",
                column: "MeterID",
                principalTable: "Meters",
                principalColumn: "ID");
        }
    }
}
