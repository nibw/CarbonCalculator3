using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_CarbonType",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_CarbonType", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Fuel",
                columns: table => new
                {
                    FuelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Fuel", x => x.FuelId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Transportation",
                columns: table => new
                {
                    TransportationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransportationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Transportation", x => x.TransportationId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_VehicleCategory",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_VehicleCategory", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_VehicleType",
                columns: table => new
                {
                    VehicleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_VehicleType", x => x.VehicleId);
                });

            migrationBuilder.CreateTable(
                name: "TblT_Household",
                columns: table => new
                {
                    HouseholdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountPeople = table.Column<int>(nullable: false),
                    Standmeter = table.Column<int>(nullable: false),
                    LpgConsumption = table.Column<int>(nullable: false),
                    CityGasConsumption = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ElectricityCons = table.Column<int>(nullable: false),
                    GasCons = table.Column<int>(nullable: false),
                    ElectricityEmision = table.Column<int>(nullable: false),
                    GasEmision = table.Column<int>(nullable: false),
                    PeopleEmision = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblT_Household", x => x.HouseholdId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_CarbonType");

            migrationBuilder.DropTable(
                name: "Tbl_Fuel");

            migrationBuilder.DropTable(
                name: "Tbl_Transportation");

            migrationBuilder.DropTable(
                name: "Tbl_VehicleCategory");

            migrationBuilder.DropTable(
                name: "Tbl_VehicleType");

            migrationBuilder.DropTable(
                name: "TblT_Household");
        }
    }
}
