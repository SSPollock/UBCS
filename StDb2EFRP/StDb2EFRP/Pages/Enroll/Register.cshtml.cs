using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StDb2EFRP.Models;

namespace StDb2EFRP
{
    public class RegisterModel : PageModel
    {
        private readonly StDb2EFRP.Models.StDb2SqlContext _context;

        public RegisterModel(StDb2EFRP.Models.StDb2SqlContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CourseNum"] = new SelectList(_context.Courses, "CourseNum", "CourseNum");
        ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId");
            return Page();
        }

        [BindProperty]
        public Enrollment Enrollment { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Enrollment.Add(Enrollment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
