using System;

namespace p2p.Models
{
    public class Person
    {
        public int id { get; set; }
        public bool isActive { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string? adress { get; set; }
        public DateTime? birthday { get; set; }


/*        public int? roleId { get; set; }*/
        public Role? role { get; set; }
        public List<Person_Training>? personTrainings { get; set; }
        public List<Person_Lesson>? personLessons { get; set; }
        public List<Chapter>? chapters { get; set; }

    }
}
