namespace p2p.Models
{
    public class Chapter
    {
        public int id { get; set; }
        public string title { get; set; }
        public string? description { get; set; }
        public int? duration { get; set; }
        public bool is_active { get; set; }
    }
}
