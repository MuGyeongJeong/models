using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class BoardUpdateCancelBit()
    {
        [Required]
        public int serial_number { get; set; }
        [Required]
        public string? cancel_bit { get; set; }
        [Required]
        public string? cancel_reason { get; set; }
    }
}