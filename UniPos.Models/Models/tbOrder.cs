using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Online Заказ детали
    /// </summary>
    public class tbOrderHeader : BaseModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Кайси складдан олиб чикилди
        /// </summary>
        public int DrugStoreId { get; set; }
        public spDrugStore DrugStore { get; set; }


        public int? RegionId { get; set; }

        public int? DistrictId { get; set; }

        [StringLength(500)]
        public string Address { get; set; }    
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        /// <summary>
        /// Время доставки
        /// </summary>
        [Required]
        public DateTime DeliveryTime { get; set; }

        [Required]
        public int OrderStatusId { get; set; }
        public spOrderStatus OrderStatus { get; set; }

        [Required]
        public int PaymentId {get;set;}
        public spPayment Payment {get;set;}

        public spUserAgent UserAgent { get; set; }
        public int UserAgentId { get; set; }

        /// <summary>
        /// Кол. асартимент товара
        /// </summary>
        public int ItemQty { get; set; }

        /// <summary>
        /// Сумма 
        /// </summary>
        public decimal Summa { get; set; }

        public ICollection<tbOrderDetails> OrderDetails { get; set; }
    }
}
