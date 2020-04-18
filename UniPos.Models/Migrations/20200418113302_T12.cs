using Microsoft.EntityFrameworkCore.Migrations;

namespace UniPos.Models.Migrations
{
    public partial class T12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "ix_tb_address_district_id",
                table: "tb_address",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_address_region_id",
                table: "tb_address",
                column: "region_id");

            migrationBuilder.AddForeignKey(
                name: "fk_tb_address_sp_districts_district_id",
                table: "tb_address",
                column: "district_id",
                principalTable: "sp_districts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_tb_address_sp_regions_region_id",
                table: "tb_address",
                column: "region_id",
                principalTable: "sp_regions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_tb_address_sp_districts_district_id",
                table: "tb_address");

            migrationBuilder.DropForeignKey(
                name: "fk_tb_address_sp_regions_region_id",
                table: "tb_address");

            migrationBuilder.DropIndex(
                name: "ix_tb_address_district_id",
                table: "tb_address");

            migrationBuilder.DropIndex(
                name: "ix_tb_address_region_id",
                table: "tb_address");
        }
    }
}
