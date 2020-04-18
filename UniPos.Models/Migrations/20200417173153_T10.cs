using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniPos.Models.Migrations
{
    public partial class T10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "delivery_type_id",
                table: "tb_orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "sp_delivery_types",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    cost = table.Column<decimal>(nullable: false),
                    delivery_time = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_delivery_types", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "ix_tb_orders_delivery_type_id",
                table: "tb_orders",
                column: "delivery_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_sp_delivery_types_create_user",
                table: "sp_delivery_types",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_sp_delivery_types_status",
                table: "sp_delivery_types",
                column: "status");

            migrationBuilder.AddForeignKey(
                name: "fk_tb_orders_sp_delivery_types_delivery_type_id",
                table: "tb_orders",
                column: "delivery_type_id",
                principalTable: "sp_delivery_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_tb_orders_sp_delivery_types_delivery_type_id",
                table: "tb_orders");

            migrationBuilder.DropTable(
                name: "sp_delivery_types");

            migrationBuilder.DropIndex(
                name: "ix_tb_orders_delivery_type_id",
                table: "tb_orders");

            migrationBuilder.DropColumn(
                name: "delivery_type_id",
                table: "tb_orders");
        }
    }
}
