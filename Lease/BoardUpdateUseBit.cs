using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class BoardUpdateUseBit()
    {
        [Required]
        public int serial_number { get; set; }
        [Required]
        public string? use_bit { get; set; }
    }
}