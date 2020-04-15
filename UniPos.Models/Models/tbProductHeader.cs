using System;
using System.ComponentModel.DataAnnotations;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Основной документ (заголовок)
    /// </summary>
    public class tbProductHeader : BaseModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Туланиши керак булган ва кириб келган жами сумма
        /// </summary>        
        [Required]
        public decimal Summa { get; set; }

        [Required]
        public int ItemQty { get; set; }

        [StringLength(20)]
        public string DocumentNo { get; set; }

    }
}
