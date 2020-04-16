namespace UniPos.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class tbOrderDetails : BaseModel
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal TotalSum { get; set; }
        public int ProductId { get; set; }
        public tbProductDetails Product { get; set; }


    }
}
