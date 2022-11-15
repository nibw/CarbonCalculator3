using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class updatefueltbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleName",
                table: "Tbl_Fuel");

            migrationBuilder.AddColumn<string>(
                name: "FuelName",
                table: "Tbl_Fuel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FuelName",
                table: "Tbl_Fuel");

            migrationBuilder.AddColumn<string>(
                name: "VehicleName",
                table: "Tbl_Fuel",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
