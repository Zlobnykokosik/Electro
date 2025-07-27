using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class fixAbonentAddNavs2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abonents_ControllersAdds_ControllersAddID",
                table: "Abonents");

            migrationBuilder.AlterColumn<int>(
                name: "ControllersAddID",
                table: "Abonents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Abonents_ControllersAdds_ControllersAddID",
                table: "Abonents",
                column: "ControllersAddID",
                principalTable: "ControllersAdds",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abonents_ControllersAdds_ControllersAddID",
                table: "Abonents");

            migrationBuilder.AlterColumn<int>(
                name: "ControllersAddID",
                table: "Abonents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Abonents_ControllersAdds_ControllersAddID",
                table: "Abonents",
                column: "ControllersAddID",
                principalTable: "ControllersAdds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
