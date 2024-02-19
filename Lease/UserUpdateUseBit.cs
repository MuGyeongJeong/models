using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class UserUpdateUserBit()
    {
        [Required]
        public int serial { get; set; }
        [Required]
        public string? use_bit { get; set; }
    }
}