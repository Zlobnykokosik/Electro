using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class addContollersbase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ControllersAdd_AbonentsArhive_AbonentArhiveID",
                table: "ControllersAdd");

            migrationBuilder.DropForeignKey(
                name: "FK_ControllersAdd_Abonents_AbonentAddID",
                table: "ControllersAdd");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ControllersAdd",
                table: "ControllersAdd");

            migrationBuilder.RenameTable(
                name: "ControllersAdd",
                newName: "ControllersAdds");

            migrationBuilder.RenameIndex(
                name: "IX_ControllersAdd_AbonentArhiveID",
                table: "ControllersAdds",
                newName: "IX_ControllersAdds_AbonentArhiveID");

            migrationBuilder.RenameIndex(
                name: "IX_ControllersAdd_AbonentAddID",
                table: "ControllersAdds",
                newName: "IX_ControllersAdds_AbonentAddID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ControllersAdds",
                table: "ControllersAdds",
                column: "ID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ControllersAdds_AbonentsArhive_AbonentArhiveID",
                table: "ControllersAdds");

            migrationBuilder.DropForeignKey(
                name: "FK_ControllersAdds_Abonents_AbonentAddID",
                table: "ControllersAdds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ControllersAdds",
                table: "ControllersAdds");

            migrationBuilder.RenameTable(
                name: "ControllersAdds",
                newName: "ControllersAdd");

            migrationBuilder.RenameIndex(
                name: "IX_ControllersAdds_AbonentArhiveID",
                table: "ControllersAdd",
                newName: "IX_ControllersAdd_AbonentArhiveID");

            migrationBuilder.RenameIndex(
                name: "IX_ControllersAdds_AbonentAddID",
                table: "ControllersAdd",
                newName: "IX_ControllersAdd_AbonentAddID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ControllersAdd",
                table: "ControllersAdd",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ControllersAdd_AbonentsArhive_AbonentArhiveID",
                table: "ControllersAdd",
                column: "AbonentArhiveID",
                principalTable: "AbonentsArhive",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ControllersAdd_Abonents_AbonentAddID",
                table: "ControllersAdd",
                column: "AbonentAddID",
                principalTable: "Abonents",
                principalColumn: "ID");
        }
    }
}
