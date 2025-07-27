using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class fixLinks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abonents_AbonentsShortCalc_AbonentCalcID",
                table: "Abonents");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_ContractsShortCalc_ContractCalcID",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Meters_MetersShortCalc_MeterCalcID",
                table: "Meters");

            migrationBuilder.DropForeignKey(
                name: "FK_MountMeters_MountMetersShortCalc_MountMeterSCID",
                table: "MountMeters");

            migrationBuilder.DropForeignKey(
                name: "FK_Points_PointsShortCalc_PointCalcID",
                table: "Points");

            migrationBuilder.DropForeignKey(
                name: "FK_Transformers_TransformersShortCalc_TransformerCalcID",
                table: "Transformers");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_UnitsShortCalc_UnitSCID",
                table: "Units");

            migrationBuilder.DropTable(
                name: "MetersShortCalc");

            migrationBuilder.DropTable(
                name: "MountMetersShortCalc");

            migrationBuilder.DropTable(
                name: "TransformersShortCalc");

            migrationBuilder.DropTable(
                name: "UnitsShortCalc");

            migrationBuilder.DropTable(
                name: "PointsShortCalc");

            migrationBuilder.DropTable(
                name: "AbonentsShortCalc");

            migrationBuilder.DropTable(
                name: "ContractsShortCalc");

            migrationBuilder.DropIndex(
                name: "IX_Units_UnitSCID",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Transformers_TransformerCalcID",
                table: "Transformers");

            migrationBuilder.DropIndex(
                name: "IX_Points_PointCalcID",
                table: "Points");

            migrationBuilder.DropIndex(
                name: "IX_MountMeters_MountMeterSCID",
                table: "MountMeters");

            migrationBuilder.DropIndex(
                name: "IX_Meters_MeterCalcID",
                table: "Meters");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ContractCalcID",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Abonents_AbonentCalcID",
                table: "Abonents");

            migrationBuilder.DropColumn(
                name: "UnitSCID",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "PointAddId",
                table: "Transformers");

            migrationBuilder.DropColumn(
                name: "TransformerCalcID",
                table: "Transformers");

            migrationBuilder.DropColumn(
                name: "PointCalcID",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "TransformerAddID",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "MountMeterSCID",
                table: "MountMeters");

            migrationBuilder.DropColumn(
                name: "MeterCalcID",
                table: "Meters");

            migrationBuilder.DropColumn(
                name: "ContractCalcID",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "AbonentCalcID",
                table: "Abonents");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitSCID",
                table: "Units",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PointAddId",
                table: "Transformers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransformerCalcID",
                table: "Transformers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PointCalcID",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransformerAddID",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MountMeterSCID",
                table: "MountMeters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeterCalcID",
                table: "Meters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractCalcID",
                table: "Contracts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AbonentCalcID",
                table: "Abonents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContractsShortCalc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractsShortCalc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MetersShortCalc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    СommissioningDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetersShortCalc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MountMetersShortCalc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    SetDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MountMetersShortCalc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TransformersShortCalc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    СommissioningDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransformersShortCalc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AbonentsShortCalc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbonentNumber = table.Column<int>(type: "int", nullable: false),
                    ContractNumber = table.Column<int>(type: "int", nullable: false),
                    ContractSCID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbonentsShortCalc", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AbonentsShortCalc_ContractsShortCalc_ContractSCID",
                        column: x => x.ContractSCID,
                        principalTable: "ContractsShortCalc",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PointsShortCalc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbonentSCID = table.Column<int>(type: "int", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointsShortCalc", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PointsShortCalc_AbonentsShortCalc_AbonentSCID",
                        column: x => x.AbonentSCID,
                        principalTable: "AbonentsShortCalc",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UnitsShortCalc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointSCID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitsShortCalc", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UnitsShortCalc_PointsShortCalc_PointSCID",
                        column: x => x.PointSCID,
                        principalTable: "PointsShortCalc",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Units_UnitSCID",
                table: "Units",
                column: "UnitSCID");

            migrationBuilder.CreateIndex(
                name: "IX_Transformers_TransformerCalcID",
                table: "Transformers",
                column: "TransformerCalcID");

            migrationBuilder.CreateIndex(
                name: "IX_Points_PointCalcID",
                table: "Points",
                column: "PointCalcID");

            migrationBuilder.CreateIndex(
                name: "IX_MountMeters_MountMeterSCID",
                table: "MountMeters",
                column: "MountMeterSCID");

            migrationBuilder.CreateIndex(
                name: "IX_Meters_MeterCalcID",
                table: "Meters",
                column: "MeterCalcID");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractCalcID",
                table: "Contracts",
                column: "ContractCalcID");

            migrationBuilder.CreateIndex(
                name: "IX_Abonents_AbonentCalcID",
                table: "Abonents",
                column: "AbonentCalcID");

            migrationBuilder.CreateIndex(
                name: "IX_AbonentsShortCalc_ContractSCID",
                table: "AbonentsShortCalc",
                column: "ContractSCID");

            migrationBuilder.CreateIndex(
                name: "IX_PointsShortCalc_AbonentSCID",
                table: "PointsShortCalc",
                column: "AbonentSCID");

            migrationBuilder.CreateIndex(
                name: "IX_UnitsShortCalc_PointSCID",
                table: "UnitsShortCalc",
                column: "PointSCID");

            migrationBuilder.AddForeignKey(
                name: "FK_Abonents_AbonentsShortCalc_AbonentCalcID",
                table: "Abonents",
                column: "AbonentCalcID",
                principalTable: "AbonentsShortCalc",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_ContractsShortCalc_ContractCalcID",
                table: "Contracts",
                column: "ContractCalcID",
                principalTable: "ContractsShortCalc",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meters_MetersShortCalc_MeterCalcID",
                table: "Meters",
                column: "MeterCalcID",
                principalTable: "MetersShortCalc",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MountMeters_MountMetersShortCalc_MountMeterSCID",
                table: "MountMeters",
                column: "MountMeterSCID",
                principalTable: "MountMetersShortCalc",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_PointsShortCalc_PointCalcID",
                table: "Points",
                column: "PointCalcID",
                principalTable: "PointsShortCalc",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transformers_TransformersShortCalc_TransformerCalcID",
                table: "Transformers",
                column: "TransformerCalcID",
                principalTable: "TransformersShortCalc",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_UnitsShortCalc_UnitSCID",
                table: "Units",
                column: "UnitSCID",
                principalTable: "UnitsShortCalc",
                principalColumn: "ID");
        }
    }
}
