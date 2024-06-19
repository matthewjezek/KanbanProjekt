using Microsoft.AspNetCore.Mvc;

namespace KanbanProjekt.Data
{
	[ApiController]
	[Route("api/[controller]")]
	public class TasksController : ControllerBase
	{
		private readonly KanbanKontext _context;

		public TasksController(KanbanKontext context)
		{
			_context = context;
		}

		[HttpPost("updatecolumn")]
		public IActionResult UpdateColumn(int taskId, int columnId)
		{
			var taskItem = _context.TaskItems.Find(taskId);
			if (taskItem != null)
			{
				taskItem.ColumnId = columnId;
				_context.SaveChanges();
				return Ok();
			}
			return NotFound();
		}
	}
}
