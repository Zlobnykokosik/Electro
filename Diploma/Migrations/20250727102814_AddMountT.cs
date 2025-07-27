using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class AddMountT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MountTrasformerID",
                table: "Transformers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MountTrasformerID",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MountTrasformers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransformerAddId = table.Column<int>(type: "int", nullable: true),
                    PointAddId = table.Column<int>(type: "int", nullable: true),
                    SetDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsClosed = table.Column<bool>(type: "bit", nullable: false),
                    CloseDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MountTrasformers", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transformers_MountTrasformerID",
                table: "Transformers",
                column: "MountTrasformerID");

            migrationBuilder.CreateIndex(
                name: "IX_Transformers_Name",
                table: "Transformers",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Points_MountTrasformerID",
                table: "Points",
                column: "MountTrasformerID");

            migrationBuilder.CreateIndex(
                name: "IX_Points_Number",
                table: "Points",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ControllersAdds_ContollerNum",
                table: "ControllersAdds",
                column: "ContollerNum",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractNumber",
                table: "Contracts",
                column: "ContractNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Abonents_AbonentNumber_ContractAddId",
                table: "Abonents",
                columns: new[] { "AbonentNumber", "ContractAddId" },
                unique: true,
                filter: "[ContractAddId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_MountTrasformers_MountTrasformerID",
                table: "Points",
                column: "MountTrasformerID",
                principalTable: "MountTrasformers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transformers_MountTrasformers_MountTrasformerID",
                table: "Transformers",
                column: "MountTrasformerID",
                principalTable: "MountTrasformers",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Points_MountTrasformers_MountTrasformerID",
                table: "Points");

            migrationBuilder.DropForeignKey(
                name: "FK_Transformers_MountTrasformers_MountTrasformerID",
                table: "Transformers");

            migrationBuilder.DropTable(
                name: "MountTrasformers");

            migrationBuilder.DropIndex(
                name: "IX_Transformers_MountTrasformerID",
                table: "Transformers");

            migrationBuilder.DropIndex(
                name: "IX_Transformers_Name",
                table: "Transformers");

            migrationBuilder.DropIndex(
                name: "IX_Points_MountTrasformerID",
                table: "Points");

            migrationBuilder.DropIndex(
                name: "IX_Points_Number",
                table: "Points");

            migrationBuilder.DropIndex(
                name: "IX_ControllersAdds_ContollerNum",
                table: "ControllersAdds");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ContractNumber",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Abonents_AbonentNumber_ContractAddId",
                table: "Abonents");

            migrationBuilder.DropColumn(
                name: "MountTrasformerID",
                table: "Transformers");

            migrationBuilder.DropColumn(
                name: "MountTrasformerID",
                table: "Points");
        }
    }
}
