using System;
using System.Collections.Generic;

namespace Apteka.Postgres
{
    public partial class spTableInfoes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Version { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Json { get; set; }
    }
}
