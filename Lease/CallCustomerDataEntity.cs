namespace models.Lease
{
    public class CallCustomerDataEntity()
    {
        public string? input_path { get; set; }
        public string? insert_user_id { get; set; }
        public int serial_number { get; set; }
        public DateTime regist_date { get; set; }
        public string? regist_ip { get; set; }
        public DateTime modify_date { get; set; }
        public string? modify_ip { get; set; }
        public string? cancel_bit { get; set; }
        public string? cancel_reason { get; set; }
        public string? use_bit { get; set; }
        public string? customer_cd { get; set; }
        public string? rider_cd { get; set; }
        public string? user_name { get; set; }
        public string? rider_cid { get; set; }
        public string? customer_type { get; set; }
        public string? customer_type_text { get; set; }
        public string? email { get; set; }
        public string? fax_no { get; set; }
        public string? zipcode { get; set; }
        public string? sido { get; set; }
        public string? gugun { get; set; }
        public string? dong { get; set; }
        public string? address_detail { get; set; }
        public string? repair_agent_cd { get; set; }
        public string? repair_client_cd { get; set; }
        public string? bike_ssn { get; set; }
        public string? bike_id { get; set; }
        public string? bike_make { get; set; }
        public string? bike_type { get; set; }
        public string? bike_color { get; set; }
        public int bike_basic_mileage { get; set; }
        public string? repair_join_bit { get; set; }
        public string? used_join_bit { get; set; }
        public string? callcenter_join_bit { get; set; }
        public string? insrue_join_bit { get; set; }
        public string? app_join_bit { get; set; }
        public string? memo { get; set; }

        //for list
        public string? rider_nm { get; set; }
        public DateTime insrt_dt { get; set; }
        public string? insrt_user_id { get; set; }
        public string? admin_memo { get; set; }

        //for detail
        public string? insure_join_bit { get; set; }
    }
}