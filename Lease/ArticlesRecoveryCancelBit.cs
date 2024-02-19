using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using NSwag.Annotations;

namespace models.Lease
{
    public class ArticlesRecoveryCancelBit()
    {
        [Required]
        public int serial_number { get; set; }
    }
}