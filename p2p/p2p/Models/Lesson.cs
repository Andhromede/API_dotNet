namespace p2p.Models
{
    public class Lesson
    {
        public int id { get; set; }
        public bool isActive { get; set; }
        public string title { get; set; }
        public string content { get; set; }


        public int tagId { get; set; }
        public Tag? tag { get; set; }
        public  List<Person_Lesson>? personLessons { get; set; }
        public  List<Chapter>? chapters { get; set; }

    }
}
