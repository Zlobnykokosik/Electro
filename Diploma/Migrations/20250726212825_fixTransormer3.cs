using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class fixTransormer3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transformers_Points_PointAddID",
                table: "Transformers");

            migrationBuilder.DropForeignKey(
                name: "FK_Transformers_Transformers_TransformerAddID",
                table: "Transformers");

            migrationBuilder.DropIndex(
                name: "IX_Transformers_PointAddID",
                table: "Transformers");

            migrationBuilder.DropIndex(
                name: "IX_Transformers_TransformerAddID",
                table: "Transformers");

            migrationBuilder.DropColumn(
                name: "TransformerAddID",
                table: "Transformers");

            migrationBuilder.RenameColumn(
                name: "PointAddID",
                table: "Transformers",
                newName: "PointAddId");

            migrationBuilder.AddColumn<int>(
                name: "TransformerAddID",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PointAddTransformerAdd",
                columns: table => new
                {
                    PointAddsID = table.Column<int>(type: "int", nullable: false),
                    TransformersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointAddTransformerAdd", x => new { x.PointAddsID, x.TransformersID });
                    table.ForeignKey(
                        name: "FK_PointAddTransformerAdd_Points_PointAddsID",
                        column: x => x.PointAddsID,
                        principalTable: "Points",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PointAddTransformerAdd_Transformers_TransformersID",
                        column: x => x.TransformersID,
                        principalTable: "Transformers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PointAddTransformerAdd_TransformersID",
                table: "PointAddTransformerAdd",
                column: "TransformersID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PointAddTransformerAdd");

            migrationBuilder.DropColumn(
                name: "TransformerAddID",
                table: "Points");

            migrationBuilder.RenameColumn(
                name: "PointAddId",
                table: "Transformers",
                newName: "PointAddID");

            migrationBuilder.AddColumn<int>(
                name: "TransformerAddID",
                table: "Transformers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transformers_PointAddID",
                table: "Transformers",
                column: "PointAddID");

            migrationBuilder.CreateIndex(
                name: "IX_Transformers_TransformerAddID",
                table: "Transformers",
                column: "TransformerAddID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transformers_Points_PointAddID",
                table: "Transformers",
                column: "PointAddID",
                principalTable: "Points",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transformers_Transformers_TransformerAddID",
                table: "Transformers",
                column: "TransformerAddID",
                principalTable: "Transformers",
                principalColumn: "ID");
        }
    }
}
