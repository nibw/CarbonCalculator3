using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class updatetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElectricityCons",
                table: "TblT_Household");

            migrationBuilder.DropColumn(
                name: "ElectricityEmision",
                table: "TblT_Household");

            migrationBuilder.DropColumn(
                name: "GasCons",
                table: "TblT_Household");

            migrationBuilder.DropColumn(
                name: "GasEmision",
                table: "TblT_Household");

            migrationBuilder.DropColumn(
                name: "PeopleEmision",
                table: "TblT_Household");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ElectricityCons",
                table: "TblT_Household",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ElectricityEmision",
                table: "TblT_Household",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GasCons",
                table: "TblT_Household",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GasEmision",
                table: "TblT_Household",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PeopleEmision",
                table: "TblT_Household",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
