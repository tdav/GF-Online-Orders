using System;
using System.Collections.Generic;

namespace Apteka.Postgres
{
    public partial class tbDrugAdditionalInfoes
    {
        public tbDrugAdditionalInfoes()
        {
            tbDocItems = new HashSet<tbDocItems>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public int InfoTypeId { get; set; }
        public string Data { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }

        public virtual spDrugAdditionalInfoes InfoType { get; set; }
        public virtual ICollection<tbDocItems> tbDocItems { get; set; }
    }
}
