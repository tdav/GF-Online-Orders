using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Аптека или склад
    /// </summary>
    public class spDrugStore : BaseModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Phone { get; set; }


        [Required]
        public int RegionId { get; set; }
        public spRegion Region { get; set; }

        [Required]
        public int DistrictId { get; set; }
        public spDistrict District { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
