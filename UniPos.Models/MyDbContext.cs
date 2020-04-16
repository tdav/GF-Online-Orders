using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using UniPos.Models.Utils;
using System;
using System.Linq;
using Toolbelt.ComponentModel.DataAnnotations;

namespace UniPos.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        #region Models
        public virtual DbSet<spAccessList> spAccessLists { get; set; }
        public virtual DbSet<spCountry> spCountries { get; set; }
        public virtual DbSet<spDistrict> spDistricts { get; set; }
        public virtual DbSet<spDrug> spDrugs { get; set; }
        public virtual DbSet<spDrugCategory> spDrugCategories { get; set; }
        public virtual DbSet<spDrugStore> spDrugStores { get; set; }
        public virtual DbSet<spLanguage> spLanguages { get; set; }
        public virtual DbSet<spManufacturer> spManufacturers { get; set; }
        public virtual DbSet<spOrderStatus> spOrderStatus { get; set; }
        public virtual DbSet<spPayment> spPayments { get; set; }
        public virtual DbSet<spPharmGroup> spPharmGroups { get; set; }
        public virtual DbSet<spRegion> spRegions { get; set; }
        public virtual DbSet<spRole> spRoles { get; set; }
        public virtual DbSet<spUnit> spUnits { get; set; }
        public virtual DbSet<spUserAgent> spUserAgents { get; set; }
        public virtual DbSet<tbOrderHeader> tbOrders { get; set; }
        public virtual DbSet<tbOrderDetails> tbOrderDetails { get; set; }
        public virtual DbSet<tbProductDetails> tbProductDetails { get; set; }
        public virtual DbSet<tbProductHeader> tbProductHeaders { get; set; }
        public virtual DbSet<tbSetup> tbSetups { get; set; }
        public virtual DbSet<tbUser> tbUser { get; set; } 

        public IAuditService AuditService { get; }
        #endregion

        private IDbContextTransaction _transaction;

        public void BeginTransaction()
        {
            _transaction = Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            finally
            {
                _transaction.Dispose();
            }
        }

        public void Rollback()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=orders;Username=davron;Password=grand_online_orders")
                          .UseSnakeCaseNamingConvention();
           
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
        }

        // устанавливаем фабрику логгера
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddProvider(new MyLoggerProvider());    // указываем наш провайдер логгирования
        });

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            var modified = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted);
            var UserId = 1;// AuditService.GetUserId();

            foreach (var item in modified)
            {
                if (item.Entity is BaseModel entity)
                {
                    entity.CreateUser = UserId;
                    entity.CreateDate = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // .. and invoke "BuildIndexesFromAnnotations"!
            modelBuilder.BuildIndexesFromAnnotations();
        }
    }
}