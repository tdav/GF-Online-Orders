using System;

namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlserver = new Apteka.SqlServer.AptekaSqlServerDbContext();
            var postgres = new UniPos.Models.MyDbContext();
            postgres.ChangeTracker.AutoDetectChangesEnabled = false;

            postgres.BeginTransaction();

            try
            {
                /*
                Sync<UniPos.Models.spCountry, Apteka.SqlServer.spCountries>.Run(sqlserver, postgres);
                Sync<UniPos.Models.spRegion, Apteka.SqlServer.spRegions>.Run(sqlserver, postgres);
                Sync<UniPos.Models.spDistrict, Apteka.SqlServer.spDistricts>.Run(sqlserver, postgres);

                DrugListSync.Run(sqlserver, postgres);
                ProductSync.Run(sqlserver, postgres);
                UserSync.Run(sqlserver, postgres);
                */

                GfDrugListSync.Run(postgres);

                postgres.Commit();
            }
            catch (Exception ee)
            {
                postgres.Rollback();
                Console.WriteLine(ee.Message);
            }

          

            Console.WriteLine("OK");
        }
    }
}
