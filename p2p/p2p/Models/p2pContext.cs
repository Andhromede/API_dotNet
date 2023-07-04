using Microsoft.EntityFrameworkCore;
using p2p.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace p2pAPI.Models;


public class P2PContext : DbContext
{
    public P2PContext(DbContextOptions<P2PContext> options) : base(options)
    {
    }

    //public DbSet<GeneralItem> GeneralItem { get; set; } = null!;

    public DbSet<p2p.Models.Chapter>? Chapter { get; set; }

    public DbSet<p2p.Models.Lesson>? Lesson { get; set; }

    public DbSet<p2p.Models.Person>? Person { get; set; }

    public DbSet<p2p.Models.Role>? Role { get; set; }

    public DbSet<p2p.Models.Tag>? Tag { get; set; }

    public DbSet<p2p.Models.Training>? Training { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasOne(u => u.role)
            .WithOne(p => p.person)
            .HasForeignKey<Role>(p => p.id);
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    if (!optionsBuilder.IsConfigured)
    //    {
    //        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=Nath;database=p2p_dotNet");
    //    }

    //}
}
