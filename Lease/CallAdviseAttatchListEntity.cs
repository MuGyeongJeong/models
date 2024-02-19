namespace models.Lease
{
    public class CallAdviseAttatchListEntity()
    {
        public int serial_number { get; set; }
        public DateTime? regist_date { get; set; }
        public string? regist_ip { get; set; }
        public string? cancel_bit { get; set; }
        public string? cancel_reason { get; set; }
        public string? use_bit { get; set; }
        public int call_advise_serial { get; set; }
        public string? attach_type { get; set; }
        public string? file_real_name { get; set; }
        public string? file_name { get; set; }
        public int file_size { get; set; }
        public string? file_type { get; set; }
        public int img_width { get; set; }
        public int img_height { get; set; }
    }
}