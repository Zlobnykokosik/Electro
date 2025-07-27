using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diploma.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContractsArhive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNumber = table.Column<int>(type: "int", nullable: false),
                    FIO = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreakDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractsArhive", x => x.ID);
                });

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
                name: "MetersArhive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    СommissioningDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetersArhive", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MetersShortCalc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    СommissioningDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetersShortCalc", x => x.ID);
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
                name: "TransformersArhive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreakDate = table.Column<DateOnly>(type: "date", nullable: false),
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
                name: "AbonentsArhive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNumber = table.Column<int>(type: "int", nullable: false),
                    AbonentNumber = table.Column<int>(type: "int", nullable: false),
                    BreakDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ContractArhiveID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbonentsArhive", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AbonentsArhive_ContractsArhive_ContractArhiveID",
                        column: x => x.ContractArhiveID,
                        principalTable: "ContractsArhive",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AbonentsShortCalc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNumber = table.Column<int>(type: "int", nullable: false),
                    AbonentNumber = table.Column<int>(type: "int", nullable: false),
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
                name: "Contracts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNumber = table.Column<int>(type: "int", nullable: false),
                    FIO = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ConclusionDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ContractCalcID = table.Column<int>(type: "int", nullable: true),
                    ContractArhiveID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contracts_ContractsArhive_ContractArhiveID",
                        column: x => x.ContractArhiveID,
                        principalTable: "ContractsArhive",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Contracts_ContractsShortCalc_ContractCalcID",
                        column: x => x.ContractCalcID,
                        principalTable: "ContractsShortCalc",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Meters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    СommissioningDate = table.Column<DateOnly>(type: "date", nullable: false),
                    MeterCalcID = table.Column<int>(type: "int", nullable: true),
                    MeterArhiveID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Meters_MetersArhive_MeterArhiveID",
                        column: x => x.MeterArhiveID,
                        principalTable: "MetersArhive",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Meters_MetersShortCalc_MeterCalcID",
                        column: x => x.MeterCalcID,
                        principalTable: "MetersShortCalc",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PointsArhive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Version = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AbonentArhiveID = table.Column<int>(type: "int", nullable: true)
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
                name: "PointsShortCalc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AbonentSCID = table.Column<int>(type: "int", nullable: true)
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
                name: "Abonents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNumber = table.Column<int>(type: "int", nullable: false),
                    AbonentNumber = table.Column<int>(type: "int", nullable: false),
                    ConclusionDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ChangeStatus = table.Column<bool>(type: "bit", nullable: false),
                    AbonentArhiveID = table.Column<int>(type: "int", nullable: true),
                    AbonentCalcID = table.Column<int>(type: "int", nullable: true),
                    ContractAddID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abonents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Abonents_AbonentsArhive_AbonentArhiveID",
                        column: x => x.AbonentArhiveID,
                        principalTable: "AbonentsArhive",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Abonents_AbonentsShortCalc_AbonentCalcID",
                        column: x => x.AbonentCalcID,
                        principalTable: "AbonentsShortCalc",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Abonents_Contracts_ContractAddID",
                        column: x => x.ContractAddID,
                        principalTable: "Contracts",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MountMeters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    SetDate = table.Column<DateOnly>(type: "date", nullable: false),
                    MountMeterCalcID = table.Column<int>(type: "int", nullable: true),
                    MeterID = table.Column<int>(type: "int", nullable: false),
                    MountMeterArhiveID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MountMeters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MountMeters_Meters_MeterID",
                        column: x => x.MeterID,
                        principalTable: "Meters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MountMeters_MountMetersArhive_MountMeterArhiveID",
                        column: x => x.MountMeterArhiveID,
                        principalTable: "MountMetersArhive",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_MountMeters_MountMetersShortCalc_MountMeterCalcID",
                        column: x => x.MountMeterCalcID,
                        principalTable: "MountMetersShortCalc",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UnitsArhive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    PointArhiveID = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "UnitsShortCalc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    PointSCID = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Points",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Version = table.Column<short>(type: "smallint", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    PointCalcID = table.Column<int>(type: "int", nullable: true),
                    PointArhiveID = table.Column<int>(type: "int", nullable: true),
                    AbonentAddID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Points_Abonents_AbonentAddID",
                        column: x => x.AbonentAddID,
                        principalTable: "Abonents",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Points_PointsArhive_PointArhiveID",
                        column: x => x.PointArhiveID,
                        principalTable: "PointsArhive",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Points_PointsShortCalc_PointCalcID",
                        column: x => x.PointCalcID,
                        principalTable: "PointsShortCalc",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Transformers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    СommissioningDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TransformerCalcID = table.Column<int>(type: "int", nullable: true),
                    TransformerArhiveID = table.Column<int>(type: "int", nullable: true),
                    PointAddID = table.Column<int>(type: "int", nullable: true),
                    TransformerAddID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transformers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transformers_Points_PointAddID",
                        column: x => x.PointAddID,
                        principalTable: "Points",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Transformers_TransformersArhive_TransformerArhiveID",
                        column: x => x.TransformerArhiveID,
                        principalTable: "TransformersArhive",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Transformers_TransformersShortCalc_TransformerCalcID",
                        column: x => x.TransformerCalcID,
                        principalTable: "TransformersShortCalc",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Transformers_Transformers_TransformerAddID",
                        column: x => x.TransformerAddID,
                        principalTable: "Transformers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    MountMeterID = table.Column<int>(type: "int", nullable: false),
                    UnitArhiveID = table.Column<int>(type: "int", nullable: true),
                    UnitCalcID = table.Column<int>(type: "int", nullable: true),
                    PointAddID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Units_MountMeters_MountMeterID",
                        column: x => x.MountMeterID,
                        principalTable: "MountMeters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Units_Points_PointAddID",
                        column: x => x.PointAddID,
                        principalTable: "Points",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Units_UnitsArhive_UnitArhiveID",
                        column: x => x.UnitArhiveID,
                        principalTable: "UnitsArhive",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Units_UnitsShortCalc_UnitCalcID",
                        column: x => x.UnitCalcID,
                        principalTable: "UnitsShortCalc",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abonents_AbonentArhiveID",
                table: "Abonents",
                column: "AbonentArhiveID",
                unique: true,
                filter: "[AbonentArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Abonents_AbonentCalcID",
                table: "Abonents",
                column: "AbonentCalcID");

            migrationBuilder.CreateIndex(
                name: "IX_Abonents_ContractAddID",
                table: "Abonents",
                column: "ContractAddID");

            migrationBuilder.CreateIndex(
                name: "IX_AbonentsArhive_ContractArhiveID",
                table: "AbonentsArhive",
                column: "ContractArhiveID");

            migrationBuilder.CreateIndex(
                name: "IX_AbonentsShortCalc_ContractSCID",
                table: "AbonentsShortCalc",
                column: "ContractSCID");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractArhiveID",
                table: "Contracts",
                column: "ContractArhiveID",
                unique: true,
                filter: "[ContractArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractCalcID",
                table: "Contracts",
                column: "ContractCalcID");

            migrationBuilder.CreateIndex(
                name: "IX_Meters_MeterArhiveID",
                table: "Meters",
                column: "MeterArhiveID",
                unique: true,
                filter: "[MeterArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Meters_MeterCalcID",
                table: "Meters",
                column: "MeterCalcID");

            migrationBuilder.CreateIndex(
                name: "IX_MountMeters_MeterID",
                table: "MountMeters",
                column: "MeterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MountMeters_MountMeterArhiveID",
                table: "MountMeters",
                column: "MountMeterArhiveID",
                unique: true,
                filter: "[MountMeterArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MountMeters_MountMeterCalcID",
                table: "MountMeters",
                column: "MountMeterCalcID");

            migrationBuilder.CreateIndex(
                name: "IX_Points_AbonentAddID",
                table: "Points",
                column: "AbonentAddID");

            migrationBuilder.CreateIndex(
                name: "IX_Points_PointArhiveID",
                table: "Points",
                column: "PointArhiveID",
                unique: true,
                filter: "[PointArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Points_PointCalcID",
                table: "Points",
                column: "PointCalcID");

            migrationBuilder.CreateIndex(
                name: "IX_PointsArhive_AbonentArhiveID",
                table: "PointsArhive",
                column: "AbonentArhiveID");

            migrationBuilder.CreateIndex(
                name: "IX_PointsShortCalc_AbonentSCID",
                table: "PointsShortCalc",
                column: "AbonentSCID");

            migrationBuilder.CreateIndex(
                name: "IX_Transformers_PointAddID",
                table: "Transformers",
                column: "PointAddID");

            migrationBuilder.CreateIndex(
                name: "IX_Transformers_TransformerAddID",
                table: "Transformers",
                column: "TransformerAddID");

            migrationBuilder.CreateIndex(
                name: "IX_Transformers_TransformerArhiveID",
                table: "Transformers",
                column: "TransformerArhiveID",
                unique: true,
                filter: "[TransformerArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Transformers_TransformerCalcID",
                table: "Transformers",
                column: "TransformerCalcID");

            migrationBuilder.CreateIndex(
                name: "IX_TransformersArhive_TransformerArhiveID",
                table: "TransformersArhive",
                column: "TransformerArhiveID");

            migrationBuilder.CreateIndex(
                name: "IX_Units_MountMeterID",
                table: "Units",
                column: "MountMeterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Units_PointAddID",
                table: "Units",
                column: "PointAddID");

            migrationBuilder.CreateIndex(
                name: "IX_Units_UnitArhiveID",
                table: "Units",
                column: "UnitArhiveID",
                unique: true,
                filter: "[UnitArhiveID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Units_UnitCalcID",
                table: "Units",
                column: "UnitCalcID");

            migrationBuilder.CreateIndex(
                name: "IX_UnitsArhive_PointArhiveID",
                table: "UnitsArhive",
                column: "PointArhiveID");

            migrationBuilder.CreateIndex(
                name: "IX_UnitsShortCalc_PointSCID",
                table: "UnitsShortCalc",
                column: "PointSCID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transformers");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "TransformersArhive");

            migrationBuilder.DropTable(
                name: "TransformersShortCalc");

            migrationBuilder.DropTable(
                name: "MountMeters");

            migrationBuilder.DropTable(
                name: "Points");

            migrationBuilder.DropTable(
                name: "UnitsArhive");

            migrationBuilder.DropTable(
                name: "UnitsShortCalc");

            migrationBuilder.DropTable(
                name: "Meters");

            migrationBuilder.DropTable(
                name: "MountMetersArhive");

            migrationBuilder.DropTable(
                name: "MountMetersShortCalc");

            migrationBuilder.DropTable(
                name: "Abonents");

            migrationBuilder.DropTable(
                name: "PointsArhive");

            migrationBuilder.DropTable(
                name: "PointsShortCalc");

            migrationBuilder.DropTable(
                name: "MetersArhive");

            migrationBuilder.DropTable(
                name: "MetersShortCalc");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "AbonentsArhive");

            migrationBuilder.DropTable(
                name: "AbonentsShortCalc");

            migrationBuilder.DropTable(
                name: "ContractsArhive");

            migrationBuilder.DropTable(
                name: "ContractsShortCalc");
        }
    }
}
