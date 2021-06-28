using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HREntity.Data;
using HREntity.Models;

namespace HREntity.Pages.Contact
{
    public class IndexModel : PageModel
    {
        private readonly HREntity.Data.HREntityContext _context;

        public IndexModel(HREntity.Data.HREntityContext context)
        {
            _context = context;
        }

        public IList<Feedback> Feedback { get;set; }

        public async Task OnGetAsync()
        {
            Feedback = await _context.Feedback.ToListAsync();
        }
    }
}
