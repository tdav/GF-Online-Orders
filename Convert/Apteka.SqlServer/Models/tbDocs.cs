using System;
using System.Collections.Generic;

namespace Apteka.SqlServer
{
    public partial class tbDocs
    {
        public tbDocs()
        {
            tbDebtRepayments = new HashSet<tbDebtRepayments>();
            tbDocItems = new HashSet<tbDocItems>();
            tbReceipts = new HashSet<tbReceipts>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalDrugs { get; set; }
        public Guid DrugStoreId { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public string DocumentNo { get; set; }
        public Guid? DistributorId { get; set; }
        public decimal? PaymentByCard { get; set; }
        public decimal? PaymentByCash { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? TotalAmountWithoutDiscount { get; set; }
        public Guid? DiscountId { get; set; }
        public string Discriminator { get; set; }
        public int? TypeOfPayments { get; set; }
        public int? OnlinePayments { get; set; }

        public virtual tbDiscounts Discount { get; set; }
        public virtual spDistributors Distributor { get; set; }
        public virtual ICollection<tbDebtRepayments> tbDebtRepayments { get; set; }
        public virtual ICollection<tbDocItems> tbDocItems { get; set; }
        public virtual ICollection<tbReceipts> tbReceipts { get; set; }
    }
}
