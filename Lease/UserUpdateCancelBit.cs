using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class UserUpdateCancelBit()
    {
        [Required]
        public int serial { get; set; }
        [Required]
        public string? cancel_bit { get; set; }
        [Required]
        public string? cancel_reason { get; set; }
    }
}