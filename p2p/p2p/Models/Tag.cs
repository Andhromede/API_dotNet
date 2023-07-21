namespace p2p.Models
{
    public class Tag
    {
        public int id { get; set; }
        public bool isActive { get; set; }
        public string name { get; set; }


        public List<Lesson>? lessons { get; set; }
        public List<Chapter>? chapters { get; set; }
        public List<Training>? trainings { get; set; }


    }
}
