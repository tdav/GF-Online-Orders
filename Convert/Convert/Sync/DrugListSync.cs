using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using UniPos.Models;

namespace Convert
{

    public class DrugListSync
    {
        public static void Run(Apteka.SqlServer.AptekaSqlServerDbContext sqlDb, MyDbContext pgDb)
        {
            var dlist = sqlDb.spDrugs
                                     .Include(x => x.Manufacturer)
                                     .Include(x => x.DrugCategory)
                                     .Include(x => x.PharmGroup)
                                     .Include(x => x.Unit).AsNoTracking().ToList();
            spManufacturer sm = null;
            spDrugCategory sd = null;
            spPharmGroup sp = null;
            spUnit su = null;

            foreach (var it in dlist)
            {

                if (it.Manufacturer != null)
                {
                    sm = new spManufacturer();
                   // sm.Id = it.Manufacturer.ServerId ?? it.Manufacturer.ServerId.Value;
                    sm.CountryId = it.Manufacturer.CountryId;
                    sm.Name = it.Manufacturer.Name;
                    sm.CreateDate = DateTime.Now;
                    sm.CreateUser = 1;
                    sm.Status = 1;
                }

                if (it.DrugCategory != null)
                {
                    sd = new spDrugCategory();
                   // sd.Id = it.DrugCategory.ServerId ?? it.DrugCategory.ServerId.Value;
                    sd.Name = it.DrugCategory.Name;
                    sd.CreateDate = DateTime.Now;
                    sd.CreateUser = 1;
                    sd.Status = 1;
                }

                if (it.PharmGroup != null)
                {
                    sp = new spPharmGroup();
                   // sp.Id = it.PharmGroup.ServerId ?? it.PharmGroup.ServerId.Value;
                    sp.Name = it.PharmGroup.Name;
                    sp.CreateDate = DateTime.Now;
                    sp.CreateUser = 1;
                    sp.Status = 1;
                }

                if (it.Unit != null)
                {
                    su = new spUnit();
                    //su.Id = it.Unit.ServerId ?? it.Unit.ServerId.Value;
                    su.Name = it.Unit.Name;
                    su.Impartible = it.Unit.Impartible;
                    su.CreateDate = DateTime.Now;
                    su.CreateUser = 1;
                    su.Status = 1;
                }

                if (it.ServerId == null) continue;

                var di = new spDrug();
                di.Id = it.ServerId??it.ServerId.Value;
                di.Barcode = it.Barcode;
                di.Name = it.Name;
                di.Description = it.Description;
                di.InternationalName = it.InternationalName;
                di.Dose = it.Dose;
                di.Manufacturer = sm;
                di.DrugCategory = sd;
                di.PharmGroup = sp;
                di.Unit = su;
                di.Piece = it.Piece;
                di.Special = 0;
                di.Photo = it.Photo;
                di.VatRate = it.VatRate;
                di.DrugRecomendation = it.DrugRecomendation;
                di.Status = 1;
                di.CreateDate = DateTime.Now;
                di.CreateUser = 1;

                pgDb.spDrugs.Add(di);
            }

            pgDb.ChangeTracker.DetectChanges();
            pgDb.SaveChanges();
        }
    }
}