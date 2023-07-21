namespace p2p.Models
{
    public class Role
    {
        public int id { get; set; }
        public bool isActive { get; set; }
        public string name { get; set; }


        public List<Person>? persons { get; set; }
    }
}
