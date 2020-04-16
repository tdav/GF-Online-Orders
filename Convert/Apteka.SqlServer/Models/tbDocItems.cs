using System;
using System.Collections.Generic;

namespace Apteka.SqlServer
{
    public partial class tbDocItems
    {
        public tbDocItems()
        {
            tbInventoryItems = new HashSet<tbInventoryItems>();
            tbSdachis = new HashSet<tbSdachis>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public Guid DocumentId { get; set; }
        public Guid DrugId { get; set; }
        public string SeriesNo { get; set; }
        public int Qty { get; set; }
        public int CurQty { get; set; }
        public decimal Price { get; set; }
        public decimal Vat { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int OperationTypeId { get; set; }
        public Guid? ComingProductId { get; set; }
        public decimal? BasePrice { get; set; }
        public decimal IncomingPrice { get; set; }
        public decimal ExtraCharge { get; set; }
        public decimal TotalAmount { get; set; }
        public Guid? AdditionalInfoId { get; set; }
        public string DpInfo { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public byte[] RowVersion { get; set; }
        public string Discriminator { get; set; }
        public string BookingCustomerName { get; set; }
        public DateTime? BookingTimeTo { get; set; }
        public Guid DrugStoreId { get; set; }

        public virtual tbDrugAdditionalInfoes AdditionalInfo { get; set; }
        public virtual tbDocs Document { get; set; }
        public virtual spDrugs Drug { get; set; }
        public virtual spOperationTypes OperationType { get; set; }
        public virtual ICollection<tbInventoryItems> tbInventoryItems { get; set; }
        public virtual ICollection<tbSdachis> tbSdachis { get; set; }
    }
}
