using System;

namespace Apteka.SqlServer
{
    public partial class tbMandatoryDrugs
    {
        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public Guid DrugId { get; set; }
        public Guid PriceItemId { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }

        public virtual spDrugs Drug { get; set; }
        public virtual tbPriceItems PriceItem { get; set; }
    }
}
