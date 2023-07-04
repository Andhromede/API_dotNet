namespace p2p.Models
{
    public class Role
    {
        public int id { get; set; }
        public bool is_active { get; set; }
        public string name { get; set; }
        public Array persons { get; set; }
    }
}
