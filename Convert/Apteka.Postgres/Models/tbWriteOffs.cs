using System;
using System.Collections.Generic;

namespace Apteka.Postgres
{
    public partial class tbWriteOffs
    {
        public Guid Id { get; set; }
        public Guid? ComingProductId { get; set; }
        public int CurQty { get; set; }
        public int WriteOffQty { get; set; }
        public string Comment { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }
    }
}
