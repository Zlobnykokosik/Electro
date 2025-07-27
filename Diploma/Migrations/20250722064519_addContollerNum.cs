using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class addContollerNum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ControllerNumber",
                table: "AbonentsArhive",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ControllerNumber",
                table: "Abonents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ControllerNumber",
                table: "AbonentsArhive");

            migrationBuilder.DropColumn(
                name: "ControllerNumber",
                table: "Abonents");
        }
    }
}
