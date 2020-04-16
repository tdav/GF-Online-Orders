using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using UniPos.Models;

namespace Convert
{

    public class ProductSync
    {
        public static void Run(Apteka.SqlServer.AptekaSqlServerDbContext sqlDb, MyDbContext pgDb)
        {
            var dlist = sqlDb.tbDocItems
                            .Include(x=>x.Drug)
                            .AsNoTracking().ToList();


            var ph = new tbProductHeader();
            ph.Status = 1;
            ph.CreateDate = DateTime.Now;
            ph.CreateUser = 1;
            pgDb.tbProductHeaders.Add(ph);

            foreach (var it in dlist)
            {
                if (it.Drug.ServerId == null) continue;

                var dp = new tbProductDetails();
                dp.ProductHeader = ph;
                dp.DrugId = it.Drug.ServerId?? it.Drug.ServerId.Value;
                dp.SeriesNo = it.SeriesNo;
                dp.Qty = it.Qty;
                dp.CurQty = it.CurQty;
                dp.Price = it.Price;
                dp.Vat = it.Vat;
                dp.ExpiryDate = it.ExpiryDate;
                dp.BasePrice = it.BasePrice;
                dp.IncomingPrice = it.IncomingPrice;
                dp.ExtraCharge = it.ExtraCharge;
                dp.Status = 1;
                dp.CreateDate = DateTime.Now;
                dp.CreateUser = 1;
                pgDb.tbProductDetails.Add(dp);
            }

            pgDb.ChangeTracker.DetectChanges();
            pgDb.SaveChanges();
        }
    }
}