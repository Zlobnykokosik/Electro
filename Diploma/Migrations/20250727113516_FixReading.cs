using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class FixReading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ReadingAdds_ReadingDate_MountMeterAddID",
                table: "ReadingAdds",
                columns: new[] { "ReadingDate", "MountMeterAddID" },
                unique: true,
                filter: "[MountMeterAddID] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ReadingAdds_ReadingDate_MountMeterAddID",
                table: "ReadingAdds");
        }
    }
}
