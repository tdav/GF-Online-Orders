using System;

namespace Apteka.SqlServer
{
    public partial class tbDefectures
    {
        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public int? OrderStatusId { get; set; }
        public Guid DrugStoreId { get; set; }
        public Guid DrugId { get; set; }
        public int QueryCount { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }

        public virtual spDrugs Drug { get; set; }
        public virtual spOrderStatus OrderStatus { get; set; }
    }
}
