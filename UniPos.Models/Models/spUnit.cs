using System;
using System.ComponentModel.DataAnnotations;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Форма выпуска
    /// </summary>
    public class spUnit : BaseModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public int? ServerId { get; set; }

        /// <summary>
        /// Штучно сотиш мумкин ёки йук
        /// </summary>
        public int Impartible { get; set; }
    }
}
