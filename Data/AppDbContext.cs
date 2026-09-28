using Microsoft.EntityFrameworkCore;

namespace MyBlazorApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();

    public DbSet<Goal> Goals => Set<Goal>();

    public DbSet<Comment> Comments => Set<Comment>();

    public DbSet<Rating> Ratings => Set<Rating>();
}   