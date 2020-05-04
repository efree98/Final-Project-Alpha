using Microsoft.EntityFrameworkCore;
namespace FinalProject.Models
{
	public class BoardGameDbContext : DbContext
	{
		public BoardGameDbContext (DbContextOptions<GameDbContext> options)
			: base(options)
		{
		}
		public DbSet<Game> Game {get; set;}
	}
}
