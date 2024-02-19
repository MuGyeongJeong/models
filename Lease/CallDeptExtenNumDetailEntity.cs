namespace models.Lease
{
    public class CallDeptExtenNumDetailEntity()
    {
        public int serial_number { get; set; }
        public DateTime regist_date { get; set; }
        public string? regist_ip { get; set; }
        public DateTime modify_date { get; set; }
        public string? modify_ip { get; set; }
        public string? cancel_bit { get; set; }
        public string? cancel_reason { get; set; }
        public string? use_bit { get; set; }
        public string? dept_type { get; set; }
        public string? dept_type_text { get; set; }
        public string? user_name { get; set; }
        public string? user_type { get; set; }
        public string? email { get; set; }
        public string? dept_telno { get; set; }
        public string? extension_number { get; set; }
        public string? tel_no { get; set; }
        public string? dept_role { get; set; }
        public string? memo { get; set; }
    }
}