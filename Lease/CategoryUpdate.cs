using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class CategoryUpdate()
    {
        public int serial_number { get; set; }

        public DateTime regist_date { get; set; }

        public string? regist_ip { get; set; }

        public DateTime modify_date { get; set; }

        public string? modify_ip { get; set; }

        public string? cancel_bit { get; set; }

        public string? cancel_reason { get; set; }

        public string? use_bit { get; set; }

        public string? item_type { get; set; }

        public string? item_code { get; set; }

        public string? item_name { get; set; }

        public int item_depth { get; set; }

        public int sort_no { get; set; }

        public int parent_category_fk_serial { get; set; }

        public string? memo { get; set; }
    }
}