using System;

namespace Apteka.SqlServer
{
    public partial class spTestTables
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime D1 { get; set; }
        public DateTime? D2 { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
