using System;
using System.Collections.Generic;

namespace Apteka.SqlServer
{
    public partial class tbPriceDocs
    {
        public tbPriceDocs()
        {
            tbPriceItems = new HashSet<tbPriceItems>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public Guid DistributorId { get; set; }
        public string Description { get; set; }
        public DateTime PriceDate { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }

        public virtual spDistributors Distributor { get; set; }
        public virtual ICollection<tbPriceItems> tbPriceItems { get; set; }
    }
}
