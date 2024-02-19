using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class CategoryUpdateName()
    {
        public int serial { get; set; }
        public string? item_name { get; set; }
        public string? modify_ip { get; set; }
    }
}