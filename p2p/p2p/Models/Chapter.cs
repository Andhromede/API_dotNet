namespace p2p.Models
{
    public class Chapter
    {
        public int id { get; set; }
        public bool isActive { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int? duration { get; set; }


        public int personId { get; set; }
        public Person? person { get; set; }
        public List<Lesson>? lessons { get; set; }
        public List<Tag>? tags { get; set; }
        public List<Training>? trainings { get; set; }
    }
}
