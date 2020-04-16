using System;
using System.Collections.Generic;

namespace Apteka.Postgres
{
    public partial class tbOrders
    {
        public tbOrders()
        {
            tbOrderItems = new HashSet<tbOrderItems>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public DateTime Created { get; set; }
        public DateTime DeliveryTime { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }

        public virtual ICollection<tbOrderItems> tbOrderItems { get; set; }
    }
}
