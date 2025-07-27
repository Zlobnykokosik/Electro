using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class fixAbonent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AbonentsArhive",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "ConclusionDate",
                table: "AbonentsArhive",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "ControllerNumber",
                table: "AbonentsArhive",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Abonents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                name: "Address",
                table: "AbonentsArhive");

            migrationBuilder.DropColumn(
                name: "ConclusionDate",
                table: "AbonentsArhive");

            migrationBuilder.DropColumn(
                name: "ControllerNumber",
                table: "AbonentsArhive");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Abonents");

            migrationBuilder.DropColumn(
                name: "ControllerNumber",
                table: "Abonents");
        }
    }
}
