using System;
using System.Collections.Generic;
namespace FinalProject.Models
{
    public class BoardGame
    {
        public int BoardGameId {get; set;}	// Primary Key

        public string BoardGameTitle {get; set;}


        public String Price {get; set;}

        

        public List<Publisher> BoardGamePublisher {get; set;}
    }
}