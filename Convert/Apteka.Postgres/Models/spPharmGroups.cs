using System;
using System.Collections.Generic;

namespace Apteka.Postgres
{
    public partial class spPharmGroups
    {
        public spPharmGroups()
        {
            spDrugs = new HashSet<spDrugs>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }

        public virtual ICollection<spDrugs> spDrugs { get; set; }
    }
}
