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


        public int AddressId { get; set; }
        public tbAddress Address { get; set; }


        [StringLength(200)]
        public string Description { get; set; }

        /// <summary>
        /// Время доставки
        /// </summary>
        [Required]
        public DateTime DeliveryTime { get; set; }


        /// <summary>
        /// Доставка тури
        /// </summary>
        [Required]
        public int DeliveryTypeId { get; set; }

        public spDeliveryType DeliveryType { get; set;}

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
