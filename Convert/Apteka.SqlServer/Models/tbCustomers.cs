using System;
using System.Collections.Generic;

namespace Apteka.SqlServer
{
    public partial class tbCustomers
    {
        public tbCustomers()
        {
            tbCards = new HashSet<tbCards>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public Guid DrugStoreId { get; set; }

        public virtual ICollection<tbCards> tbCards { get; set; }
    }
}
