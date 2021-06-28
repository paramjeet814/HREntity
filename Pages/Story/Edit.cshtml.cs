using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HREntity.Data;
using HREntity.Models;

namespace HREntity.Pages.Story
{
    public class EditModel : PageModel
    {
        private readonly HREntity.Data.HREntityContext _context;

        public EditModel(HREntity.Data.HREntityContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Testimonial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestimonialExists(Testimonial.Id))
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

        private bool TestimonialExists(int id)
        {
            return _context.Testimonial.Any(e => e.Id == id);
        }
    }
}
