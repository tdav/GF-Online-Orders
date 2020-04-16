using System.ComponentModel.DataAnnotations;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Роли пользователь
    /// </summary>
    public partial class spRole : BaseModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string UserAccess { get; set; }
    }
}
