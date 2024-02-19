using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class UserDataID()
    {
        [Required]
        public string? user_id { get; set; }
    }
}