using System;
using System.Collections.Generic;

namespace Apteka.SqlServer
{
    public partial class tbPriceItems
    {
        public tbPriceItems()
        {
            tbMandatoryDrugs = new HashSet<tbMandatoryDrugs>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public Guid PriceDocId { get; set; }
        public Guid DrugId { get; set; }
        public string VendorDrugName { get; set; }
        public decimal BasePrice { get; set; }
        public decimal ExtraCharge { get; set; }
        public decimal Price { get; set; }
        public int Piece { get; set; }
        public int Qty { get; set; }
        public decimal? Vat { get; set; }
        public decimal Rating { get; set; }
        public string SeriesNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public Guid? ManufacturerId { get; set; }
        public string VendorManufacturer { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }

        public virtual tbPriceDocs PriceDoc { get; set; }
        public virtual ICollection<tbMandatoryDrugs> tbMandatoryDrugs { get; set; }
    }
}
