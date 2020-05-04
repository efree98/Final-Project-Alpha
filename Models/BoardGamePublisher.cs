using System;

namespace FinalProject.Models
{
    public class BoardGamePublisher
    {
        public int BoardGamePublisherId {get; set;} // Primary Key
        public string BoardGamePublishing_Company {get; set;}
        public BoardGame BoardGame {get; set;}
    }
}