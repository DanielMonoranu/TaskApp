using TaskManagementNet6.WebApi.Models;

namespace TaskManagementNet6.WebApi.Services
{
	public interface ITaskService
	{
		List<TaskModel> GetTasks();

		int InsertTask(TaskInsertDto input);
		TaskModel GetTask(int id);


		void UpdateTask(TaskModel taskModel);

		//void DeleteTask(int id);
		void DeleteTask(string name);
	}
}
