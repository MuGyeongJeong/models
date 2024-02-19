using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using NSwag.Annotations;

namespace models.Lease
{
    public class ArticlesCheckPassword()
    {
        [Required]
        public int serial { get; set; }
        [Required]
        public int password { get; set; }
    }
}
