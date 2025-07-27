using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class fixContollers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ControllersAdds_AbonentsArhive_AbonentArhiveID",
                table: "ControllersAdds");

            migrationBuilder.DropForeignKey(
                name: "FK_ControllersAdds_Abonents_AbonentAddID",
                table: "ControllersAdds");

            migrationBuilder.DropIndex(
                name: "IX_ControllersAdds_AbonentAddID",
                table: "ControllersAdds");

            migrationBuilder.DropIndex(
                name: "IX_ControllersAdds_AbonentArhiveID",
                table: "ControllersAdds");

            migrationBuilder.DropColumn(
                name: "AbonentAddID",
                table: "ControllersAdds");

            migrationBuilder.DropColumn(
                name: "AbonentArhiveID",
                table: "ControllersAdds");

            migrationBuilder.AddColumn<int>(
                name: "ControllersAddID",
                table: "AbonentsArhive",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ControllersAddID",
                table: "Abonents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbonentsArhive_ControllersAddID",
                table: "AbonentsArhive",
                column: "ControllersAddID");

            migrationBuilder.CreateIndex(
                name: "IX_Abonents_ControllersAddID",
                table: "Abonents",
                column: "ControllersAddID");

            migrationBuilder.AddForeignKey(
                name: "FK_Abonents_ControllersAdds_ControllersAddID",
                table: "Abonents",
                column: "ControllersAddID",
                principalTable: "ControllersAdds",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AbonentsArhive_ControllersAdds_ControllersAddID",
                table: "AbonentsArhive",
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

            migrationBuilder.DropForeignKey(
                name: "FK_AbonentsArhive_ControllersAdds_ControllersAddID",
                table: "AbonentsArhive");

            migrationBuilder.DropIndex(
                name: "IX_AbonentsArhive_ControllersAddID",
                table: "AbonentsArhive");

            migrationBuilder.DropIndex(
                name: "IX_Abonents_ControllersAddID",
                table: "Abonents");

            migrationBuilder.DropColumn(
                name: "ControllersAddID",
                table: "AbonentsArhive");

            migrationBuilder.DropColumn(
                name: "ControllersAddID",
                table: "Abonents");

            migrationBuilder.AddColumn<int>(
                name: "AbonentAddID",
                table: "ControllersAdds",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AbonentArhiveID",
                table: "ControllersAdds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ControllersAdds_AbonentAddID",
                table: "ControllersAdds",
                column: "AbonentAddID");

            migrationBuilder.CreateIndex(
                name: "IX_ControllersAdds_AbonentArhiveID",
                table: "ControllersAdds",
                column: "AbonentArhiveID");

            migrationBuilder.AddForeignKey(
                name: "FK_ControllersAdds_AbonentsArhive_AbonentArhiveID",
                table: "ControllersAdds",
                column: "AbonentArhiveID",
                principalTable: "AbonentsArhive",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ControllersAdds_Abonents_AbonentAddID",
                table: "ControllersAdds",
                column: "AbonentAddID",
                principalTable: "Abonents",
                principalColumn: "ID");
        }
    }
}
