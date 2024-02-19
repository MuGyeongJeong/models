using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class CategorySetupSortNo()
    {
        public string? serial_number { get; set; }
        public string? modify_ip { get; set; }
        public string? item_depth { get; set; }
        public string? sort_no { get; set; }
        public string? parent_category_fk_serial { get; set; }
    }
}