using TaskManagementNet6.WebApi.Models;

namespace TaskManagementNet6.WebApi.Persistance
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Tasks.Any())
            {
                return;
            }
            var tasks = new List<TaskModel>()
{
new TaskModel
{
Name = "Coding",
User = new UserModel
{
Name = "John Smith"
},
Description = "Some Description"
},
new TaskModel
{
Name = "Code Review",
User = new UserModel
{
Name = "Jane Doe"
},
Description = "Some Description"
}
};



            foreach (TaskModel task in tasks)
            {
                context.Tasks.Add(task);
            }



            context.SaveChanges();
        }
    }
}