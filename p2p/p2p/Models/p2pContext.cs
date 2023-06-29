using Microsoft.EntityFrameworkCore;
using p2p.Models;

namespace p2pAPI.Models;

    public class P2PContext : DbContext
    {
    public P2PContext(DbContextOptions<P2PContext> options)
       : base(options)
    {
    }

    public DbSet<GeneralItem> GeneralItems { get; set; } = null!;
}
