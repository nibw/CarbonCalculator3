using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class tblvehicle1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblT_VehicleEmision",
                columns: table => new
                {
                    VehicleEmisionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(nullable: false),
                    VehicleTypesVehicleId = table.Column<int>(nullable: true),
                    FuelId = table.Column<int>(nullable: false),
                    TransportationId = table.Column<int>(nullable: false),
                    CapacityId = table.Column<int>(nullable: false),
                    VehicleCapacitiesCapacityId = table.Column<int>(nullable: true),
                    PeriodeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    TravelFrequency = table.Column<int>(nullable: false),
                    Per = table.Column<DateTime>(nullable: false),
                    AmountPeople = table.Column<int>(nullable: false),
                    Mileage = table.Column<decimal>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblT_VehicleEmision", x => x.VehicleEmisionId);
                    table.ForeignKey(
                        name: "FK_TblT_VehicleEmision_Tbl_Fuel_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Tbl_Fuel",
                        principalColumn: "FuelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblT_VehicleEmision_Tbl_Transportation_TransportationId",
                        column: x => x.TransportationId,
                        principalTable: "Tbl_Transportation",
                        principalColumn: "TransportationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblT_VehicleEmision_Tbl_VehicleCapacity_VehicleCapacitiesCapacityId",
                        column: x => x.VehicleCapacitiesCapacityId,
                        principalTable: "Tbl_VehicleCapacity",
                        principalColumn: "CapacityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblT_VehicleEmision_Tbl_VehicleType_VehicleTypesVehicleId",
                        column: x => x.VehicleTypesVehicleId,
                        principalTable: "Tbl_VehicleType",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblT_VehicleEmision_FuelId",
                table: "TblT_VehicleEmision",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_TblT_VehicleEmision_TransportationId",
                table: "TblT_VehicleEmision",
                column: "TransportationId");

            migrationBuilder.CreateIndex(
                name: "IX_TblT_VehicleEmision_VehicleCapacitiesCapacityId",
                table: "TblT_VehicleEmision",
                column: "VehicleCapacitiesCapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_TblT_VehicleEmision_VehicleTypesVehicleId",
                table: "TblT_VehicleEmision",
                column: "VehicleTypesVehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblT_VehicleEmision");
        }
    }
}
