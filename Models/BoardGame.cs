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

        /* 
        <li class="nav-item">
                            <a class="nav-link text-dark" asp-area="" asp-page="/BoardGames/Create">Add Board Game</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link text-dark" asp-area="" asp-page="/BoardGames/Create">Delete Board Game</a>
                        </li>
        */
    }
}