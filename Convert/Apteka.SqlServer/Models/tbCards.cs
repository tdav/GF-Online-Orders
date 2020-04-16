using System;

namespace Apteka.SqlServer
{
    public partial class tbCards
    {
        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public string CardNo { get; set; }
        public Guid DiscountId { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid CustomerId { get; set; }
        public string DpInfo { get; set; }
        public Guid DrugStoreId { get; set; }

        public virtual tbCustomers Customer { get; set; }
        public virtual tbDiscounts Discount { get; set; }
    }
}
