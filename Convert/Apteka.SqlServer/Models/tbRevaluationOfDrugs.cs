using System;

namespace Apteka.SqlServer
{
    public partial class tbRevaluationOfDrugs
    {
        public Guid Id { get; set; }
        public Guid? ComingProductId { get; set; }
        public int CurQty { get; set; }
        public decimal IncomingPrice { get; set; }
        public decimal ExtraCharge { get; set; }
        public decimal OldPrice { get; set; }
        public decimal Price { get; set; }
        public decimal NewExtraCharge { get; set; }
        public decimal NewPrice { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }
    }
}
