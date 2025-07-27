using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class fixPointAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Version",
                table: "Points",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AddColumn<int>(
                name: "AbonentId",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractAddID",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractId",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Points_ContractAddID",
                table: "Points",
                column: "ContractAddID");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_Contracts_ContractAddID",
                table: "Points",
                column: "ContractAddID",
                principalTable: "Contracts",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Points_Contracts_ContractAddID",
                table: "Points");

            migrationBuilder.DropIndex(
                name: "IX_Points_ContractAddID",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "AbonentId",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "ContractAddID",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "ContractId",
                table: "Points");

            migrationBuilder.AlterColumn<short>(
                name: "Version",
                table: "Points",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
