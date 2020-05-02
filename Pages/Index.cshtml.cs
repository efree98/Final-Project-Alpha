using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace Final_Project_Alpha.Pages
{
    public class IndexModel : PageModel
    {
        private readonly GameDbContext _context; // Replaces the "db" variable from before

        private readonly ILogger<IndexModel> _logger;

        public List<Game> Games {get; set;}

        public IndexModel(GameDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void OnGet()
        {
            Games = _context.Game.ToList();

        }
    }
}
