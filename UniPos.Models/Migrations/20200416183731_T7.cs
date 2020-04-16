using Microsoft.EntityFrameworkCore.Migrations;

namespace UniPos.Models.Migrations
{
    public partial class T7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_tb_order_details_sp_drugs_drug_id",
                table: "tb_order_details");

            migrationBuilder.DropIndex(
                name: "ix_tb_order_details_drug_id",
                table: "tb_order_details");

            migrationBuilder.DropColumn(
                name: "drug_id",
                table: "tb_order_details");

            migrationBuilder.AddColumn<int>(
                name: "product_id",
                table: "tb_order_details",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_tb_order_details_product_id",
                table: "tb_order_details",
                column: "product_id");

            migrationBuilder.AddForeignKey(
                name: "fk_tb_order_details_tb_product_details_product_id",
                table: "tb_order_details",
                column: "product_id",
                principalTable: "tb_product_details",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_tb_order_details_tb_product_details_product_id",
                table: "tb_order_details");

            migrationBuilder.DropIndex(
                name: "ix_tb_order_details_product_id",
                table: "tb_order_details");

            migrationBuilder.DropColumn(
                name: "product_id",
                table: "tb_order_details");

            migrationBuilder.AddColumn<int>(
                name: "drug_id",
                table: "tb_order_details",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_tb_order_details_drug_id",
                table: "tb_order_details",
                column: "drug_id");

            migrationBuilder.AddForeignKey(
                name: "fk_tb_order_details_sp_drugs_drug_id",
                table: "tb_order_details",
                column: "drug_id",
                principalTable: "sp_drugs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
