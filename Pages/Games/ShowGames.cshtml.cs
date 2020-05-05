using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace Final_Project_Alpha.Pages.Games
{
    public class ShowGameModel : PageModel
    {
        private readonly FinalProject.Models.GameDbContext _context;

        public ShowGameModel(FinalProject.Models.GameDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<Game> Games { get; set; }


       
       public void OnGet()

{

Games = _context.Game.ToList();

}
}

}
