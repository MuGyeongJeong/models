using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class CategoryDetail()
    {
        [Required]
        public int serial { get; set; }
    }
}