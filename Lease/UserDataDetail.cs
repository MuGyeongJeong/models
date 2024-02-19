using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class UserDataDetail()
    {
        [Required]
        public int serial { get; set; }
    }
}