using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Application.Entities;
namespace TaskManager.Infrastructure.Configurations
{
  public class UserConfiguration : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
      builder.HasKey(t=>t.Id);
      builder.Property(t=>t.Name).IsRequired().HasMaxLength(200);
      builder.Property(t=>t.Email).IsRequired().HasMaxLength(256);
      builder.HasIndex(u=>u.Email).IsUnique();
      builder.Property(u => u.Role).HasConversion<string>();
      builder.HasOne(u => u.Tenant)
       .WithMany(t => t.Users)
       .HasForeignKey(u => u.TenantId)
       .OnDelete(DeleteBehavior.Restrict);
       builder.Property(u=>u.PasswordHash).IsRequired();

    }
  }
}