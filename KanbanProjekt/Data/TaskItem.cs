using System.ComponentModel.DataAnnotations;

namespace KanbanProjekt.Data
{
	public class TaskItem
	{
		[Required]
		public int Id { get; set; }
		[Required(ErrorMessage = "Doplňte prosím nadpis")]
		public string Title { get; set; }
		public string? Description { get; set; }
		public DateOnly? Deadline { get; set; }
		[Required]
		public bool IsCompleted { get; set; }
        public int ColumnId { get; set; }
    }
}
