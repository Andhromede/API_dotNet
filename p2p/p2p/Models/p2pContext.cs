using Microsoft.EntityFrameworkCore;
using p2p.Models;
namespace p2pAPI.Models;


public class P2PContext : DbContext
{
    public P2PContext(DbContextOptions<P2PContext> options) : base(options)
    {
    }

    public DbSet<p2p.Models.Chapter>? Chapter { get; set; }
    public DbSet<p2p.Models.Lesson>? Lesson { get; set; }
    public DbSet<p2p.Models.Person>? Person { get; set; }
    public DbSet<p2p.Models.Person_Lesson>? Person_Lesson { get; set; }
    public DbSet<p2p.Models.Person_Training>? Person_Training { get; set; }
    public DbSet<p2p.Models.Role>? Role { get; set; }
    public DbSet<p2p.Models.Tag>? Tag { get; set; }
    public DbSet<p2p.Models.Training>? Training { get; set; }


/*

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Person>(entity =>
        {
            entity.ToTable("person");

            entity.HasIndex(e => e.id, "id");

            entity.Property(e => e.birthday)
                .HasColumnType("datetime")
                .HasColumnName("birthday");

            entity.Property(e => e.email)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("email");

            entity.Property(e => e.roleId)
                .HasColumnName("roleId")
                .HasDefaultValueSql("'1'");

            entity.Property(e => e.isActive)
                .IsRequired()
                .HasColumnName("isActive")
                .HasDefaultValueSql("True");

            entity.Property(e => e.firstName)
                .HasMaxLength(100)
                .HasColumnName("firstName");

            entity.Property(e => e.lastName)
                .HasMaxLength(100)
                .HasColumnName("lastName");

            entity.Property(e => e.password)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("password");

            entity.Property(e => e.adress)
                .HasMaxLength(255)
                .HasColumnName("adress");
        });









        // One to Many
        modelBuilder.Entity<Role>()
            .HasMany(c => c.persons)
            .WithOne(e => e.role)
            .HasForeignKey(e => e.roleId);

        *//*modelBuilder.Entity<Person>()
            .HasMany(c => c.personLessons)
            .WithOne(e => e.person)
            .HasForeignKey(e => e.personId);*//*

        modelBuilder.Entity<Person>()
            .HasMany(c => c.personTrainings)
            .WithOne(e => e.person)
            .HasForeignKey(e => e.personId);

        modelBuilder.Entity<Person>()
            .HasMany(c => c.chapters)
            .WithOne(e => e.person)
            .HasForeignKey(e => e.personId);

        modelBuilder.Entity<Training>()
            .HasMany(c => c.personTrainings)
            .WithOne(e => e.training)
            .HasForeignKey(e => e.trainingId);

        modelBuilder.Entity<Tag>()
            .HasMany(c => c.trainings)
            .WithOne(e => e.tag)
            .HasForeignKey(e => e.tagId);

        modelBuilder.Entity<Tag>()
            .HasMany(c => c.lessons)
            .WithOne(e => e.tag)
            .HasForeignKey(e => e.tagId);

        modelBuilder.Entity<Lesson>()
            .HasMany(c => c.personLessons)
            .WithOne(e => e.lesson)
            .HasForeignKey(e => e.lessonId);

        // Many to Many
        modelBuilder.Entity<Training>()
            .HasMany(e => e.chapters)
            .WithMany(c => c.trainings);

        modelBuilder.Entity<Lesson>()
            .HasMany(e => e.chapters)
            .WithMany(c => c.lessons);

        modelBuilder.Entity<Tag>()
            .HasMany(e => e.chapters)
            .WithMany(c => c.tags);

    }*/
}
