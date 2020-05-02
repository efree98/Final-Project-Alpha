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
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.Game _context;

        public IndexModel(FinalProject.Models.Game context)
        {
            _context = context;
        }

        public IList<Game> Games { get;set; }

        //Need To Fix

       /* public async Task OnGetAsync()
        {
            Games = await _context.Game.ToListAsync();
        }*/
    }
}
