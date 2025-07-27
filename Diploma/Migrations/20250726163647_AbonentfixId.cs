using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class AbonentfixId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abonents_Contracts_ContractAddId",
                table: "Abonents");

            migrationBuilder.DropForeignKey(
                name: "FK_Abonents_ControllersAdds_ControllersAddID",
                table: "Abonents");

            migrationBuilder.DropForeignKey(
                name: "FK_MountMeters_Meters_MeterID",
                table: "MountMeters");

            migrationBuilder.DropIndex(
                name: "IX_MountMeters_MeterID",
                table: "MountMeters");

            migrationBuilder.DropColumn(
                name: "ControllerAddId",
                table: "Abonents");

            migrationBuilder.RenameColumn(
                name: "ControllersAddID",
                table: "Abonents",
                newName: "ControllersAddId");

            migrationBuilder.RenameIndex(
                name: "IX_Abonents_ControllersAddID",
                table: "Abonents",
                newName: "IX_Abonents_ControllersAddId");

            migrationBuilder.AlterColumn<int>(
                name: "MeterID",
                table: "MountMeters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ContractAddId",
                table: "Abonents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_MountMeters_MeterID",
                table: "MountMeters",
                column: "MeterID",
                unique: true,
                filter: "[MeterID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Abonents_Contracts_ContractAddId",
                table: "Abonents",
                column: "ContractAddId",
                principalTable: "Contracts",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Abonents_ControllersAdds_ControllersAddId",
                table: "Abonents",
                column: "ControllersAddId",
                principalTable: "ControllersAdds",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MountMeters_Meters_MeterID",
                table: "MountMeters",
                column: "MeterID",
                principalTable: "Meters",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abonents_Contracts_ContractAddId",
                table: "Abonents");

            migrationBuilder.DropForeignKey(
                name: "FK_Abonents_ControllersAdds_ControllersAddId",
                table: "Abonents");

            migrationBuilder.DropForeignKey(
                name: "FK_MountMeters_Meters_MeterID",
                table: "MountMeters");

            migrationBuilder.DropIndex(
                name: "IX_MountMeters_MeterID",
                table: "MountMeters");

            migrationBuilder.RenameColumn(
                name: "ControllersAddId",
                table: "Abonents",
                newName: "ControllersAddID");

            migrationBuilder.RenameIndex(
                name: "IX_Abonents_ControllersAddId",
                table: "Abonents",
                newName: "IX_Abonents_ControllersAddID");

            migrationBuilder.AlterColumn<int>(
                name: "MeterID",
                table: "MountMeters",
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

            migrationBuilder.AddColumn<int>(
                name: "ControllerAddId",
                table: "Abonents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MountMeters_MeterID",
                table: "MountMeters",
                column: "MeterID",
                unique: true);

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
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MountMeters_Meters_MeterID",
                table: "MountMeters",
                column: "MeterID",
                principalTable: "Meters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
