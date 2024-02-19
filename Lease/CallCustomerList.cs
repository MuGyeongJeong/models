using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using NSwag.Annotations;

namespace models.Lease
{
    public class CallCustomerList()
    {
        public string? customer_type { get; set; }
        public string? rider_cd { get; set; }
        public string? rider_nm { get; set; }
        public string? rider_cid { get; set; }
        public string? bike_id { get; set; }
        public string? bike_ssn { get; set; }
        [Required]
        public int row_size { get; set; }
        [Required]
        public int current_page { get; set; }
    }
}