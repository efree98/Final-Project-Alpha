using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly FinalProject.Models.Game _context;

        public DetailsModel(FinalProject.Models.Game context)
        {
            _context = context;
        }

        public Game Game { get; set; }
        [BindProperty]
        public int CourseIdToDelete {get; set;}

        //NEED TO FIX
       /* public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Round 3: Add .Include() to bring in courses
            Game = await _context.Game.Include(p => p.Publisher).FirstOrDefaultAsync(m => m.GameId == id);

            if (Game == null)
            {
                return NotFound();
            }
            return Page();
        }*/

        
    }
}
