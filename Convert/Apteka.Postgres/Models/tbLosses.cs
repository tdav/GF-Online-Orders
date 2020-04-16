using System;
using System.Collections.Generic;

namespace Apteka.Postgres
{
    public partial class tbLosses
    {
        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public decimal Amount { get; set; }
        public string Descriptin { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }
    }
}
