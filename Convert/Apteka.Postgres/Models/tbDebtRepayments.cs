using System;
using System.Collections.Generic;

namespace Apteka.Postgres
{
    public partial class tbDebtRepayments
    {
        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public decimal Summa { get; set; }
        public Guid BuyOnCreditId { get; set; }
        public Guid CashVoucherId { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }

        public virtual tbBuyOnCredits BuyOnCredit { get; set; }
        public virtual tbDocs CashVoucher { get; set; }
    }
}
