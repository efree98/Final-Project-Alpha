using Microsoft.EntityFrameworkCore;
namespace FinalProject.Models
{
	public class GameDbContext : DbContext
	{
		public GameDbContext (DbContextOptions<GameDbContext> options)
			: base(options)
		{
		}
		public DbSet<Game> Game {get; set;}
	}
}
