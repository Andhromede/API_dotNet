using System;

namespace p2p.Models
{
    public class Person : GeneralItem
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string? adress { get; set; }
        public DateTime? birthday { get; set; }

        //public int Id_Role { get; set; }
    }
}
