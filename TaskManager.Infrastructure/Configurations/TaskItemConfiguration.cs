using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace TaskManager.Infrastructure.Configurations

{
  public class TaskItemConfiguration : IEntityTypeConfiguration<TaskItem>
  {
    public void Configure (EntityTypeBuilder<TaskItem> builder)
    {
      
      builder.HasKey(u=>u.Id);
      builder.Property(u=>u.Status).HasConversion<string>();
      builder.Property(u=>u.Description).HasMaxLength(2000);
      builder.Property(u=>u.Title).HasMaxLength(200).IsRequired();

      builder.HasOne(u=>u.Tenant).WithMany().HasForeignKey(u => u.TenantId)
      .OnDelete(DeleteBehavior.Restrict);

      builder.HasOne(u=>u.Project).WithMany(u=>u.Tasks).HasForeignKey(u=>u.ProjectId).OnDelete(DeleteBehavior.Restrict);

      builder.HasOne(u=>u.AssignedToUser).WithMany().HasForeignKey(u=>u.AssignedToUserId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);

      builder.HasOne(w => w.CreatedByUser).WithMany().HasForeignKey(w => w.CreatedByUserId).OnDelete(DeleteBehavior.Restrict);

    
  }
}}