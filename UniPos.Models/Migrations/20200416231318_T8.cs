using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace UniPos.Models.Migrations
{
    public partial class T8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "tb_orders");

            migrationBuilder.DropColumn(
                name: "district_id",
                table: "tb_orders");

            migrationBuilder.DropColumn(
                name: "latitude",
                table: "tb_orders");

            migrationBuilder.DropColumn(
                name: "longitude",
                table: "tb_orders");

            migrationBuilder.DropColumn(
                name: "region_id",
                table: "tb_orders");

            migrationBuilder.AddColumn<int>(
                name: "address_id",
                table: "tb_orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tb_address",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    create_user = table.Column<int>(nullable: false),
                    update_user = table.Column<int>(nullable: true),
                    region_id = table.Column<int>(nullable: false),
                    district_id = table.Column<int>(nullable: false),
                    street = table.Column<string>(maxLength: 100, nullable: true),
                    house = table.Column<string>(maxLength: 10, nullable: true),
                    flat = table.Column<string>(maxLength: 10, nullable: true),
                    waymark = table.Column<string>(maxLength: 500, nullable: true),
                    latitude = table.Column<decimal>(nullable: false),
                    longitude = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_address", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "ix_tb_orders_address_id",
                table: "tb_orders",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_address_create_user",
                table: "tb_address",
                column: "create_user");

            migrationBuilder.CreateIndex(
                name: "ix_tb_address_status",
                table: "tb_address",
                column: "status");

            migrationBuilder.AddForeignKey(
                name: "fk_tb_orders_tb_address_address_id",
                table: "tb_orders",
                column: "address_id",
                principalTable: "tb_address",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_tb_orders_tb_address_address_id",
                table: "tb_orders");

            migrationBuilder.DropTable(
                name: "tb_address");

            migrationBuilder.DropIndex(
                name: "ix_tb_orders_address_id",
                table: "tb_orders");

            migrationBuilder.DropColumn(
                name: "address_id",
                table: "tb_orders");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "tb_orders",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "district_id",
                table: "tb_orders",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "latitude",
                table: "tb_orders",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "longitude",
                table: "tb_orders",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "region_id",
                table: "tb_orders",
                type: "integer",
                nullable: true);
        }
    }
}
