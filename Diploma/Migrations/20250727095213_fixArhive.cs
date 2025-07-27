using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class fixArhive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abonents_AbonentsArhive_AbonentArhiveID",
                table: "Abonents");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_ContractsArhive_ContractArhiveID",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Meters_MetersArhive_MeterArhiveID",
                table: "Meters");

            migrationBuilder.DropForeignKey(
                name: "FK_MountMeters_MountMetersArhive_MountMeterArhiveID",
                table: "MountMeters");

            migrationBuilder.DropForeignKey(
                name: "FK_Points_PointsArhive_PointArhiveID",
                table: "Points");

            migrationBuilder.DropForeignKey(
                name: "FK_Transformers_TransformersArhive_TransformerArhiveID",
                table: "Transformers");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_UnitsArhive_UnitArhiveID",
                table: "Units");

            migrationBuilder.DropTable(
                name: "MetersArhive");

            migrationBuilder.DropTable(
                name: "MountMetersArhive");

            migrationBuilder.DropTable(
                name: "TransformersArhive");

            migrationBuilder.DropTable(
                name: "UnitsArhive");

            migrationBuilder.DropTable(
                name: "PointsArhive");

            migrationBuilder.DropTable(
                name: "AbonentsArhive");

            migrationBuilder.DropTable(
                name: "ContractsArhive");

            migrationBuilder.DropIndex(
                name: "IX_Units_UnitArhiveID",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Transformers_TransformerArhiveID",
                table: "Transformers");

            migrationBuilder.DropIndex(
                name: "IX_Points_PointArhiveID",
                table: "Points");

            migrationBuilder.DropIndex(
                name: "IX_MountMeters_MountMeterArhiveID",
                table: "MountMeters");

            migrationBuilder.DropIndex(
                name: "IX_Meters_MeterArhiveID",
                table: "Meters");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ContractArhiveID",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Abonents_AbonentArhiveID",
                table: "Abonents");

            migrationBuilder.DropColumn(
                name: "UnitArhiveID",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "TransformerArhiveID",
                table: "Transformers");

            migrationBuilder.DropColumn(
                name: "PointArhiveID",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "MountMeterArhiveID",
                table: "MountMeters");

            migrationBuilder.DropColumn(
                name: "MeterArhiveID",
                table: "Meters");

            migrationBuilder.DropColumn(
                name: "ContractArhiveID",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "AbonentArhiveID",
                table: "Abonents");

            migrationBuilder.AddColumn<DateOnly>(
                name: "CloseDate",
                table: "Units",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<bool>(
                name: "IsClosed",
                table: "Units",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateOnly>(
                name: "CloseDate",
                table: "Transformers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<bool>(
                name: "IsClosed",
                table: "Transformers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateOnly>(
                name: "CloseDate",
                table: "Points",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<bool>(
                name: "IsClosed",
                table: "Points",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateOnly>(
                name: "CloseDate",
                table: "MountMeters",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<bool>(
                name: "IsClosed",
                table: "MountMeters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateOnly>(
                name: "CloseDate",
                table: "Meters",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<bool>(
                name: "IsClosed",
                table: "Meters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateOnly>(
                name: "CloseDate",
                table: "Contracts",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<bool>(
                name: "IsClosed",
                table: "Contracts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateOnly>(
                name: "CloseDate",
                table: "Abonents",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<bool>(
                name: "IsClosed",
                table: "Abonents",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CloseDate",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "CloseDate",
                table: "Transformers");

            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "Transformers");

            migrationBuilder.DropColumn(
                name: "CloseDate",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "CloseDate",
                table: "MountMeters");

            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "MountMeters");

            migrationBuilder.DropColumn(
                name: "CloseDate",
                table: "Meters");

            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "Meters");

            migrationBuilder.DropColumn(
                name: "CloseDate",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "CloseDate",
                table: "Abonents");

            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "Abonents");

            migrationBuilder.AddColumn<int>(
                name: "UnitArhiveID",
                table: "Units",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransformerArhiveID",
                table: "Transformers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PointArhiveID",
                table: "Points",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MountMeterArhiveID",
                table: "MountMeters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeterArhiveID",
                table: "Meters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContractArhiveID",
                table: "Contracts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AbonentArhiveID",
                table: "Abonents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContractsArhive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreakDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ContractNumber = table.Column<int>(type: "int", nullable: false),
                    FIO = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractsArhive", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MetersArhive",
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
                    table.PrimaryKey("PK_MetersArhive", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MountMetersArhive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    SetDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MountMetersArhive", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TransformersArhive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreakDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TransformerArhiveID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransformersArhive", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TransformersArhive_TransformersArhive_TransformerArhiveID",
                        column: x => x.TransformerArhiveID,
                        principalTable: "TransformersArhive",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AbonentsArhive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbonentNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BreakDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ConclusionDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ContractArhiveID = table.Column<int>(type: "int", nullable: true),
                    ContractNumber = table.Column<int>(type: "int", nullable: false),
                    ControllerNumber = table.Column<int>(type: "int", nullable: false),
                    ControllersAddID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbonentsArhive", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AbonentsArhive_ContractsArhive_ContractArhiveID",
                        column: x => x.ContractArhiveID,
                        principalTable: "ContractsArhive",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AbonentsArhive_ControllersAdds_ControllersAddID",
                        column: x => x.ControllersAddID,
                        principalTable: "ControllersAdds",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PointsArhive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbonentArhiveID = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointsArhive", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PointsArhive_AbonentsArhive_AbonentArhiveID",
                        column: x => x.AbonentArhiveID,
                        principalTable: "AbonentsArhive",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UnitsArhive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointArhiveID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitsArhive", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UnitsArhive_PointsArhive_PointArhiveID",
                        column: x => x.PointArhiveID,
                        principalTable: "PointsArhive",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Units_UnitArhiveID",
                table: "Units",
                column: "UnitArhiveID",
                unique: true,
                filter: "[UnitArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Transformers_TransformerArhiveID",
                table: "Transformers",
                column: "TransformerArhiveID",
                unique: true,
                filter: "[TransformerArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Points_PointArhiveID",
                table: "Points",
                column: "PointArhiveID",
                unique: true,
                filter: "[PointArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MountMeters_MountMeterArhiveID",
                table: "MountMeters",
                column: "MountMeterArhiveID",
                unique: true,
                filter: "[MountMeterArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Meters_MeterArhiveID",
                table: "Meters",
                column: "MeterArhiveID",
                unique: true,
                filter: "[MeterArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractArhiveID",
                table: "Contracts",
                column: "ContractArhiveID",
                unique: true,
                filter: "[ContractArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Abonents_AbonentArhiveID",
                table: "Abonents",
                column: "AbonentArhiveID",
                unique: true,
                filter: "[AbonentArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbonentsArhive_ContractArhiveID",
                table: "AbonentsArhive",
                column: "ContractArhiveID");

            migrationBuilder.CreateIndex(
                name: "IX_AbonentsArhive_ControllersAddID",
                table: "AbonentsArhive",
                column: "ControllersAddID");

            migrationBuilder.CreateIndex(
                name: "IX_PointsArhive_AbonentArhiveID",
                table: "PointsArhive",
                column: "AbonentArhiveID");

            migrationBuilder.CreateIndex(
                name: "IX_TransformersArhive_TransformerArhiveID",
                table: "TransformersArhive",
                column: "TransformerArhiveID");

            migrationBuilder.CreateIndex(
                name: "IX_UnitsArhive_PointArhiveID",
                table: "UnitsArhive",
                column: "PointArhiveID");

            migrationBuilder.AddForeignKey(
                name: "FK_Abonents_AbonentsArhive_AbonentArhiveID",
                table: "Abonents",
                column: "AbonentArhiveID",
                principalTable: "AbonentsArhive",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_ContractsArhive_ContractArhiveID",
                table: "Contracts",
                column: "ContractArhiveID",
                principalTable: "ContractsArhive",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meters_MetersArhive_MeterArhiveID",
                table: "Meters",
                column: "MeterArhiveID",
                principalTable: "MetersArhive",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MountMeters_MountMetersArhive_MountMeterArhiveID",
                table: "MountMeters",
                column: "MountMeterArhiveID",
                principalTable: "MountMetersArhive",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_PointsArhive_PointArhiveID",
                table: "Points",
                column: "PointArhiveID",
                principalTable: "PointsArhive",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transformers_TransformersArhive_TransformerArhiveID",
                table: "Transformers",
                column: "TransformerArhiveID",
                principalTable: "TransformersArhive",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_UnitsArhive_UnitArhiveID",
                table: "Units",
                column: "UnitArhiveID",
                principalTable: "UnitsArhive",
                principalColumn: "ID");
        }
    }
}
