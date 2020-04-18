using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniPos.Models
{
    /// <summary>
    /// ������� ��� ��������
    /// </summary>
    public partial class spDeliveryType : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public decimal Cost { get; set; }
        public int DeliveryTime { get; set; }


    }
}
