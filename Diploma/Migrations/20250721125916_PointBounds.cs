using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class PointBounds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PointsBounds",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointIDBase = table.Column<int>(type: "int", nullable: false),
                    PointIDMinus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointsBounds", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PointsBounds_Points_PointIDBase",
                        column: x => x.PointIDBase,
                        principalTable: "Points",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PointsBounds_Points_PointIDMinus",
                        column: x => x.PointIDMinus,
                        principalTable: "Points",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PointsBounds_PointIDBase",
                table: "PointsBounds",
                column: "PointIDBase");

            migrationBuilder.CreateIndex(
                name: "IX_PointsBounds_PointIDMinus",
                table: "PointsBounds",
                column: "PointIDMinus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PointsBounds");
        }
    }
}
