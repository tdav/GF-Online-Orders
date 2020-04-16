using System;
using System.Collections.Generic;

namespace Apteka.Postgres
{
    public partial class tbInventoryCurrentLists
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal IncomingPrice { get; set; }
        public int CurQty { get; set; }
        public Guid DocumentId { get; set; }
        public int OperationTypeId { get; set; }
        public string DrugName { get; set; }
        public string Barcode { get; set; }
        public int Piece { get; set; }
        public Guid? ManufacturerId { get; set; }
        public Guid DrugId { get; set; }
        public Guid? UnitId { get; set; }
        public string Manufacture { get; set; }
        public string Country { get; set; }
        public string Unit { get; set; }
        public string DrugCategory { get; set; }
        public int FactQty { get; set; }
        public int NedastachQty { get; set; }
        public int IzlishkQty { get; set; }
        public int KassaFactQty { get; set; }
        public int KassaChange { get; set; }
        public Guid InventoryDocId { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }
    }
}
