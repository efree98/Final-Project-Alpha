using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab11.Models;

namespace Lab11.Pages.Games
{
    public class DeleteModel : PageModel
    {
        private readonly Lab11.Models.GamesContext _context;

        public DeleteModel(Lab11.Models.GamesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GamesList GamesList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GamesList = await _context.GamesList.FirstOrDefaultAsync(m => m.GamesId == id);

            if (GamesList == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GamesList = await _context.Games.FindAsync(id);

            if (GamesList != null)
            {
                _context.Game.Remove(Game);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
