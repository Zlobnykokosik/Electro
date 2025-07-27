using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class fixAbonentAddNavs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abonents_Contracts_ContractAddID",
                table: "Abonents");

            migrationBuilder.DropForeignKey(
                name: "FK_Abonents_ControllersAdds_ControllersAddID",
                table: "Abonents");

            migrationBuilder.DropColumn(
                name: "ContractNumber",
                table: "Abonents");

            migrationBuilder.RenameColumn(
                name: "ContractAddID",
                table: "Abonents",
                newName: "ContractAddId");

            migrationBuilder.RenameColumn(
                name: "ControllerNumber",
                table: "Abonents",
                newName: "ControllerAddId");

            migrationBuilder.RenameIndex(
                name: "IX_Abonents_ContractAddID",
                table: "Abonents",
                newName: "IX_Abonents_ContractAddId");

            migrationBuilder.AlterColumn<int>(
                name: "ControllersAddID",
                table: "Abonents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ContractAddId",
                table: "Abonents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Abonents_Contracts_ContractAddId",
                table: "Abonents",
                column: "ContractAddId",
                principalTable: "Contracts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abonents_ControllersAdds_ControllersAddID",
                table: "Abonents",
                column: "ControllersAddID",
                principalTable: "ControllersAdds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abonents_Contracts_ContractAddId",
                table: "Abonents");

            migrationBuilder.DropForeignKey(
                name: "FK_Abonents_ControllersAdds_ControllersAddID",
                table: "Abonents");

            migrationBuilder.RenameColumn(
                name: "ContractAddId",
                table: "Abonents",
                newName: "ContractAddID");

            migrationBuilder.RenameColumn(
                name: "ControllerAddId",
                table: "Abonents",
                newName: "ControllerNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Abonents_ContractAddId",
                table: "Abonents",
                newName: "IX_Abonents_ContractAddID");

            migrationBuilder.AlterColumn<int>(
                name: "ControllersAddID",
                table: "Abonents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ContractAddID",
                table: "Abonents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ContractNumber",
                table: "Abonents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Abonents_Contracts_ContractAddID",
                table: "Abonents",
                column: "ContractAddID",
                principalTable: "Contracts",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Abonents_ControllersAdds_ControllersAddID",
                table: "Abonents",
                column: "ControllersAddID",
                principalTable: "ControllersAdds",
                principalColumn: "ID");
        }
    }
}
