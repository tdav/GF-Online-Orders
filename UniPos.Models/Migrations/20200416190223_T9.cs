using Microsoft.EntityFrameworkCore.Migrations;

namespace UniPos.Models.Migrations
{
    public partial class T9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "tb_order_details",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "total_sum",
                table: "tb_order_details",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "tb_order_details");

            migrationBuilder.DropColumn(
                name: "total_sum",
                table: "tb_order_details");
        }
    }
}
