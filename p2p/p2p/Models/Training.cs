namespace p2p.Models
{
    public class Training
    {
        public int id { get; set; }
        public bool isActive { get; set; }
        public string title { get; set; }


        public int tagId { get; set; }
        public Tag? tag { get; set; }
        public List<Chapter>? chapters { get; set; }
        public List<Person_Training>? personTrainings { get; set; }
    }
}
