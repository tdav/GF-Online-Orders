using System;
using System.Collections.Generic;

namespace Apteka.SqlServer
{
    public partial class tbInventories
    {
        public tbInventories()
        {
            tbInventoryItems = new HashSet<tbInventoryItems>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public Guid DrugStoreId { get; set; }
        public string DpInfo { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }

        public virtual ICollection<tbInventoryItems> tbInventoryItems { get; set; }
    }
}
