using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class UserDataDetailToken()
    {
        [Required]
        public string? access_token { get; set; }
    }
}