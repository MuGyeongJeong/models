using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class BoardList()
    {
        public string? board_id { get; set; }
        public string? board_type { get; set; }
        public string? use_bit { get; set; }
        [Required]
        public int row_size { get; set; }
        [Required]
        public int current_page { get; set; }
    }
}