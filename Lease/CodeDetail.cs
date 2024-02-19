using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class CodeDetail()
    {
        [Required]
        public int serial { get; set; }
    }
}