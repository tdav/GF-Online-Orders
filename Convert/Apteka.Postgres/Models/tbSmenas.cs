using System;
using System.Collections.Generic;

namespace Apteka.Postgres
{
    public partial class tbSmenas
    {
        public Guid Id { get; set; }
        public Guid DrugStoreId { get; set; }
        public DateTime Begin { get; set; }
        public DateTime? End { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public string DpInfo { get; set; }
        public decimal PaymentByCard { get; set; }
        public decimal PaymentByCash { get; set; }
        public decimal Expenses { get; set; }
    }
}
