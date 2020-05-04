using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalProject.Models;

namespace FinalProject.Pages.BoardGames
{
    public class CreateBoardGameModel : PageModel
    {
        private readonly FinalProject.Models.BoardGameDbContext _context;

        public CreateBoardGameModel(FinalProject.Models.BoardGameDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BoardGame BoardGame { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BoardGame.Add(BoardGame);
         await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
