namespace UniPos.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class tbOrderDetails:BaseModel
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public int DrugId { get; set; }
        public spDrug Drug { get; set; }


    }
}
