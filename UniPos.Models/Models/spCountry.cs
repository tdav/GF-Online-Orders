using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Государство
    /// </summary>
    public class spCountry : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }


    }
}
