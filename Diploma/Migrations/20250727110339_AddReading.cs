using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class AddReading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReadingAdds",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<long>(type: "bigint", nullable: false),
                    ReadingDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Reading = table.Column<float>(type: "real", nullable: false),
                    MountMeterAddID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingAdds", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReadingAdds_MountMeters_MountMeterAddID",
                        column: x => x.MountMeterAddID,
                        principalTable: "MountMeters",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReadingAdds_MountMeterAddID",
                table: "ReadingAdds",
                column: "MountMeterAddID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReadingAdds");
        }
    }
}
