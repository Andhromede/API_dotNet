using System;

namespace p2p.Models
{
    public class Person_Lesson
    {
        public int id { get; set; }
        public bool isActive { get; set; }
        public bool isValidate { get; set; }


        public int personId { get; set; }
        public Person? person { get; set; }
        public int lessonId { get; set; }
        public Lesson? lesson { get; set; }

    }
}
