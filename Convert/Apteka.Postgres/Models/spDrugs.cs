using Apteka.Postgres.Utils;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apteka.Postgres
{
    public partial class spDrugs
    {
        public spDrugs()
        {
            tbDefectures = new HashSet<tbDefectures>();
            tbDocItems = new HashSet<tbDocItems>();
            tbInventoryItems = new HashSet<tbInventoryItems>();
            tbMandatoryDrugs = new HashSet<tbMandatoryDrugs>();
            tbTurnovers = new HashSet<tbTurnovers>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string InternationalName { get; set; }
        public string Dose { get; set; }
        public Guid? ManufacturerId { get; set; }
        public Guid? DrugCategoryId { get; set; }
        public Guid? PharmGroupId { get; set; }
        public int Piece { get; set; }
        public Guid UnitId { get; set; }
        public int? Special { get; set; }
        public string Photo { get; set; }
        public decimal VatRate { get; set; }
        public string DrugRecomendation { get; set; }
        public Guid? RealId { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }

        public virtual spDrugCategories DrugCategory { get; set; }
        public virtual spManufacturers Manufacturer { get; set; }
        public virtual spPharmGroups PharmGroup { get; set; }
        public virtual spUnits Unit { get; set; }
        public virtual ICollection<tbDefectures> tbDefectures { get; set; }
        public virtual ICollection<tbDocItems> tbDocItems { get; set; }
        public virtual ICollection<tbInventoryItems> tbInventoryItems { get; set; }
        public virtual ICollection<tbMandatoryDrugs> tbMandatoryDrugs { get; set; }
        public virtual ICollection<tbTurnovers> tbTurnovers { get; set; }


        [Column(TypeName = "jsonb")]
        public jbDrugNameParsed NameParsed { get; set; }

        public NpgsqlTsVector SearchVector { get; set; }
    }
}
