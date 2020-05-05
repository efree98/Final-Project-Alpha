using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using FinalProject.Models;

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
                    },
                        new Game 
                    {
                        GameTitle = "Super Bit Defender XL",

                        Rating = "E",

                        Price = "0.99",

                        GameConsole = "Nintendo Switch"
                    },

                        new Game
                    {
                        GameTitle = "Pokemon Sheild",

                        Rating = "E",

                        Price = "60",

                        GameConsole = "Nintendo Switch"
                    },

                            new Game
                    {
                        GameTitle = "Pokemon Red",

                        Rating = "E",

                        Price = "40",

                        GameConsole = "Nintendo Gameboy"
                    },
                        new Game
                    {
                        GameTitle = "Defunct",

                        Rating = "E",

                        Price = "0.29",

                        GameConsole = "Nintendo Switch"
                    },
                        new Game
                        {
                        GameTitle = "Minecraft",

                        Rating = "E",

                        Price = "30",

                        GameConsole = "Nintendo Switch"
                    },
                        new Game
                        {
                        GameTitle = "Metroid Prime",

                        Rating = "T",

                        Price = "60",

                        GameConsole = "Nintendo Gamecube"
                    },
                        new Game
                        {
                        GameTitle = "Halo Combat Evolved",

                        Rating = "M",

                        Price = "60",

                        GameConsole = "Xbox"
                    },
                           new Game 
                    {
                        GameTitle = "Tetris 99",

                        Rating = "E",

                        Price = "10",

                        GameConsole = "Nintendo Switch"
                    },
                           new Game 
                    {
                        GameTitle = "Stardew Valley",

                        Rating = "T",

                        Price = "45",

                        GameConsole = "Nintendo Switch"
                    },
                        new Game 
                    {
                        GameTitle = "Super Smash Bros Ultimate",

                        Rating = "E",

                        Price = "0.99",

                        GameConsole = "Nintendo Switch"
                    },

                        new Game
                    {
                        GameTitle = "Doom (2016)",

                        Rating = "E",

                        Price = "20",

                        GameConsole = "Nintendo Switch"
                    },

                            new Game
                    {
                        GameTitle = "Super Mario Maker 2",

                        Rating = "E",

                        Price = "40",

                        GameConsole = "Nintendo Switch"
                    }
                );
                
                context.SaveChanges();
            }

             using (var context = new BoardGameDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<BoardGameDbContext>>()))
            {
                // Look for any blogs.
                if (context.BoardGame.Any())
                {
                    return; // DB has been seeded
                }
                
                context.BoardGame.AddRange(
                    new BoardGame
                    {
                        BoardGameTitle = "Risk",
                        Price = "0",    
                    },

                       new BoardGame 
                    {
                        BoardGameTitle = "Othello",

                        Price = "20",
                    },
                           new BoardGame 
                    {
                         BoardGameTitle = "Senet",
                        Price = "25"
                    },
                          new BoardGame
                    {
                        BoardGameTitle = "Chess",
                        Price = "100",    
                    },

                       new BoardGame 
                    {
                        BoardGameTitle = "Monopoly",

                        Price = "20",
                    },
                          new BoardGame
                    {
                        BoardGameTitle = "Pandemic",
                        Price = "10",    
                    },

                       new BoardGame 
                    {
                        BoardGameTitle = "Life",

                        Price = "3",
                    },
                          new BoardGame
                    {
                        BoardGameTitle = "Ticket to Ride",
                        Price = "0",    
                    },

                       new BoardGame 
                    {
                        BoardGameTitle = "Clue",

                        Price = "20",
                    },
                          new BoardGame
                    {
                        BoardGameTitle = "Stratego",
                        Price = "15",    
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}
