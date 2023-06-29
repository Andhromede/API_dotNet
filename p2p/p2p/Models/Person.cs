namespace p2p.Models
{
    public class Person
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string? adress { get; set; }
        public DateOnly? birthday { get; set; }

    }
}
