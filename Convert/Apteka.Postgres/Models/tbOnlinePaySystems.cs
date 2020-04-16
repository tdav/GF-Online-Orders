using System;
using System.Collections.Generic;

namespace Apteka.Postgres
{
    public partial class tbOnlinePaySystems
    {
        public Guid Id { get; set; }
        public Guid DocId { get; set; }
        public int? ServerId { get; set; }
        public int OnlinePaymentId { get; set; }
        public decimal PaySumma { get; set; }
        public string DpInfo { get; set; }
        public Guid DrugStoreId { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
    }
}
