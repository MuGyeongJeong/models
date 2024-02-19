namespace models.Lease
{
    public class AttachInsert()
    {
        public int article_serial { get; set; }
        public string? file_real_name { get; set; }
        public string? file_name { get; set; }
        public int file_size { get; set; }
        public string? file_type { get; set; }
        public int img_width { get; set; }
        public int img_height { get; set; }
        public string? regist_ip { get; set; }
    }
}