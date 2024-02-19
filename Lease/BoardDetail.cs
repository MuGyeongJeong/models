using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class BoardDetail()
    {
        [Required]
        public int serial { get; set; }
    }
}