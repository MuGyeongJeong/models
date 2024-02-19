using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using NSwag.Annotations;

namespace models.Lease
{
    public class ArticlesList()
    {
        public string? query { get; set; }
        [Required]
        public int row_size { get; set; }
        [Required]
        public int current_page { get; set; }
    }
}