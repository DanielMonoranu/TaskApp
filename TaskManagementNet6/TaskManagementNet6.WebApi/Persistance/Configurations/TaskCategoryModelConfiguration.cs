using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementNet6.WebApi.Models;

public class TaskCategoryModelConfiguration : IEntityTypeConfiguration<TaskCategoryModel>
{
    public void Configure(EntityTypeBuilder<TaskCategoryModel> builder)
    {
        builder.HasOne(t => t.Category)
        .WithMany(t => t.TaskCategory)
        .HasForeignKey(t => t.CategoryId)
        .HasConstraintName("FK_TaskCategory_Category");



        builder.HasOne(t => t.Task)
        .WithMany(t => t.TaskCategory)
        .HasForeignKey(t => t.TaskId)
        .HasConstraintName("FK_TaskCategory_Task");
    }
}