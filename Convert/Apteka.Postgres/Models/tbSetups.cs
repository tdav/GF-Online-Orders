using System;
using System.Collections.Generic;

namespace Apteka.Postgres
{
    public partial class tbSetups
    {
        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public string JsonGlobalSystemConfig { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }
        public Guid DrugStoreId { get; set; }
    }
}
