namespace models.Lease
{
    public class CategoryDataListEntity() : CategoryDataEntity()
    {
        public string? sort_depth { get; set; }
        public int depth1_serial_number { get; set; }
        public string? depth1_item_name { get; set; }
        public int depth2_serial_number { get; set; }
        public string? depth2_item_name { get; set; }
        public int depth3_serial_number { get; set; }
        public string? depth3_item_name { get; set; }
    }
}