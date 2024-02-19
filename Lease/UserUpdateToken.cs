using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class UserUpdateToken()
    {
        [Required]
        public int serial { get; set; }
        [Required]
        public string? access_token { get; set; }
    }
}