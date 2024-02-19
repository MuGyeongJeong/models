using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class CategoryInsert()
    {
        public string? regist_ip { get; set; }
        public string? item_type { get; set; }
        public string? item_code { get; set; }
        public string? item_name { get; set; }
        public int item_depth { get; set; }
        public int sort_no { get; set; }
        public int parent_category_fk_serial { get; set; }
        public string? memo { get; set; }
    }
}