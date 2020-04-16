using System;
using System.Collections.Generic;

namespace Apteka.SqlServer
{
    public partial class tbBuyOnCredits
    {
        public tbBuyOnCredits()
        {
            tbDebtRepayments = new HashSet<tbDebtRepayments>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal CurCreditSumma { get; set; }
        public decimal CreditSumma { get; set; }
        public Guid CustomerId { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }
        public Guid DocId { get; set; }

        public virtual ICollection<tbDebtRepayments> tbDebtRepayments { get; set; }
    }
}
