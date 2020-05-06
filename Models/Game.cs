using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 


namespace FinalProject.Models
{
    public class Game
    {
        public int GameId {get; set;}	// Primary Key
  
        [Required]
        public string GameTitle {get; set;}


        [Required]

        public String Rating {get; set;}

        [Required]

        public String Price {get; set;}

        [Required]

        public String GameConsole {get; set;}

        [Required]

        public List<Publisher> Publisher {get; set;}
        
    }
}
