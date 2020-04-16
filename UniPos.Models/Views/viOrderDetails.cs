namespace UniPos.Models.Views
{
    public class viOrderDetails
    {
        public int? Id { get; set; }
        public int Qty { get; set; }
        public int? ProductId { get; set; }

        public decimal Price { get; set; }
        public decimal TotalSum { get; set; }

        public string DrugName { get; set; }
    }
}