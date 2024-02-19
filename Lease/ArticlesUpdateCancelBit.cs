using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using NSwag.Annotations;

namespace models.Lease
{
    public class ArticlesUpdateCancelBit()
    {
        [Required]
        public int serial_number { get; set; }
        [Required]
        public int cancel_reason { get; set; }
    }
}