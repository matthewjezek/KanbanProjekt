using System.ComponentModel.DataAnnotations;

namespace KanbanProjekt.Data
{
	public class ColumnModel
	{
		[Required]
		public int Id { get; set; }
		[Required(ErrorMessage = "Doplňte prosím nadpis")]
		public string? Title { get; set; }
		public string? BoxColor { get; set; }
        public ICollection<TaskItem>? TaskItems { get; set; } = new List<TaskItem>();

		public ColumnModel() { }

		public ColumnModel(string title, string color)
		{
			Title = title;
			BoxColor = color;
		}
	}
}
