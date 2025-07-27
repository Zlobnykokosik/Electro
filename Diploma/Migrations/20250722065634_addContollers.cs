using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class addContollers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ControllerNumber",
                table: "AbonentsArhive");

            migrationBuilder.DropColumn(
                name: "ControllerNumber",
                table: "Abonents");

            migrationBuilder.CreateTable(
                name: "ControllersAdd",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContollerNum = table.Column<int>(type: "int", nullable: false),
                    FIO = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AbonentAddID = table.Column<int>(type: "int", nullable: true),
                    AbonentArhiveID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControllersAdd", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ControllersAdd_AbonentsArhive_AbonentArhiveID",
                        column: x => x.AbonentArhiveID,
                        principalTable: "AbonentsArhive",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ControllersAdd_Abonents_AbonentAddID",
                        column: x => x.AbonentAddID,
                        principalTable: "Abonents",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ControllersAdd_AbonentAddID",
                table: "ControllersAdd",
                column: "AbonentAddID");

            migrationBuilder.CreateIndex(
                name: "IX_ControllersAdd_AbonentArhiveID",
                table: "ControllersAdd",
                column: "AbonentArhiveID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ControllersAdd");

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
    }
}
