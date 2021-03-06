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

namespace Final_Project_Alpha.Pages.Games
{
    public class AddPublisherModel : PageModel
    {
        private readonly ILogger<AddPublisherModel> _logger;
        private readonly GameDbContext _context; // Game Database context
        [BindProperty]
        public Publisher Publisher {get; set;}
        public SelectList GameDropDown {get; set;}

        public AddPublisherModel(GameDbContext context, ILogger<AddPublisherModel> logger)
        {
            // Bring in Database context and logger using dependency injection
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            GameDropDown = new SelectList(_context.Game.ToList(), "GameId", "GameTitle");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _context.Add(Publisher);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}