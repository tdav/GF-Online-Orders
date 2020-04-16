using System;

namespace Apteka.SqlServer
{
    public partial class spTypeOfPayments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
    }
}
