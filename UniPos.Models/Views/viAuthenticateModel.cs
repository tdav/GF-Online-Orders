using System.ComponentModel.DataAnnotations;

namespace UniPos.Models
{
    public class viAuthenticateModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
