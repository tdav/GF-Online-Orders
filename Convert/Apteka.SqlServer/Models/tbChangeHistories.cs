using System;

namespace Apteka.SqlServer
{
    public partial class tbChangeHistories
    {
        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public Guid EntityId { get; set; }
        public string DpInfo { get; set; }
        public int OperationTypeId { get; set; }
        public decimal Piece { get; set; }
        public int QtyOld { get; set; }
        public decimal PriceOld { get; set; }
        public int QtyChange { get; set; }
        public decimal PriceChange { get; set; }
        public int QtyCur { get; set; }
        public decimal PriceCur { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }
    }
}
