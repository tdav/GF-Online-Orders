using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace UniPos.Models.Migrations
{
    public partial class T6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_imports",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    drug_store_id = table.Column<string>(nullable: true),
                    drug_id = table.Column<int>(nullable: false),
                    partya = table.Column<string>(nullable: true),
                    drug_name = table.Column<string>(nullable: true),
                    series_no = table.Column<string>(nullable: true),
                    expiry_date = table.Column<DateTime>(nullable: false),
                    price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_imports", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_imports");
        }
    }
}
