using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
namespace FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<GameDbContext>>()))
            {
                // Look for any blogs.
                if (context.Game.Any())
                {
                    return; // DB has been seeded
                }
                
                context.Game.AddRange(
                    new Game 
                    {
                        GameTitle = "The Legend of Zelda: Breath of the Wild",

                        Rating = "E",

                        Price = "60",

                        GameConsole = "Nintendo Switch"
                    },
                       new Game 
                    {
                        GameTitle = "Mario Kart 8 Deluxe",

                        Rating = "E",

                        Price = "60",

                        GameConsole = "Nintendo Switch"
                    },
                           new Game 
                    {
                        GameTitle = "Spider Man",

                        Rating = "T",

                        Price = "45",

                        GameConsole = "PlayStation4"
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}
