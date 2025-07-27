using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class AddConsumtion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsumptionAdds",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<long>(type: "bigint", nullable: false),
                    ConsumptionDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Consumption = table.Column<float>(type: "real", nullable: false),
                    PointAddID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumptionAdds", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ConsumptionAdds_Points_PointAddID",
                        column: x => x.PointAddID,
                        principalTable: "Points",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionAdds_ConsumptionDate_PointAddID",
                table: "ConsumptionAdds",
                columns: new[] { "ConsumptionDate", "PointAddID" },
                unique: true,
                filter: "[PointAddID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionAdds_PointAddID",
                table: "ConsumptionAdds",
                column: "PointAddID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumptionAdds");
        }
    }
}
