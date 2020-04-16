using System;

namespace Apteka.SqlServer
{
    public partial class tbReturnOfProducts
    {
        public Guid Id { get; set; }
        public Guid? ComingProductId { get; set; }
        public int Qty { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }
    }
}
