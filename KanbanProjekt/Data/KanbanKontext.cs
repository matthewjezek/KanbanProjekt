using Microsoft.EntityFrameworkCore;

namespace KanbanProjekt.Data
{
	public class KanbanKontext : DbContext
	{
		public DbSet<ColumnModel> Columns { get; set; }
		public DbSet<TaskItem> TaskItems { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=kanban.db");
		}
	}

}
