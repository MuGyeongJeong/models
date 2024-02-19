using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class UserData()
    {
        public string? user_id { get; set; }
        public string? use_bit { get; set; }
        public string? service_type { get; set; }
        public string? user_type { get; set; }
        [Required]
        public ushort row_size { get; set; }
        [Required]
        public ushort current_page { get; set; }
    }
}