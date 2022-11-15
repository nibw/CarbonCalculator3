using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class tblVehicleCapacities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_VehicleCapacity",
                columns: table => new
                {
                    CapacityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(nullable: false),
                    VehicleTypesVehicleId = table.Column<int>(nullable: true),
                    FuelId = table.Column<int>(nullable: false),
                    TransportationId = table.Column<int>(nullable: false),
                    CubicalCentimeter = table.Column<int>(nullable: false),
                    Formula = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_VehicleCapacity", x => x.CapacityId);
                    table.ForeignKey(
                        name: "FK_Tbl_VehicleCapacity_Tbl_Fuel_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Tbl_Fuel",
                        principalColumn: "FuelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_VehicleCapacity_Tbl_Transportation_TransportationId",
                        column: x => x.TransportationId,
                        principalTable: "Tbl_Transportation",
                        principalColumn: "TransportationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_VehicleCapacity_Tbl_VehicleType_VehicleTypesVehicleId",
                        column: x => x.VehicleTypesVehicleId,
                        principalTable: "Tbl_VehicleType",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_VehicleCapacity_FuelId",
                table: "Tbl_VehicleCapacity",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_VehicleCapacity_TransportationId",
                table: "Tbl_VehicleCapacity",
                column: "TransportationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_VehicleCapacity_VehicleTypesVehicleId",
                table: "Tbl_VehicleCapacity",
                column: "VehicleTypesVehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_VehicleCapacity");
        }
    }
}
