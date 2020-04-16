using Microsoft.EntityFrameworkCore;

namespace Apteka.SqlServer
{
    public partial class AptekaSqlServerDbContext : DbContext
    {
        public AptekaSqlServerDbContext()
        {
        }

        public AptekaSqlServerDbContext(DbContextOptions<AptekaSqlServerDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<spAccessLists> spAccessLists { get; set; }
        public virtual DbSet<spCountries> spCountries { get; set; }
        public virtual DbSet<spDiscountTypes> spDiscountTypes { get; set; }
        public virtual DbSet<spDistributors> spDistributors { get; set; }
        public virtual DbSet<spDistricts> spDistricts { get; set; }
        public virtual DbSet<spDrugAdditionalInfoes> spDrugAdditionalInfoes { get; set; }
        public virtual DbSet<spDrugCategories> spDrugCategories { get; set; }
        public virtual DbSet<spDrugRecomendations> spDrugRecomendations { get; set; }
        public virtual DbSet<spDrugStores> spDrugStores { get; set; }
        public virtual DbSet<spDrugs> spDrugs { get; set; }
        public virtual DbSet<spInsurances> spInsurances { get; set; }
        public virtual DbSet<spManufacturers> spManufacturers { get; set; }
        public virtual DbSet<spOnlinePayments> spOnlinePayments { get; set; }
        public virtual DbSet<spOperationTypes> spOperationTypes { get; set; }
        public virtual DbSet<spOrderStatus> spOrderStatus { get; set; }
        public virtual DbSet<spPharmGroups> spPharmGroups { get; set; }
        public virtual DbSet<spRegions> spRegions { get; set; }
        public virtual DbSet<spRoles> spRoles { get; set; }
        public virtual DbSet<spStatus> spStatus { get; set; }
        public virtual DbSet<spTableInfoes> spTableInfoes { get; set; }
        public virtual DbSet<spTestTables> spTestTables { get; set; }
        public virtual DbSet<spTypeOfPayments> spTypeOfPayments { get; set; }
        public virtual DbSet<spUnits> spUnits { get; set; }
        public virtual DbSet<tbBuyOnCredits> tbBuyOnCredits { get; set; }
        public virtual DbSet<tbCards> tbCards { get; set; }
        public virtual DbSet<tbCashExpenses> tbCashExpenses { get; set; }
        public virtual DbSet<tbChangeHistories> tbChangeHistories { get; set; }
        public virtual DbSet<tbCustomers> tbCustomers { get; set; }
        public virtual DbSet<tbDebtRepayments> tbDebtRepayments { get; set; }
        public virtual DbSet<tbDefectures> tbDefectures { get; set; }
        public virtual DbSet<tbDiscounts> tbDiscounts { get; set; }
        public virtual DbSet<tbDocItems> tbDocItems { get; set; }
        public virtual DbSet<tbDocs> tbDocs { get; set; }
        public virtual DbSet<tbDrugAdditionalInfoes> tbDrugAdditionalInfoes { get; set; }
        public virtual DbSet<tbEncashments> tbEncashments { get; set; }
        public virtual DbSet<tbInventories> tbInventories { get; set; }
        public virtual DbSet<tbInventoryCurrentLists> tbInventoryCurrentLists { get; set; }
        public virtual DbSet<tbInventoryItems> tbInventoryItems { get; set; }
        public virtual DbSet<tbLog> tbLog { get; set; }
        public virtual DbSet<tbLosses> tbLosses { get; set; }
        public virtual DbSet<tbMandatoryDrugs> tbMandatoryDrugs { get; set; }
        public virtual DbSet<tbMedicalInsurances> tbMedicalInsurances { get; set; }
        public virtual DbSet<tbMonitorSyncs> tbMonitorSyncs { get; set; }
        public virtual DbSet<tbOnlinePaySystems> tbOnlinePaySystems { get; set; }
        public virtual DbSet<tbOrderItems> tbOrderItems { get; set; }
        public virtual DbSet<tbOrders> tbOrders { get; set; }
        public virtual DbSet<tbPriceDocs> tbPriceDocs { get; set; }
        public virtual DbSet<tbPriceItems> tbPriceItems { get; set; }
        public virtual DbSet<tbReceipts> tbReceipts { get; set; }
        public virtual DbSet<tbReturnOfProducts> tbReturnOfProducts { get; set; }
        public virtual DbSet<tbRevaluationOfDrugs> tbRevaluationOfDrugs { get; set; }
        public virtual DbSet<tbSdachis> tbSdachis { get; set; }
        public virtual DbSet<tbSetups> tbSetups { get; set; }
        public virtual DbSet<tbSmenas> tbSmenas { get; set; }
        public virtual DbSet<tbTurnovers> tbTurnovers { get; set; }
        public virtual DbSet<tbUsers> tbUsers { get; set; }
        public virtual DbSet<tbWriteOffs> tbWriteOffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(local)\\AptekaSQL;User ID=AptekaUser1;Password=123456;Persist Security Info=True;Initial Catalog=AptekaDataBase_SaraKul13022020");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 

            modelBuilder.Entity<spAccessLists>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spCountries>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spDiscountTypes>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DpInfo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spDistributors>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.BankName).HasMaxLength(200);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.INN).HasMaxLength(100);

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.MFO).HasMaxLength(100);

                entity.Property(e => e.OKONH).HasMaxLength(100);

                entity.Property(e => e.OrganizationName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PersonName).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.SettlementAccount).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spDistricts>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.RegionId)
                    .HasName("IX_RegionId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.spDistricts)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.spDistricts_dbo.spRegions_RegionId");
            });

            modelBuilder.Entity<spDrugAdditionalInfoes>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spDrugCategories>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spDrugRecomendations>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spDrugStores>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.DistrictId)
                    .HasName("IX_DistrictId");

                entity.HasIndex(e => e.RegionId)
                    .HasName("IX_RegionId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.AddressCheck).HasMaxLength(60);

                entity.Property(e => e.BankName).HasMaxLength(200);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.ExtraChargeDefault)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.Fax).HasMaxLength(200);

                entity.Property(e => e.INN).HasMaxLength(100);

                entity.Property(e => e.MFO).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OKONH).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(200);

                entity.Property(e => e.SettlementAccount).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.spDrugStores)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.spDrugStores_dbo.spDistricts_DistrictId");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.spDrugStores)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.spDrugStores_dbo.spRegions_RegionId");
            });

            modelBuilder.Entity<spDrugs>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Description)
                    .HasName("IX_Description");

                entity.HasIndex(e => e.DrugCategoryId)
                    .HasName("IX_DrugCategoryId");

                entity.HasIndex(e => e.ManufacturerId)
                    .HasName("IX_ManufacturerId");

                entity.HasIndex(e => e.PharmGroupId)
                    .HasName("IX_PharmGroupId");

                entity.HasIndex(e => e.ServerId)
                    .HasName("IX_ServerId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UnitId)
                    .HasName("IX_UnitId");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Barcode).HasMaxLength(255);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Dose).HasMaxLength(255);

                entity.Property(e => e.DrugRecomendation).HasMaxLength(2000);

                entity.Property(e => e.InternationalName).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Photo).HasMaxLength(255);

                entity.Property(e => e.Special).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VatRate).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.DrugCategory)
                    .WithMany(p => p.spDrugs)
                    .HasForeignKey(d => d.DrugCategoryId)
                    .HasConstraintName("FK_dbo.spDrugs_dbo.spDrugCategories_DrugCategoryId");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.spDrugs)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_dbo.spDrugs_dbo.spManufacturers_ManufacturerId");

                entity.HasOne(d => d.PharmGroup)
                    .WithMany(p => p.spDrugs)
                    .HasForeignKey(d => d.PharmGroupId)
                    .HasConstraintName("FK_dbo.spDrugs_dbo.spPharmGroups_PharmGroupId");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.spDrugs)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.spDrugs_dbo.spUnits_UnitId");
            });

            modelBuilder.Entity<spInsurances>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DpInfo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spManufacturers>(entity =>
            {
                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_CountryId");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.spManufacturers)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.spManufacturers_dbo.spCountries_CountryId");
            });

            modelBuilder.Entity<spOnlinePayments>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spOperationTypes>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spOrderStatus>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spPharmGroups>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spRegions>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spRoles>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spStatus>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spTableInfoes>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spTestTables>(entity =>
            {
                entity.Property(e => e.D1).HasColumnType("datetime");

                entity.Property(e => e.D2)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<spTypeOfPayments>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<spUnits>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tbBuyOnCredits>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditSumma).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurCreditSumma).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tbCards>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.DiscountId)
                    .HasName("IX_DiscountId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DpInfo).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.tbCards)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbCards_dbo.tbCustomers_CustomerId");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.tbCards)
                    .HasForeignKey(d => d.DiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbCards_dbo.tbDiscounts_DiscountId");
            });

            modelBuilder.Entity<tbCashExpenses>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DpInfo).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.tbCashExpenses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbCashExpenses_dbo.tbUsers_UserId");
            });

            modelBuilder.Entity<tbChangeHistories>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DpInfo).HasMaxLength(500);

                entity.Property(e => e.Piece).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceChange).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceCur).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceOld).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tbCustomers>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Patronymic).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(100);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tbDebtRepayments>(entity =>
            {
                entity.HasIndex(e => e.BuyOnCreditId)
                    .HasName("IX_BuyOnCreditId");

                entity.HasIndex(e => e.CashVoucherId)
                    .HasName("IX_CashVoucherId");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Summa).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.BuyOnCredit)
                    .WithMany(p => p.tbDebtRepayments)
                    .HasForeignKey(d => d.BuyOnCreditId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbDebtRepayments_dbo.tbBuyOnCredits_BuyOnCreditId");

                entity.HasOne(d => d.CashVoucher)
                    .WithMany(p => p.tbDebtRepayments)
                    .HasForeignKey(d => d.CashVoucherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbDebtRepayments_dbo.tbDocs_CashVoucherId");
            });

            modelBuilder.Entity<tbDefectures>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.DrugId)
                    .HasName("IX_DrugId");

                entity.HasIndex(e => e.OrderStatusId)
                    .HasName("IX_OrderStatusId");

                entity.HasIndex(e => e.QueryCount)
                    .HasName("IX_QueryCount");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.tbDefectures)
                    .HasForeignKey(d => d.DrugId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbDefectures_dbo.spDrugs_DrugId");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.tbDefectures)
                    .HasForeignKey(d => d.OrderStatusId)
                    .HasConstraintName("FK_dbo.tbDefectures_dbo.spOrderStatus_OrderStatusId");
            });

            modelBuilder.Entity<tbDiscounts>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.DiscountTypeId)
                    .HasName("IX_DiscountTypeId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DpInfo).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ValidityTo).HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.DiscountType)
                    .WithMany(p => p.tbDiscounts)
                    .HasForeignKey(d => d.DiscountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbDiscounts_dbo.spDiscountTypes_DiscountTypeId");
            });

            modelBuilder.Entity<tbDocItems>(entity =>
            {
                entity.HasIndex(e => e.AdditionalInfoId)
                    .HasName("IX_AdditionalInfoId");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.CurQty)
                    .HasName("IX_CurQty");

                entity.HasIndex(e => e.DocumentId)
                    .HasName("IX_DocumentId");

                entity.HasIndex(e => e.DrugId)
                    .HasName("IX_DrugId");

                entity.HasIndex(e => e.ExpiryDate)
                    .HasName("IX_ExpiryDate");

                entity.HasIndex(e => e.OperationTypeId)
                    .HasName("IX_OperationTypeId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.HasIndex(e => new { e.DrugId, e.CurQty, e.OperationTypeId })
                    .HasName("IDX_tbDocItems_OperationTypeId");

                entity.HasIndex(e => new { e.DrugId, e.OperationTypeId, e.CreateDate })
                    .HasName("IDX_tbDocItems");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BasePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BookingTimeTo).HasColumnType("datetime");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DpInfo).HasMaxLength(200);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ExtraCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncomingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SeriesNo).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.AdditionalInfo)
                    .WithMany(p => p.tbDocItems)
                    .HasForeignKey(d => d.AdditionalInfoId)
                    .HasConstraintName("FK_dbo.tbDocItems_dbo.tbDrugAdditionalInfoes_AdditionalInfoId");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.tbDocItems)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbDocItems_dbo.tbDocs_DocumentId");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.tbDocItems)
                    .HasForeignKey(d => d.DrugId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbDocItems_dbo.spDrugs_DrugId");

                entity.HasOne(d => d.OperationType)
                    .WithMany(p => p.tbDocItems)
                    .HasForeignKey(d => d.OperationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbDocItems_dbo.spOperationTypes_OperationTypeId");
            });

            modelBuilder.Entity<tbDocs>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.DiscountId)
                    .HasName("IX_DiscountId");

                entity.HasIndex(e => e.DistributorId)
                    .HasName("IX_DistributorId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiscountPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DocumentNo).HasMaxLength(20);

                entity.Property(e => e.PaymentByCard).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentByCash).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmountWithoutDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.tbDocs)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_dbo.tbDocs_dbo.tbDiscounts_DiscountId");

                entity.HasOne(d => d.Distributor)
                    .WithMany(p => p.tbDocs)
                    .HasForeignKey(d => d.DistributorId)
                    .HasConstraintName("FK_dbo.tbDocs_dbo.spDistributors_DistributorId");
            });

            modelBuilder.Entity<tbDrugAdditionalInfoes>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.InfoTypeId)
                    .HasName("IX_InfoTypeId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.InfoType)
                    .WithMany(p => p.tbDrugAdditionalInfoes)
                    .HasForeignKey(d => d.InfoTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbDrugAdditionalInfoes_dbo.spDrugAdditionalInfoes_InfoTypeId");
            });

            modelBuilder.Entity<tbEncashments>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DpInfo).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.tbEncashments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbEncashments_dbo.tbUsers_UserId");
            });

            modelBuilder.Entity<tbInventories>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.DpInfo)
                    .HasName("IX_DpInfo");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DpInfo).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tbInventoryCurrentLists>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.IncomingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tbInventoryItems>(entity =>
            {
                entity.HasIndex(e => e.ComingProductsItemId)
                    .HasName("IX_ComingProductsItemId");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.DrugId)
                    .HasName("IX_DrugId");

                entity.HasIndex(e => e.InventorytId)
                    .HasName("IX_InventorytId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ComingProductsItem)
                    .WithMany(p => p.tbInventoryItems)
                    .HasForeignKey(d => d.ComingProductsItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbInventoryItems_dbo.tbDocItems_ComingProductsItemId");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.tbInventoryItems)
                    .HasForeignKey(d => d.DrugId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbInventoryItems_dbo.spDrugs_DrugId");

                entity.HasOne(d => d.Inventoryt)
                    .WithMany(p => p.tbInventoryItems)
                    .HasForeignKey(d => d.InventorytId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbInventoryItems_dbo.tbInventories_InventorytId");
            });

            modelBuilder.Entity<tbLosses>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tbMandatoryDrugs>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.DrugId)
                    .HasName("IX_DrugId");

                entity.HasIndex(e => e.PriceItemId)
                    .HasName("IX_PriceItemId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.tbMandatoryDrugs)
                    .HasForeignKey(d => d.DrugId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbMandatoryDrugs_dbo.spDrugs_DrugId");

                entity.HasOne(d => d.PriceItem)
                    .WithMany(p => p.tbMandatoryDrugs)
                    .HasForeignKey(d => d.PriceItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbMandatoryDrugs_dbo.tbPriceItems_PriceItemId");
            });

            modelBuilder.Entity<tbMedicalInsurances>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.InsuranceId)
                    .HasName("IX_InsuranceId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsuranceCategory).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Patronymic).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Insurance)
                    .WithMany(p => p.tbMedicalInsurances)
                    .HasForeignKey(d => d.InsuranceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbMedicalInsurances_dbo.spInsurances_InsuranceId");
            });

            modelBuilder.Entity<tbMonitorSyncs>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<tbOnlinePaySystems>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DpInfo).HasMaxLength(100);

                entity.Property(e => e.PaySumma).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tbOrderItems>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.OrderId)
                    .HasName("IX_OrderId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DrugName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.tbOrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbOrderItems_dbo.tbOrders_OrderId");
            });

            modelBuilder.Entity<tbOrders>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tbPriceDocs>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.DistributorId)
                    .HasName("IX_DistributorId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PriceDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Distributor)
                    .WithMany(p => p.tbPriceDocs)
                    .HasForeignKey(d => d.DistributorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbPriceDocs_dbo.spDistributors_DistributorId");
            });

            modelBuilder.Entity<tbPriceItems>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.PriceDocId)
                    .HasName("IX_PriceDocId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BasePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ExtraCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rating)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SeriesNo).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VendorDrugName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.VendorManufacturer).HasMaxLength(200);

                entity.HasOne(d => d.PriceDoc)
                    .WithMany(p => p.tbPriceItems)
                    .HasForeignKey(d => d.PriceDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbPriceItems_dbo.tbPriceDocs_PriceDocId");
            });

            modelBuilder.Entity<tbReceipts>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.DocsId)
                    .HasName("IX_DocsId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Docs)
                    .WithMany(p => p.tbReceipts)
                    .HasForeignKey(d => d.DocsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbReceipts_dbo.tbDocs_DocsId");
            });

            modelBuilder.Entity<tbReturnOfProducts>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tbRevaluationOfDrugs>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExtraCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncomingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NewExtraCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NewPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tbSdachis>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.DocItemId)
                    .HasName("IX_DocItemId");

                entity.HasIndex(e => e.DrugId)
                    .HasName("IX_tbSdachi")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.DocItem)
                    .WithMany(p => p.tbSdachis)
                    .HasForeignKey(d => d.DocItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbSdachis_dbo.tbDocItems_DocItemId");
            });

            modelBuilder.Entity<tbSetups>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tbSmenas>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Begin).HasColumnType("datetime");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Expenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentByCard).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentByCash).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tbTurnovers>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.DrugId)
                    .HasName("IX_DrugId");

                entity.HasIndex(e => e.DrugStoreId)
                    .HasName("IX_DrugStoreId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentDate).HasColumnType("datetime");

                entity.Property(e => e.SeriesNo).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.tbTurnovers)
                    .HasForeignKey(d => d.DrugId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbTurnovers_dbo.spDrugs_DrugId");

                entity.HasOne(d => d.DrugStore)
                    .WithMany(p => p.tbTurnovers)
                    .HasForeignKey(d => d.DrugStoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbTurnovers_dbo.spDrugStores_DrugStore_Id");
            });

            modelBuilder.Entity<tbUsers>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CardNumber).HasMaxLength(10);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.tbUsers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.tbUsers_dbo.spRoles_RoleId");
            });

            modelBuilder.Entity<tbWriteOffs>(entity =>
            {
                entity.HasIndex(e => e.CreateDate)
                    .HasName("IX_CreateDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Status");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("IX_UpdateDate");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });
             
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
