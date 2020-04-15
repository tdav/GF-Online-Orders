using System.ComponentModel.DataAnnotations;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Тип оплаты
    /// </summary>
    public class spPayment : BaseModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name{ get; set; }
    }
}
