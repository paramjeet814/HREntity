﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HREntity.Data;
using HREntity.Models;

namespace HREntity.Pages.Firm
{
    public class DeleteModel : PageModel
    {
        private readonly HREntity.Data.HREntityContext _context;

        public DeleteModel(HREntity.Data.HREntityContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employer Employer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employer = await _context.Employer.FirstOrDefaultAsync(m => m.Id == id);

            if (Employer == null)
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

            Employer = await _context.Employer.FindAsync(id);

            if (Employer != null)
            {
                _context.Employer.Remove(Employer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
