namespace models.Lease
{
    public class CalladviseDataEntity()
    {
        public string? adviser_name { get; set; }
        public string? db_type { get; set; }
        public int telserver_serial { get; set; }
        public string? customer_type { get; set; }
        public string? customer_type_text { get; set; }
        public int serial_number { get; set; }
        public DateTime regist_date { get; set; }
        public string? regist_ip { get; set; }
        public DateTime modify_date { get; set; }
        public string? modify_ip { get; set; }
        public string? cancel_bit { get; set; }
        public string? cancel_reason { get; set; }
        public string? use_bit { get; set; }
        public string? advise_no { get; set; }
        public string? state_type { get; set; }
        public string? state_type_text { get; set; }
        public DateTime receive_date { get; set; }
        public string? tel_type { get; set; }
        public string? tel_type_text { get; set; }
        public string? rider_cd { get; set; }
        public string? rider_name { get; set; }
        public string? tel_no { get; set; }
        public string? extension_number { get; set; }
        public int advise_user_serial { get; set; }
        public string? question_memo { get; set; }
        public string? answer_memo { get; set; }
        public string? bike_id { get; set; }
        public string? bike_ssn { get; set; }
        public string? bike_make { get; set; }
        public string? bike_make_nm { get; set; }
        public string? bike_type { get; set; }
        public string? bike_type_nm { get; set; }
        public string? bike_color { get; set; }
        public string? bike_color_text { get; set; }
        public string? memo { get; set; }
        public int depth1_category_serial { get; set; }
        public string? depth1_category_name { get; set; }
        public int depth2_category_serial { get; set; }
        public string? depth2_category_name { get; set; }
        public int depth3_category_serial { get; set; }
        public string? depth3_category_name { get; set; }
        public int depth4_category_serial { get; set; }
        public string? depth4_category_name { get; set; }
        public string? attachdelete { get; set; }
        public string? complain_bit { get; set; }
        public string? complain_dept { get; set; }
        public string? complain_dept_text { get; set; }
    }
}