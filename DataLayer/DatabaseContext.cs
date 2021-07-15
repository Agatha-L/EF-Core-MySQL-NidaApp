Public Class DatabaseContext
    public class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DataContext(DbContextOptions<DataContext> options)
    : base(options) { }
    protected override void OnModelCreating(ModelBuilder
    modelBuilder)
    {
        // Use Fluent API to configure
        // Map entities to tables
        modelBuilder.Entity<User>().ToTable("Users");
    }
}

End Class
