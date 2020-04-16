using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace UniPos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(x =>
                {
                    x.UseKestrel();
                    x.UseIISIntegration();
                    x.UseStartup<Startup>();
                });
    }
}
