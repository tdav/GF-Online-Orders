using System;
using System.Collections.Generic;

namespace Apteka.Postgres
{
    public partial class spDrugAdditionalInfoes
    {
        public spDrugAdditionalInfoes()
        {
            tbDrugAdditionalInfoes = new HashSet<tbDrugAdditionalInfoes>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }

        public virtual ICollection<tbDrugAdditionalInfoes> tbDrugAdditionalInfoes { get; set; }
    }
}
