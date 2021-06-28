using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HREntity.Data;
using HREntity.Models;

namespace HREntity.Pages.About
{
    public class DeleteModel : PageModel
    {
        private readonly HREntity.Data.HREntityContext _context;

        public DeleteModel(HREntity.Data.HREntityContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Achievments Achievments { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Achievments = await _context.Achievments.FirstOrDefaultAsync(m => m.Id == id);

            if (Achievments == null)
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

            Achievments = await _context.Achievments.FindAsync(id);

            if (Achievments != null)
            {
                _context.Achievments.Remove(Achievments);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
