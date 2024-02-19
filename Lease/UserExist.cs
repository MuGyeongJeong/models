using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class UserExist()
    {
        [Required]
        public string? user_id { get; set; }
    }
}