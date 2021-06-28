using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HREntity.Data;
using HREntity.Models;

namespace HREntity.Pages.Story
{
    public class DeleteModel : PageModel
    {
        private readonly HREntity.Data.HREntityContext _context;

        public DeleteModel(HREntity.Data.HREntityContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Testimonial Testimonial { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Testimonial = await _context.Testimonial.FirstOrDefaultAsync(m => m.Id == id);

            if (Testimonial == null)
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

            Testimonial = await _context.Testimonial.FindAsync(id);

            if (Testimonial != null)
            {
                _context.Testimonial.Remove(Testimonial);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
