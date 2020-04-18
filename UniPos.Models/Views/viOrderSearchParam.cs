using System;
using System.Collections.Generic;
using System.Text;

namespace UniPos.Models.Views
{
    public class viOrderSearchParam
    {
        public int? OrderId { get; set; }
        public int? DrugStoreId { get; set; }
        public int? DistrictId { get; set; }
        public DateTime? DeliveryTime1 { get; set; }
        public DateTime? DeliveryTime2 { get; set; }
        public int? OrderStatusId { get; set; }
        public int? PaymentId { get; set; }
        public int? UserAgentId { get; set; }
        public int? CreateUser { get; set; }
        public DateTime? CreateDate1 { get; set; }
        public DateTime? CreateDate2 { get; set; }

        public string Phone { get; set; }
    }
}
