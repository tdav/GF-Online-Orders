using System;

namespace Apteka.SqlServer
{
    public partial class tbTurnovers
    {
        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public DateTime CurrentDate { get; set; }
        public Guid DrugId { get; set; }
        public string SeriesNo { get; set; }
        public Guid DrugStorId { get; set; }
        public int BalanceStart { get; set; }
        public int Coming { get; set; }
        public int WriteOff { get; set; }
        public int Sale { get; set; }
        public int Back { get; set; }
        public int BalanceEnd { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }

        public virtual spDrugs Drug { get; set; }
        public virtual spDrugStores DrugStore { get; set; }
    }
}
