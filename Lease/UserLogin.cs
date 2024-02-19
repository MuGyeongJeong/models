using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class UserLogin()
    {
        [Required]
        public string? user_id { get; set; }
        [Required]
        public string? password { get; set; }
    }
}