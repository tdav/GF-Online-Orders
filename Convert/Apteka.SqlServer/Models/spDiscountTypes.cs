using System;
using System.Collections.Generic;

namespace Apteka.SqlServer
{
    public partial class spDiscountTypes
    {
        public spDiscountTypes()
        {
            tbDiscounts = new HashSet<tbDiscounts>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DpInfo { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }

        public virtual ICollection<tbDiscounts> tbDiscounts { get; set; }
    }
}
