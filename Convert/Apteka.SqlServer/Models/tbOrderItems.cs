using System;

namespace Apteka.SqlServer
{
    public partial class tbOrderItems
    {
        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public Guid OrderId { get; set; }
        public string DrugName { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }

        public virtual tbOrders Order { get; set; }
    }
}
