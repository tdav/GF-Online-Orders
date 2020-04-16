using System;
using System.Collections.Generic;

namespace Apteka.SqlServer
{
    public partial class tbDiscounts
    {
        public tbDiscounts()
        {
            tbCards = new HashSet<tbCards>();
            tbDocs = new HashSet<tbDocs>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public decimal Value { get; set; }
        public DateTime ValidityTo { get; set; }
        public Guid DiscountTypeId { get; set; }
        public string DpInfo { get; set; }
        public Guid DrugStoreId { get; set; }

        public virtual spDiscountTypes DiscountType { get; set; }
        public virtual ICollection<tbCards> tbCards { get; set; }
        public virtual ICollection<tbDocs> tbDocs { get; set; }
    }
}
