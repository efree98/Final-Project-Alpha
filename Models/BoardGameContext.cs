using Microsoft.EntityFrameworkCore;
namespace FinalProject.Models
{
	public class BoardGameDbContext : DbContext
	{
		public BoardGameDbContext (DbContextOptions<BoardGameDbContext> options)
			: base(options)
		{
		}
		public DbSet<BoardGame> BoardGame {get; set;}
	}
}
