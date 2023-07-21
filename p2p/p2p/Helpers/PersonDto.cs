namespace p2p.Helpers
{
    public class PersonDto
    {

        public record create(
            int id = null,
            bool isActive = null,
            string? firstName = null,
            string? lastName = null,
            string email = null,
            string password = null,
            string? adress = null,
            DateTime? birthday = null,
            int roleId = null
        );

        public record login(
            string email = null,
            string password = null
        );

    }
}
