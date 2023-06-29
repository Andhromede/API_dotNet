using Microsoft.EntityFrameworkCore;

namespace p2pAPI.Models;

    public class P2PContext : DbContext
    {
    public P2PContext(DbContextOptions<P2PContext> options)
       : base(options)
    {
    }

    public DbSet<Person> Persons { get; set; } = null!;
}
