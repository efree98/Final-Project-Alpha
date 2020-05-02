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

namespace FinalProject.Pages
{
    public class AddGameModel : PageModel
    {
        private readonly ILogger<AddGameModel> _logger;
        private readonly Game _context; // Game Database context
        [BindProperty]
        public Publisher Publisher {get; set;}
        public SelectList GameDropDown {get; set;}

        public AddGameModel(Game context, ILogger<AddGameModel> logger)
        {
            // Bring in Database context and logger using dependency injection
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            GameDropDown = new SelectList(_context.GameConsole.ToList(), "GameId", "GameTitle");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
           // _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}