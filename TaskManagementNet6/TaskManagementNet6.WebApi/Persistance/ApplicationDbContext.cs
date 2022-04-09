using Microsoft.EntityFrameworkCore;
using TaskManagementNet6.WebApi.Models;

namespace TaskManagementNet6.WebApi.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<TaskCategoryModel> TaskCategories { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskModel>().ToTable("Task");
            modelBuilder.Entity<UserModel>().ToTable("User");
            modelBuilder.Entity<TaskCategoryModel>().ToTable("TaskCategory");
            modelBuilder.Entity<CategoryModel>().ToTable("Category");

        }
        public IQueryable<TEnt> ReadSet<TEnt>() where TEnt : class
        {
            //var elements =Set<TEnt>();
            //elements.ForEachAsync();
            //     context.SaveChanges();  //no tracking face ca sa nu se salveze schimbari

            return Set<TEnt>().AsNoTracking();
        }


    }
}
