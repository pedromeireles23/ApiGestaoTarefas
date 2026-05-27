using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TaskManager.Application.Entities;
using TaskManager.Application.Interfaces;

namespace TaskManager.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        private readonly ITenantService _tenantService;

        public AppDbContext(DbContextOptions<AppDbContext> options, ITenantService tenantService) : base(options)
        {
            _tenantService = tenantService;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

   
            modelBuilder.Entity<User>().HasQueryFilter(u => u.TenantId == _tenantService.TenantId);
            modelBuilder.Entity<Workspace>().HasQueryFilter(w => w.TenantId == _tenantService.TenantId);
            modelBuilder.Entity<Project>().HasQueryFilter(p => p.TenantId == _tenantService.TenantId);
            modelBuilder.Entity<TaskItem>().HasQueryFilter(t => t.TenantId == _tenantService.TenantId);
        }

        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Workspace> Workspaces { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}