using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Область
    /// </summary>
    public class spRegion : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public ICollection<spDistrict> Districts { get; set; }
    }
}
