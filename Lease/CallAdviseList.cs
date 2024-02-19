using System.ComponentModel;

namespace models.Lease
{
    public class CallAdviseList()
    {
        public string? use_bit { get; set; }

        public string? advise_no { get; set; }
        public string? state_type { get; set; }
        public string? tel_type { get; set; }
        public string? tel_no { get; set; }
        public string? rider_cd { get; set; }
        public string? rider_name { get; set; }
        public string? extension_number { get; set; }
        public int advise_user_serial { get; set; }
        public int depth1_category_serial { get; set; }
        public int depth2_category_serial { get; set; }
        public int depth3_category_serial { get; set; }
        public int depth4_category_serial { get; set; }
        public string? from_date { get; set; }
        public string? to_date { get; set; }
        public string? row_size { get; set; }
        public string? current_page { get; set; }
    }
}