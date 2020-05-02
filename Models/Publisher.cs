using System;

namespace FinalProject.Models
{
    public class Publisher
    {
        public int PublisherId {get; set;} // Primary Key
        public string Publishing_Company {get; set;}
        public Game Game {get; set;}
    }
}