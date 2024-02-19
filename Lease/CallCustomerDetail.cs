using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using NSwag.Annotations;

namespace models.Lease
{
    public class CallCustomerDetail()
    {
        [Required]
        public int serial { get; set; }
        [Required]
        public int rider_cd { get; set; }
    }
}