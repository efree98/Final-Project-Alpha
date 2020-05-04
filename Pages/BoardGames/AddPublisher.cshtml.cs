using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final_Project_Alpha.Pages.BoardGames
{
    public class AddBoardGameModel : PageModel
    {
        private readonly ILogger<AddBoardGameModel> _logger;
        private readonly BoardGameDbContext _context; // Game Database context
        [BindProperty]
        public Publisher BoardGamePublisher {get; set;}
        public SelectList BoardGameDropDown {get; set;}

        public AddBoardGameModel(BoardGameDbContext context, ILogger<AddBoardGameModel> logger)
        {
            // Bring in Database context and logger using dependency injection
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            BoardGameDropDown = new SelectList(_context.BoardGame.ToList(), "BoardGameId", "BoardGameTitle");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _context.Add(BoardGamePublisher);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}