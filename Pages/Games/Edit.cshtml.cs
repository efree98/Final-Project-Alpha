using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.Games
{
    public class EditModel : PageModel
    {
        private readonly FinalProject.Models.Game _context;

        public EditModel(FinalProject.Models.Game context)
        {
            _context = context;
        }

        [BindProperty]
        public Game Games { get; set; }

       /* public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Games = await _context.Game.FirstOrDefaultAsync(m => m.GamesId == id);

            if (Games == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
       
       //NEED TO FIX
       /* public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Games).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(Games.GameId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GameExists(int id)
        {
            return _context.GameEx.Any(e => e.GameId == id);
        }
    */}
}
