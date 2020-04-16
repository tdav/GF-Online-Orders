using Apteka.Postgres.Utils;
using Microsoft.EntityFrameworkCore.Migrations;
using NpgsqlTypes;

namespace Apteka.Postgres.Migrations
{
    public partial class t2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<jbDrugNameParsed>(
                name: "name_parsed",
                table: "sp_drugs",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<NpgsqlTsVector>(
                name: "search_vector",
                table: "sp_drugs",
                nullable: true);

            migrationBuilder.Sql(@"CREATE INDEX fts_spdrug_idx ON ""sp_drugs"" USING GIN (to_tsvector('russian', ""description"" ));");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name_parsed",
                table: "sp_drugs");

            migrationBuilder.DropColumn(
                name: "search_vector",
                table: "sp_drugs");

            migrationBuilder.Sql(@"DROP INDEX fts_spdrug_idx;");
        }
    }
}
