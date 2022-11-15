using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class tblperiode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Periode",
                columns: table => new
                {
                    PeriodeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Month = table.Column<DateTime>(nullable: false),
                    Year = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Periode", x => x.PeriodeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblT_VehicleEmision_PeriodeId",
                table: "TblT_VehicleEmision",
                column: "PeriodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblT_VehicleEmision_Tbl_Periode_PeriodeId",
                table: "TblT_VehicleEmision",
                column: "PeriodeId",
                principalTable: "Tbl_Periode",
                principalColumn: "PeriodeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblT_VehicleEmision_Tbl_Periode_PeriodeId",
                table: "TblT_VehicleEmision");

            migrationBuilder.DropTable(
                name: "Tbl_Periode");

            migrationBuilder.DropIndex(
                name: "IX_TblT_VehicleEmision_PeriodeId",
                table: "TblT_VehicleEmision");
        }
    }
}
