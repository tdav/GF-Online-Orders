using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using UniPos.Models;

namespace Convert
{
    public class GfDrugListSync
    {
        public static void Run(MyDbContext pgDb)
        {
            var dlist = pgDb.tbImports
                            .AsNoTracking()
                            .ToList();

            var ph = new tbProductHeader();
            ph.Status = 1;
            ph.CreateDate = DateTime.Now;
            ph.CreateUser = 1;
            pgDb.tbProductHeaders.Add(ph);

            foreach (var it in dlist)
            {
                if (pgDb.spDrugs.Find(it.DrugId) == null)
                {
                    var di = new spDrug();
                    di.Id = it.DrugId;
                    di.Barcode = "000000";
                    di.Name = it.DrugName.ToLower();
                    di.Description = it.DrugName;
                    di.InternationalName = "";
                    di.Dose = "0";
                    di.ManufacturerId = 1;
                    di.DrugCategoryId = 1;
                    di.PharmGroupId = 1;
                    di.UnitId = 1;
                    di.Piece = 1;
                    di.Special = 0;
                    di.Photo = "";
                    di.VatRate = 0;
                    di.DrugRecomendation = "";
                    di.Status = 1;
                    di.CreateDate = DateTime.Now;
                    di.CreateUser = 1;

                    pgDb.spDrugs.Add(di);
                }

                var dp = new tbProductDetails();
                dp.ProductHeader = ph;
                dp.DrugId = it.DrugId;
                dp.SeriesNo = it.SeriesNo;
                dp.Qty = -1;
                dp.CurQty = -1;
                dp.Price = it.Price;
                dp.Vat = 0;
                dp.ExpiryDate = it.ExpiryDate;
                dp.BasePrice = -1;
                dp.IncomingPrice = -1;
                dp.ExtraCharge = -1;
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