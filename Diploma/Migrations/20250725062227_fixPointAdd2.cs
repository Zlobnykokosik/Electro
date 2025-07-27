using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class fixPointAdd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Points_Abonents_AbonentAddID",
                table: "Points");

            migrationBuilder.DropForeignKey(
                name: "FK_Points_Contracts_ContractAddID",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "AbonentId",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Points");

            migrationBuilder.RenameColumn(
                name: "ContractAddID",
                table: "Points",
                newName: "ContractAddId");

            migrationBuilder.RenameColumn(
                name: "AbonentAddID",
                table: "Points",
                newName: "AbonentAddId");

            migrationBuilder.RenameIndex(
                name: "IX_Points_ContractAddID",
                table: "Points",
                newName: "IX_Points_ContractAddId");

            migrationBuilder.RenameIndex(
                name: "IX_Points_AbonentAddID",
                table: "Points",
                newName: "IX_Points_AbonentAddId");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_Abonents_AbonentAddId",
                table: "Points",
                column: "AbonentAddId",
                principalTable: "Abonents",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_Contracts_ContractAddId",
                table: "Points",
                column: "ContractAddId",
                principalTable: "Contracts",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Points_Abonents_AbonentAddId",
                table: "Points");

            migrationBuilder.DropForeignKey(
                name: "FK_Points_Contracts_ContractAddId",
                table: "Points");

            migrationBuilder.RenameColumn(
                name: "ContractAddId",
                table: "Points",
                newName: "ContractAddID");

            migrationBuilder.RenameColumn(
                name: "AbonentAddId",
                table: "Points",
                newName: "AbonentAddID");

            migrationBuilder.RenameIndex(
                name: "IX_Points_ContractAddId",
                table: "Points",
                newName: "IX_Points_ContractAddID");

            migrationBuilder.RenameIndex(
                name: "IX_Points_AbonentAddId",
                table: "Points",
                newName: "IX_Points_AbonentAddID");

            migrationBuilder.AddColumn<int>(
                name: "AbonentId",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Points_Abonents_AbonentAddID",
                table: "Points",
                column: "AbonentAddID",
                principalTable: "Abonents",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_Contracts_ContractAddID",
                table: "Points",
                column: "ContractAddID",
                principalTable: "Contracts",
                principalColumn: "ID");
        }
    }
}
