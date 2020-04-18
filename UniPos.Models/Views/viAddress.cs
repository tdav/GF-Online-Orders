namespace UniPos.Models
{
    public class viAddress : BaseModel
    {
        public int Id { get; set; }

        public int RegionId { get; set; }
        public string RegionName { get; set; }

        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public string Waymark { get; set; }



        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public string? Description { get; set; }
    }
}
