using System.ComponentModel.DataAnnotations;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Пользователи
    /// </summary>
    public class tbUser : BaseModel
    {
        [Required]
        public int Id { get; set; }
        
        [StringLength(100)]
        public string FirstName { get; set; }
        
        [StringLength(100)]
        public string LastName { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Password { get; set; }



        [StringLength(20)]
        public string Phone { get; set; }



        [Required]
        public int RoleId { get; set; }
        public spRole Role { get; set; }

    }
}
