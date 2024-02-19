using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class AttachUpdateCancelBit()
    {
        [Required]
        public int serial_number { get; set; }
        [Required]
        public int article_serial { get; set; }
    }
}