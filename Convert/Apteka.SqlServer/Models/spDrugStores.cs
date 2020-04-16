using System;
using System.Collections.Generic;

namespace Apteka.SqlServer
{
    public partial class spDrugStores
    {
        public spDrugStores()
        {
            tbTurnovers = new HashSet<tbTurnovers>();
        }

        public Guid Id { get; set; }
        public int? ServerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string INN { get; set; }
        public string MFO { get; set; }
        public string OKONH { get; set; }
        public string BankName { get; set; }
        public string SettlementAccount { get; set; }
        public int RegionId { get; set; }
        public int DistrictId { get; set; }
        public string Address { get; set; }
        public string AddressCheck { get; set; }
        public decimal ExtraChargeDefault { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public int Send { get; set; }

        public virtual spDistricts District { get; set; }
        public virtual spRegions Region { get; set; }
        public virtual ICollection<tbTurnovers> tbTurnovers { get; set; }
    }
}
