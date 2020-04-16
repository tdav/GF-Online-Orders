using System;
using System.Collections.Generic;
using System.Text;

namespace UniPos.Models.Views
{
    public class viProduct
    {
        public int Id { get; set; }

        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public string Manufacturer { get; set; }
        public int Qty { get; set; }
        public int Piece { get; set; }
        public decimal Price { get; set; }
        public decimal Vat { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
