using Microsoft.EntityFrameworkCore.Migrations;

namespace Apteka.Postgres.Migrations
{
    public partial class t3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE TRIGGER sp_drugs_vector_update BEFORE INSERT OR UPDATE
                                  ON ""sp_drugs"" FOR EACH ROW EXECUTE PROCEDURE
                                  tsvector_update_trigger(""search_vector"", 'pg_catalog.russian', ""description"");");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP TRIGGER sp_drugs_vector_update");
        }
    }
}
