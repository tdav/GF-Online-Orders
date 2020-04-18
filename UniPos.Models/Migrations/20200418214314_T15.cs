using Microsoft.EntityFrameworkCore.Migrations;

namespace UniPos.Models.Migrations
{
    public partial class T15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "ix_tb_user_create_date",
                table: "tb_user",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_tb_setups_create_date",
                table: "tb_setups",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_tb_product_headers_create_date",
                table: "tb_product_headers",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_tb_product_details_create_date",
                table: "tb_product_details",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_tb_orders_create_date",
                table: "tb_orders",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_tb_orders_delivery_time",
                table: "tb_orders",
                column: "delivery_time");

            migrationBuilder.CreateIndex(
                name: "ix_tb_order_details_create_date",
                table: "tb_order_details",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_tb_address_create_date",
                table: "tb_address",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_user_agents_create_date",
                table: "sp_user_agents",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_units_create_date",
                table: "sp_units",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_roles_create_date",
                table: "sp_roles",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_regions_create_date",
                table: "sp_regions",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_pharm_groups_create_date",
                table: "sp_pharm_groups",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_payments_create_date",
                table: "sp_payments",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_order_status_create_date",
                table: "sp_order_status",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_manufacturers_create_date",
                table: "sp_manufacturers",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_languages_create_date",
                table: "sp_languages",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drugs_create_date",
                table: "sp_drugs",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drug_stores_create_date",
                table: "sp_drug_stores",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_drug_categories_create_date",
                table: "sp_drug_categories",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_districts_create_date",
                table: "sp_districts",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_delivery_types_create_date",
                table: "sp_delivery_types",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_countries_create_date",
                table: "sp_countries",
                column: "create_date");

            migrationBuilder.CreateIndex(
                name: "ix_sp_access_lists_create_date",
                table: "sp_access_lists",
                column: "create_date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_tb_user_create_date",
                table: "tb_user");

            migrationBuilder.DropIndex(
                name: "ix_tb_setups_create_date",
                table: "tb_setups");

            migrationBuilder.DropIndex(
                name: "ix_tb_product_headers_create_date",
                table: "tb_product_headers");

            migrationBuilder.DropIndex(
                name: "ix_tb_product_details_create_date",
                table: "tb_product_details");

            migrationBuilder.DropIndex(
                name: "ix_tb_orders_create_date",
                table: "tb_orders");

            migrationBuilder.DropIndex(
                name: "ix_tb_orders_delivery_time",
                table: "tb_orders");

            migrationBuilder.DropIndex(
                name: "ix_tb_order_details_create_date",
                table: "tb_order_details");

            migrationBuilder.DropIndex(
                name: "ix_tb_address_create_date",
                table: "tb_address");

            migrationBuilder.DropIndex(
                name: "ix_sp_user_agents_create_date",
                table: "sp_user_agents");

            migrationBuilder.DropIndex(
                name: "ix_sp_units_create_date",
                table: "sp_units");

            migrationBuilder.DropIndex(
                name: "ix_sp_roles_create_date",
                table: "sp_roles");

            migrationBuilder.DropIndex(
                name: "ix_sp_regions_create_date",
                table: "sp_regions");

            migrationBuilder.DropIndex(
                name: "ix_sp_pharm_groups_create_date",
                table: "sp_pharm_groups");

            migrationBuilder.DropIndex(
                name: "ix_sp_payments_create_date",
                table: "sp_payments");

            migrationBuilder.DropIndex(
                name: "ix_sp_order_status_create_date",
                table: "sp_order_status");

            migrationBuilder.DropIndex(
                name: "ix_sp_manufacturers_create_date",
                table: "sp_manufacturers");

            migrationBuilder.DropIndex(
                name: "ix_sp_languages_create_date",
                table: "sp_languages");

            migrationBuilder.DropIndex(
                name: "ix_sp_drugs_create_date",
                table: "sp_drugs");

            migrationBuilder.DropIndex(
                name: "ix_sp_drug_stores_create_date",
                table: "sp_drug_stores");

            migrationBuilder.DropIndex(
                name: "ix_sp_drug_categories_create_date",
                table: "sp_drug_categories");

            migrationBuilder.DropIndex(
                name: "ix_sp_districts_create_date",
                table: "sp_districts");

            migrationBuilder.DropIndex(
                name: "ix_sp_delivery_types_create_date",
                table: "sp_delivery_types");

            migrationBuilder.DropIndex(
                name: "ix_sp_countries_create_date",
                table: "sp_countries");

            migrationBuilder.DropIndex(
                name: "ix_sp_access_lists_create_date",
                table: "sp_access_lists");
        }
    }
}
