using Microsoft.EntityFrameworkCore;
using p2p.Models;
namespace p2pAPI.Models;

public class P2PContext : DbContext
{
    public P2PContext(DbContextOptions<P2PContext> options) : base(options)
    {
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    if (!optionsBuilder.IsConfigured)
    //    {
    //        optionsBuilder.UseNpgsql("\"server=localhost;port=5432;database=p2p_dotNet;user=Nath;password=1234;\"");
    //    }
    //}

    public DbSet<GeneralItem> GeneralItems { get; set; } = null!;

    public DbSet<p2p.Models.Chapter>? Chapter { get; set; }

    public DbSet<p2p.Models.Lesson>? Lesson { get; set; }

    public DbSet<p2p.Models.Person>? Person { get; set; }

    public DbSet<p2p.Models.Role>? Role { get; set; }

    public DbSet<p2p.Models.Tag>? Tag { get; set; }

    public DbSet<p2p.Models.Training>? Training { get; set; }
}
