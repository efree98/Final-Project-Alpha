using System;
using System.Collections.Generic;
namespace FinalProject.Models
{
    public class Game
    {
        public int GameId {get; set;}	// Primary Key

        public string GameTitle {get; set;}

        public String Rating {get; set;}

        public String Price {get; set;}

        public String GameConsole {get; set;}

        public List<Publisher> Publisher {get; set;}
    }
}
