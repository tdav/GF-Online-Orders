using System;
using System.Collections.Generic;

namespace Apteka.Postgres
{
    public partial class spRoles
    {
        public spRoles()
        {
            tbUsers = new HashSet<tbUsers>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserAccess { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }

        public virtual ICollection<tbUsers> tbUsers { get; set; }
    }
}
