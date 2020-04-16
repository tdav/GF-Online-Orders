using System;
using System.Collections.Generic;
using System.Text;

namespace UniPos.Models.Views
{
    public class viOrder
    {
        public int? Id { get; set; }
        public int DrugStoreId { get; set; }
        public string DrugStoreName { get; set; }
        public int? RegionId { get; set; }
        public int? DistrictId { get; set; }
        public int AddressId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Description { get; set; }
        public DateTime DeliveryTime { get; set; }
        public int OrderStatusId { get; set; }
        public string OrderStatusName { get; set; }
        public int PaymentId { get; set; }
        public string PaymentName { get; set; }
        public int UserAgentId { get; set; }
        public string UserAgentName { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<viOrderDetails> OrderDetails { get; set; }
    }
}
