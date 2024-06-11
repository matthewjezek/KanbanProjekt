namespace KanbanProjekt.Data
{
	public class ColumnModel
	{
		public int Id { get; set; }
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
