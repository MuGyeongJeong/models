using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class CategoryList()
    {
        public string? item_type { get; set; }
        public string? item_code { get; set; }
        public string? item_name { get; set; }
        public int item_depth { get; set; }
        public string? use_bit { get; set; }
    }
}