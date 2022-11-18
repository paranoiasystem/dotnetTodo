using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class AppDbContext : DbContext
{
    public DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\marco\\RiderProjects\\Todo\\Todo.sqlite");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>().ToTable("Todo");
    }
    
}