using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class AddFixDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MountMeters_Meters_MeterAddID",
                table: "MountMeters");

            migrationBuilder.DropForeignKey(
                name: "FK_Points_MountTrasformers_MountTrasformerID",
                table: "Points");

            migrationBuilder.DropForeignKey(
                name: "FK_ReadingAdds_MountMeters_MountMeterAddID",
                table: "ReadingAdds");

            migrationBuilder.DropForeignKey(
                name: "FK_Transformers_MountTrasformers_MountTrasformerID",
                table: "Transformers");

            migrationBuilder.DropTable(
                name: "PointAddTransformerAdd");

            migrationBuilder.RenameColumn(
                name: "MountTrasformerID",
                table: "Transformers",
                newName: "MountTrasformersID");

            migrationBuilder.RenameIndex(
                name: "IX_Transformers_MountTrasformerID",
                table: "Transformers",
                newName: "IX_Transformers_MountTrasformersID");

            migrationBuilder.RenameColumn(
                name: "MountTrasformerID",
                table: "Points",
                newName: "MountTrasformersID");

            migrationBuilder.RenameIndex(
                name: "IX_Points_MountTrasformerID",
                table: "Points",
                newName: "IX_Points_MountTrasformersID");

            migrationBuilder.AddForeignKey(
                name: "FK_MountMeters_Meters_MeterAddID",
                table: "MountMeters",
                column: "MeterAddID",
                principalTable: "Meters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Points_MountTrasformers_MountTrasformersID",
                table: "Points",
                column: "MountTrasformersID",
                principalTable: "MountTrasformers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReadingAdds_MountMeters_MountMeterAddID",
                table: "ReadingAdds",
                column: "MountMeterAddID",
                principalTable: "MountMeters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transformers_MountTrasformers_MountTrasformersID",
                table: "Transformers",
                column: "MountTrasformersID",
                principalTable: "MountTrasformers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MountMeters_Meters_MeterAddID",
                table: "MountMeters");

            migrationBuilder.DropForeignKey(
                name: "FK_Points_MountTrasformers_MountTrasformersID",
                table: "Points");

            migrationBuilder.DropForeignKey(
                name: "FK_ReadingAdds_MountMeters_MountMeterAddID",
                table: "ReadingAdds");

            migrationBuilder.DropForeignKey(
                name: "FK_Transformers_MountTrasformers_MountTrasformersID",
                table: "Transformers");

            migrationBuilder.RenameColumn(
                name: "MountTrasformersID",
                table: "Transformers",
                newName: "MountTrasformerID");

            migrationBuilder.RenameIndex(
                name: "IX_Transformers_MountTrasformersID",
                table: "Transformers",
                newName: "IX_Transformers_MountTrasformerID");

            migrationBuilder.RenameColumn(
                name: "MountTrasformersID",
                table: "Points",
                newName: "MountTrasformerID");

            migrationBuilder.RenameIndex(
                name: "IX_Points_MountTrasformersID",
                table: "Points",
                newName: "IX_Points_MountTrasformerID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_MountMeters_Meters_MeterAddID",
                table: "MountMeters",
                column: "MeterAddID",
                principalTable: "Meters",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_MountTrasformers_MountTrasformerID",
                table: "Points",
                column: "MountTrasformerID",
                principalTable: "MountTrasformers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReadingAdds_MountMeters_MountMeterAddID",
                table: "ReadingAdds",
                column: "MountMeterAddID",
                principalTable: "MountMeters",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transformers_MountTrasformers_MountTrasformerID",
                table: "Transformers",
                column: "MountTrasformerID",
                principalTable: "MountTrasformers",
                principalColumn: "ID");
        }
    }
}
