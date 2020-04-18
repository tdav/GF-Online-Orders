using Microsoft.EntityFrameworkCore.Migrations;

namespace UniPos.Models.Migrations
{
    public partial class T5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "tb_address",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "tb_address");
        }
    }
}
