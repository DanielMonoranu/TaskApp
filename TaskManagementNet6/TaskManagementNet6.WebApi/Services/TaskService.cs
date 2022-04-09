using TaskManagementNet6.WebApi.Models;
using TaskManagementNet6.WebApi.Persistance;

namespace TaskManagementNet6.WebApi.Services
{
    public class TaskService : ITaskService
    {
        private readonly IApplicationDbContext _context;
        public TaskService(IApplicationDbContext context)
        {
            _context = context;
        }
        /*
        public void DeleteTask(int id)
        {
            var task = _context.Set<TaskModel>().FirstOrDefault(t => t.Id == id);
            _context.Set<TaskModel>().Remove(task);
            _context.SaveChanges();

        }
      */
        public void DeleteTask(string name)
        {
            var task = _context.Set<TaskModel>().FirstOrDefault(t => t.Name == name);
            _context.Set<TaskModel>().Remove(task);
            _context.SaveChanges();

        }
        public TaskModel GetTask(int id)
        {
            return _context.Set<TaskModel>().FirstOrDefault(t => t.Id == id);

        }

        public List<TaskModel> GetTasks()
        {
            return _context.Set<TaskModel>().ToList();

        }

        public int InsertTask(TaskInsertDto input)
        {
            var taskModel = new TaskModel()
            {
                Name = input.Name,
                UserId = input.UserId,
                Description = input.Description,
                DateCreated = new DateTime(),
                DateModified = new DateTime(),
                
    };
            _context.Set<TaskModel>().Add(taskModel);
            _context.SaveChanges();
            return taskModel.Id;
        }

        public void UpdateTask(TaskModel taskModel)
        {
            var task = _context.Set<TaskModel>().FirstOrDefault(t => t.Id == taskModel.Id);
            task.Name = taskModel.Name;
            _context.SaveChanges();

        }
    }
}
