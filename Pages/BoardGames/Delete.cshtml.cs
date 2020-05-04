using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace Final_Project_Alpha.Pages.BoardGames
{
    public class DeleteBoardGameModel : PageModel
    {
        private readonly FinalProject.Models.BoardGameDbContext _context;

        public DeleteBoardGameModel(FinalProject.Models.BoardGameDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BoardGame BoardGame { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BoardGame = await _context.BoardGame.FirstOrDefaultAsync(m => m.BoardGameId == id);

            if (BoardGame == null)
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

            BoardGame = await _context.BoardGame.FindAsync(id);

            if (BoardGame != null)
            {
                _context.BoardGame.Remove(BoardGame);
                await _context.SaveChangesAsync();
            }  

            

            return RedirectToPage("./Index");
        }
    }
}
