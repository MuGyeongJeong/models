using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using NSwag.Annotations;

namespace models.Lease
{
    public class CallCustomerUpdate()
    {
        public string? serial_number { get; set; }
        public string? use_bit { get; set; }
        public string? rider_cd { get; set; }
        public string? user_name { get; set; }
        public string? customer_type { get; set; }
        public string? email { get; set; }
        public string? fax_no { get; set; }
        public string? zipcode { get; set; }
        public string? sido { get; set; }
        public string? gugun { get; set; }
        public string? dong { get; set; }
        public string? address_detail { get; set; }
        public string? memo { get; set; }
        public string? modify_ip { get; set; }
    }
}