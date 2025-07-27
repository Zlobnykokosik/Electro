using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class AddFixContractLinks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Points_Contracts_ContractAddId",
                table: "Points");

            migrationBuilder.DropIndex(
                name: "IX_Points_ContractAddId",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "ContractAddId",
                table: "Points");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContractAddId",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Points_ContractAddId",
                table: "Points",
                column: "ContractAddId");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_Contracts_ContractAddId",
                table: "Points",
                column: "ContractAddId",
                principalTable: "Contracts",
                principalColumn: "ID");
        }
    }
}
