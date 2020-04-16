using System;
using System.Collections.Generic;

namespace Apteka.SqlServer
{
    public partial class tbUsers
    {
        public tbUsers()
        {
            tbCashExpenses = new HashSet<tbCashExpenses>();
            tbEncashments = new HashSet<tbEncashments>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Guid RoleId { get; set; }
        public string CardNumber { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }

        public virtual spRoles Role { get; set; }
        public virtual ICollection<tbCashExpenses> tbCashExpenses { get; set; }
        public virtual ICollection<tbEncashments> tbEncashments { get; set; }
    }
}
