using System.ComponentModel.DataAnnotations;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Основной документ (заголовок)
    /// </summary>
    public class tbProductHeader : BaseModel
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string DocumentNo { get; set; }

    }
}
