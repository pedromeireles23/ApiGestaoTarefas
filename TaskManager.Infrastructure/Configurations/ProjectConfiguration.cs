using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Application.Entities;

namespace TaskManager.Infrastructure.Configurations


{
  public class ProjectConfiguration : IEntityTypeConfiguration<Project>
  {
    public void Configure (EntityTypeBuilder<Project> builder)
    {
      builder.HasKey(u=>u.Id);

      builder.Property(u=>u.Name).HasMaxLength(200).IsRequired();
      builder.HasOne(u=>u.Tenant).WithMany().HasForeignKey(u => u.TenantId)
      .OnDelete(DeleteBehavior.Restrict);

      builder.HasOne(w => w.CreatedByUser).WithMany().HasForeignKey(w => w.CreatedByUserId).OnDelete(DeleteBehavior.Restrict);

      builder.HasOne(w=> w.Workspace).WithMany().HasForeignKey(w=>w.CreatedByUserId).OnDelete(DeleteBehavior.Restrict);

    }
  }
}