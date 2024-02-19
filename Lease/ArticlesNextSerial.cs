using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using NSwag.Annotations;

namespace models.Lease
{
    public class ArticlesNextSerial()
    {
        [Required]
        public string? board_id { get; set; }
    }
}