using Apteka.SqlServer;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Convert
{
    public class Sync<TDes, TSou> where TSou : class where TDes :class
    {
        public static void Run(AptekaSqlServerDbContext sqlserver, UniPos.Models.MyDbContext postgres) 
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<TSou, TDes>());
            var mapper = config.CreateMapper();

            sqlserver.Set<TSou>().Load();
            var ls = sqlserver.Set<TSou>().AsNoTracking();

            foreach (var it in ls)
            {
                var d = mapper.Map<TDes>(it);
                postgres.Set<TDes>().Add(d);
            }

            postgres.ChangeTracker.DetectChanges();
            postgres.SaveChanges();
        }
    }
}
