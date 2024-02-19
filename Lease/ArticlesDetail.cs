using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using NSwag.Annotations;

namespace models.Lease
{
    public class ArticlesDetail()
    {
        [Required]
        public int serial { get; set; }
    }
}