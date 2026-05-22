using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TaskManager.Application.Entities;

namespace TaskManager.Infrastructure.Persistence
{
  public class AppDbContext : DbContext
  {

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
      
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}
    public DbSet<Tenant> Tenants {get;set;}
    public DbSet<User> Users {get;set;}
    public DbSet<Workspace> Workspaces {get;set;}
    public DbSet<Project> Projects {get;set;}
    public DbSet<TaskItem> TaskItems {get;set;}
  }
}