using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace p2p.Models
{
    public class Person
    {
        public int id { get; set; }
        public bool is_active { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string? adress { get; set; }
        public DateTime? birthday { get; set; }
        public int role { get; set; }

        //public int Id_Role { get; set; }
    }
}
