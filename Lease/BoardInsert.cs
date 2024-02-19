using System.ComponentModel.DataAnnotations;

namespace models.Lease
{
    public class BoardInsert()
    {
        public string? board_id { get; set; }
        public string? board_type { get; set; }
        public string? board_summary { get; set; }
        public string? bad_word { get; set; }
        public int article_new { get; set; }
        public string? article_write_bit { get; set; }
        public string? article_hidden_bit { get; set; }
        public string? article_editor_bit { get; set; }
        public string? article_notice_bit { get; set; }
        public int article_notice_limit { get; set; }
        public string? article_section_bit { get; set; }
        public string? article_section { get; set; }
        public int attach_limit { get; set; }
        public int attach_size_limit { get; set; }
        public string? attach_size_limit_bit { get; set; }
        public string? comment_bit { get; set; }
        public string? comment_write_bit { get; set; }
        public string? regist_ip { get; set; }
    }
}