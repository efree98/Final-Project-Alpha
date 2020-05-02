using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab11.Pages.Games
{
    public class DeleteCourseModel : PageModel
    {
        private readonly Game _context; // Database context
        private readonly ILogger _logger; // Logging object

        // Model Constructor. Used to bring in _context and logger from Dependency Injection
        public DeleteCourseModel(Game context, ILogger<DeleteCourseModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Drop down list of all the Courses
        public SelectList Courses {get; set;}

        // CourseId to delete. We bind this property because the user will select it in our form and submit it.
        [BindProperty]
        [Display(Name = "Course")]
        public int? CourseId {get; set;}

        public IActionResult OnGet(int? id)
        {
            _logger.LogInformation($"DeleteCourse OnGet() called. CourseId = '{CourseId}'. id = '{id}'");

            // Populate SelectList. This variable is brought into the Razor Page with the asp-items tag helper
            Courses = new SelectList(_context.Publisher.ToList(), "CourseId", "Description", id);
            return Page();
        }

        /*public IActionResult OnPost()
        {
            _logger.LogInformation($"DeleteCourse OnPost() called. CourseId = '{CourseId}'.");

            if (CourseId == null)
            {
                return NotFound();
            }
            // Find the course in the database
            Publisher c = _context.Publisher.Find(PublisherId);

            if (c != null)
            {
                _context.Publisher.Remove(c); // Delete the course
                _context.SaveChanges();
            }

            return RedirectToPage("./Index");
        }*/
    }
}