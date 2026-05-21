using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace TaskManager.Infrastructure.Configurations
{
  
  public class TenantConfiguration : IEntityTypeConfiguration<Tenant>
  {
    public void Configure (EntityTypeBuilder<Tenant> builder)
    {
      builder.HasKey(t=>t.Id);

      builder.Property(t=>t.Name).IsRequired().HasMaxLength(200);

      builder.HasMany(t => t.Users).WithOne(u=> u.Tenant).HasForeignKey(u => u.TenantId);
    }
  }
}