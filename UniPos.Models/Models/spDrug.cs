using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Лекарственное средство
    /// </summary>
    public class spDrug : BaseModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Баркоди товаров
        /// </summary>
        [StringLength(255)]
        //[Index()]
        public string Barcode { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        [Index()]
        public string Description { get; set; }

        [StringLength(255)]
        public string InternationalName { get; set; }

        /// <summary>
        /// доза лекарства
        /// </summary>
        [StringLength(255)]
        public string Dose { get; set; }

        /// <summary>
        /// Ишлабчикаручи
        /// </summary>
        public int? ManufacturerId { get; set; }
        public virtual spManufacturer Manufacturer { get; set; }

        /// <summary>
        /// Дори категорияси
        /// </summary>
        public int? DrugCategoryId { get; set; }
        public virtual spDrugCategory DrugCategory { get; set; }

        public int? PharmGroupId { get; set; }
        public virtual spPharmGroup PharmGroup { get; set; }

        /// <summary>
        ///  Почкадаги донаси
        /// </summary>
        [Required]
        public int Piece { get; set; }

        /// <summary>
        ///  Улчов бирлиги
        /// </summary>
        [Required]
        public int UnitId { get; set; }
        public virtual spUnit Unit { get; set; }

        /// <summary>
        /// Под учетные лекарство
        /// </summary>
        [DefaultValue(0)]
        public int? Special { get; set; }

        [StringLength(255)]
        public string Photo { get; set; }

        /// <summary>
        /// ставка ндс
        /// </summary>
        public decimal VatRate { get; set; }

        [StringLength(2000)]
        public string DrugRecomendation { get; set; }

       

    }
}
