using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using NSwag.Annotations;

namespace models.Lease
{
    public class ArticlesInsert()
    {
        public string? board_id { get; set; }
        public string? user_id { get; set; }
        public string? name { get; set; }
        public string? subject { get; set; }
        public string? section { get; set; }
        //CHECK 기존 소스는 tag_content, 프로시저는 tab_contents로 되어 있음.
        // public string? tag_content { get; set; }
        public string? tab_content { get; set; }
        public string? text_content { get; set; }
        public int hit { get; set; }
        public string? password { get; set; }
        public string? open_bit { get; set; }
        public string? notice_bit { get; set; }
        public int attach_count { get; set; }
        public int ref_ { get; set; }
        public int ref_step { get; set; }
        public int ref_depth { get; set; }
        public string? img_position { get; set; }
        public string? regist_ip { get; set; }
    }
}