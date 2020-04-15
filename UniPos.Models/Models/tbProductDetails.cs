using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Основной документ (детали)
    /// </summary>
    public class tbProductDetails : BaseModel
    {
        public int Id { get; set; }

        /// <summary>
        /// [R] DtId - Документ ID си
        /// </summary>
        [Required]
        public int ProductHeaderId { get; set; }
        public tbProductHeader ProductHeader { get; set; }

        /// <summary>
        /// [R] ProductId - Товарни ID си товарлар справосникдан
        /// </summary>
        [Required]
        public int DrugId { get; set; }
        public spDrug Drug { get; set; }

        /// <summary>
        /// [R] товарни  серияси
        /// </summary>       
        [StringLength(50)]
        public string SeriesNo { get; set; }

        /// <summary>
        /// [R] товарни сони (бошлангич сони)
        /// </summary>
        [Required]
        public int Qty { get; set; }

        /// <summary>
        ///  хозирги товарни сони (сотилганда камайяди)
        /// </summary>        
        [DisplayName("хозирги товарни сони (сотилганда камайяди)")]
        [ConcurrencyCheck]
        [Index]
        public int CurQty { get; set; }

        /// <summary>
        /// [R] Цена для продажи
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// НДС
        /// </summary>
        public decimal Vat { get; set; }

        /// <summary>
        /// [R] срок годности
        /// </summary>
        [Index]
        [Required]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Базовая цена
        /// </summary>
        public decimal? BasePrice { get; set; }

        /// <summary>
        /// Приходная цена
        /// </summary>
        [Required]
        public decimal IncomingPrice { get; set; }

        /// <summary>
        /// надбавка
        /// </summary>
        [Required]
        public decimal ExtraCharge { get; set; }

        /// <summary>
        /// Продажада - Шу дорининг жами суммаси
        /// </summary>              
        public decimal TotalAmount { get; set; }

    }
}
