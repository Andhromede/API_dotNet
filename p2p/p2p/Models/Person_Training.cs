namespace p2p.Models
{
    public class Person_Training
    {
        public int id { get; set; }
        public bool isActive { get; set; }
        public bool isAuthor { get; set; }


        public int personId { get; set; }
        public Person? person { get; set; }
        public int trainingId { get; set; }
        public Training? training { get; set; }
    }
}
