
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementNet6.WebApi.Models;

namespace TaskManagementNet6.WebApi.Persistance.NewFolder
{
    public class TaskModelConfiguration : IEntityTypeConfiguration<TaskModel>
    {
        public void Configure(EntityTypeBuilder<TaskModel> builder)
        {
            builder.HasOne(t => t.User)
                .WithMany(t => t.Task)
                .HasForeignKey(t => t.UserId)
                .HasConstraintName("FK_Task_User");
        }
    }
}
