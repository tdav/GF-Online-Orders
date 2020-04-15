using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Статус заказа
    /// </summary>
    public class spOrderStatus : BaseModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}
