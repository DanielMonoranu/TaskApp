using Microsoft.AspNetCore.Mvc;
using TaskManagementNet6.WebApi.Models;
using TaskManagementNet6.WebApi.Services;

namespace TaskManagementNet6.WebApi.Controllers
{
	[ApiController]
	[Route("tasks")]
	public class TaskController : ControllerBase
	{
		private readonly ITaskService _taskService;

		public TaskController(ITaskService taskService)
		{
			_taskService = taskService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<TaskModel>> Get()
		{
			return _taskService.GetTasks();
		}

		[HttpGet]
		[Route("{taskId}")]
		public ActionResult<TaskModel> Get(int taskId)
		{
			return _taskService.GetTask(taskId);
		}

		[HttpPost]
		public ActionResult<int> Post(TaskInsertDto taskModel)
		{
			return _taskService.InsertTask(taskModel);
		}

		[HttpPut]
		public void Put(TaskModel taskModel)
		{
			_taskService.UpdateTask(taskModel);
		}

		[HttpDelete]
		//[Route("{taskId}")]
		[Route("{taskName}")]

		/*public void Delete(int taskId)
        {
            _taskService.DeleteTask(taskId);
        }
*/
		public void Delete(string taskName)
		{
			_taskService.DeleteTask(taskName);
		}
	}
}
