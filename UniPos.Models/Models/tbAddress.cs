
using System.ComponentModel.DataAnnotations;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Адресс
    /// </summary>
    public class tbAddress : BaseModel
    {
        public int Id { get; set; }

        public int RegionId { get; set; }

        public int DistrictId { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        /// <summary>
        /// Дом
        /// </summary>
        [StringLength(10)]
        public string House { get; set; }

        /// <summary>
        /// Квартира
        /// </summary>
        [StringLength(10)]
        public string? Flat { get; set; }


        /// <summary>
        /// Ориентир
        /// </summary>
        [StringLength(500)]       
        public string? Waymark { get; set; }


        public decimal Latitude { get; set; }
        
        public decimal Longitude { get; set; }

        [StringLength(100)]
        public string? Description { get; set; }
    }
}
