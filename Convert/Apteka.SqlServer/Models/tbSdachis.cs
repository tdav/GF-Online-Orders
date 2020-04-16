using System;

namespace Apteka.SqlServer
{
    public partial class tbSdachis
    {
        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public Guid DrugId { get; set; }
        public Guid DrugStoreId { get; set; }
        public Guid DocItemId { get; set; }
        public decimal Price { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }

        public virtual tbDocItems DocItem { get; set; }
    }
}
