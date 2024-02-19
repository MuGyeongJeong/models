using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class CodeCategoryList()
    {
        [Required]
        [DefaultValue("고객구분")]
        public string? category { get; set; }
        [Required]
        [DefaultValue("Y")]
        public string? use_bit { get; set; }
    }
}